using System.Drawing.Printing;
using System.Globalization;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcStatistiques : UserControl
{
    public UcStatistiques()
    {
        InitializeComponent();
    }

    private void UcStatistiques_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            var stats = new StatistiquesDAO();
            carteValidees.Valeur = stats.EtudiantsInscrits().ToString();
            carteTaux.Valeur = stats.TauxValidation() + " %";
            carteFrais.Valeur = stats.FraisEncaisses().ToString("N0", new CultureInfo("fr-FR")) + " FCFA";
            carteSeancesPlan.Valeur = stats.SeancesPlanifiees().ToString();

            grFiliere.Donnees = Outils.EnListe(stats.InscriptionsParFiliere());
            grNiveau.Donnees = Outils.EnListe(stats.InscriptionsParNiveau());
            grStatuts.Donnees = Outils.EnListe(stats.StatutsInscription());
            grClasses.Donnees = Outils.EnListe(stats.EffectifParClasse());
            grAbsences.Donnees = Outils.EnListe(stats.AbsencesParMatiere());
            grSexe.Donnees = Outils.EnListe(stats.RepartitionSexe());
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private PrintDocument NouveauDocument() =>
        Impression.DocumentControle(pnlRapport, "Statistiques", "Année académique " + ReferentielDAO.AnneeActive());

    private void btnActualiser_Click(object sender, EventArgs e) => Charger();

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauDocument(), "statistiques");
}
