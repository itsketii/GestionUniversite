using System.Globalization;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public class LigneImport
{
    public int Numero { get; set; }
    public Etudiant Etudiant { get; set; }
    public string Erreur { get; set; }
    public bool Valide => string.IsNullOrEmpty(Erreur);
}

// Lecture et contrôle d'un fichier Excel d'étudiants, et génération du modèle
public static class ImportExcel
{
    public static readonly string[] Colonnes =
    {
        "Matricule", "Nom", "Prénoms", "Date de naissance", "Lieu de naissance", "Sexe", "E-mail", "Téléphone", "Adresse"
    };

    private static readonly CultureInfo Fr = new CultureInfo("fr-FR");
    private static readonly Regex Courriel = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

    public static void EnregistrerModele(string chemin)
    {
        using var classeur = new XLWorkbook();
        var feuille = classeur.Worksheets.Add("Étudiants");
        for (int i = 0; i < Colonnes.Length; i++) feuille.Cell(1, i + 1).Value = Colonnes[i];

        var entete = feuille.Range(1, 1, 1, Colonnes.Length);
        entete.Style.Font.Bold = true;
        entete.Style.Font.FontColor = XLColor.White;
        entete.Style.Fill.BackgroundColor = XLColor.FromHtml("#9B1B30");

        feuille.Cell(2, 1).Value = "ETU2026100";
        feuille.Cell(2, 2).Value = "KONE";
        feuille.Cell(2, 3).Value = "Awa";
        feuille.Cell(2, 4).Value = new DateTime(2005, 3, 14);
        feuille.Cell(2, 5).Value = "Abidjan";
        feuille.Cell(2, 6).Value = "F";
        feuille.Cell(2, 7).Value = "awa.kone@exemple.ci";
        feuille.Cell(2, 8).Value = "0700000000";
        feuille.Cell(2, 9).Value = "Cocody";
        feuille.Column(4).Style.DateFormat.Format = "dd/MM/yyyy";

        double[] largeurs = { 16, 18, 22, 20, 20, 8, 30, 16, 24 };
        for (int i = 0; i < largeurs.Length; i++) feuille.Column(i + 1).Width = largeurs[i];

        var consignes = classeur.Worksheets.Add("Consignes");
        consignes.Cell(1, 1).Value = "Consignes de remplissage";
        consignes.Cell(1, 1).Style.Font.Bold = true;
        consignes.Cell(3, 1).Value = "Remplissez la feuille « Étudiants » à partir de la ligne 2 (supprimez la ligne d'exemple).";
        consignes.Cell(4, 1).Value = "Obligatoires : Matricule, Nom, Prénoms, Date de naissance, Sexe (M ou F), E-mail.";
        consignes.Cell(5, 1).Value = "La date s'écrit jj/mm/aaaa. Le matricule et l'e-mail doivent être uniques.";
        consignes.Column(1).Width = 100;
        classeur.SaveAs(chemin);
    }

    public static List<LigneImport> Lire(string chemin)
    {
        var resultat = new List<LigneImport>();
        using var classeur = new XLWorkbook(chemin);
        var feuille = classeur.Worksheets.First();

        string premiereColonne = feuille.Cell(1, 1).GetFormattedString().Trim();
        if (!premiereColonne.Equals("Matricule", StringComparison.OrdinalIgnoreCase))
            throw new InvalidDataException("Le fichier ne respecte pas le modèle : la cellule A1 doit contenir « Matricule ». Téléchargez le modèle pour partir d'une base correcte.");

        var derniere = feuille.LastRowUsed();
        if (derniere == null) return resultat;

        var existants = new EtudiantDAO().Existants();
        var matriculesVus = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var emailsVus = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (int r = 2; r <= derniere.RowNumber(); r++)
        {
            string Texte(int colonne) => feuille.Cell(r, colonne).GetFormattedString().Trim();
            bool vide = true;
            for (int c = 1; c <= Colonnes.Length; c++)
                if (Texte(c) != "") vide = false;
            if (vide) continue;

            var erreurs = new List<string>();
            var etudiant = new Etudiant
            {
                Matricule = Texte(1),
                Nom = Texte(2),
                Prenoms = Texte(3),
                LieuNaissance = Texte(5) == "" ? null : Texte(5),
                Email = Texte(7),
                Telephone = Texte(8) == "" ? null : Texte(8),
                Adresse = Texte(9) == "" ? null : Texte(9)
            };

            if (etudiant.Matricule == "") erreurs.Add("matricule manquant");
            else if (etudiant.Matricule.Length > 20) erreurs.Add("matricule trop long (20 caractères max)");
            if (etudiant.Nom == "") erreurs.Add("nom manquant");
            if (etudiant.Prenoms == "") erreurs.Add("prénoms manquants");

            if (!LireDate(feuille.Cell(r, 4), out DateTime naissance)) erreurs.Add("date de naissance invalide");
            else if (naissance.Date > DateTime.Today || naissance.Year < 1940) erreurs.Add("date de naissance incohérente");
            else etudiant.DateNaissance = naissance.Date;

            string sexe = NormaliserSexe(Texte(6));
            if (sexe == null) erreurs.Add("sexe invalide (M ou F)");
            else etudiant.Sexe = sexe;

            if (etudiant.Email == "") erreurs.Add("e-mail manquant");
            else if (!Courriel.IsMatch(etudiant.Email)) erreurs.Add("e-mail invalide");

            if (etudiant.Matricule != "")
            {
                if (existants.Matricules.Contains(etudiant.Matricule)) erreurs.Add("matricule déjà en base");
                else if (!matriculesVus.Add(etudiant.Matricule)) erreurs.Add("matricule en double dans le fichier");
            }
            if (etudiant.Email != "")
            {
                if (existants.Emails.Contains(etudiant.Email)) erreurs.Add("e-mail déjà en base");
                else if (!emailsVus.Add(etudiant.Email)) erreurs.Add("e-mail en double dans le fichier");
            }

            resultat.Add(new LigneImport { Numero = r, Etudiant = etudiant, Erreur = string.Join(" ; ", erreurs) });
        }
        return resultat;
    }

    private static bool LireDate(IXLCell cellule, out DateTime date)
    {
        date = default;
        if (cellule.DataType == XLDataType.DateTime)
        {
            date = cellule.GetDateTime();
            return true;
        }
        string texte = cellule.GetFormattedString().Trim();
        if (texte == "") return false;
        string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };
        return DateTime.TryParseExact(texte, formats, Fr, DateTimeStyles.None, out date)
            || DateTime.TryParse(texte, Fr, DateTimeStyles.None, out date);
    }

    private static string NormaliserSexe(string valeur)
    {
        switch (valeur.Trim().ToUpperInvariant())
        {
            case "M":
            case "H":
            case "HOMME":
            case "MASCULIN":
                return "M";
            case "F":
            case "FEMME":
            case "FÉMININ":
            case "FEMININ":
                return "F";
            default:
                return null;
        }
    }
}
