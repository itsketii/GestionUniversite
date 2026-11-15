using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmImportEtudiants : Form
{
    private List<LigneImport> _lignes = new List<LigneImport>();

    public FrmImportEtudiants()
    {
        InitializeComponent();
        Theme.Appliquer(this);
        if (Outils.EstDesigner) return;
        try
        {
            var classes = ReferentielDAO.ClassesActives();
            var aucune = classes.NewRow();
            aucune["idClasse"] = 0;
            aucune["libelle"] = "Ne pas inscrire";
            classes.Rows.InsertAt(aucune, 0);
            Outils.Lier(cboClasse, classes, "libelle", "idClasse");
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
        MettreAJour();
    }

    private void btnModele_Click(object sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        {
            Filter = "Classeur Excel (*.xlsx)|*.xlsx",
            FileName = "modele_import_etudiants.xlsx"
        };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            ImportExcel.EnregistrerModele(dlg.FileName);
            Exports.Proposer(dlg.FileName, "Modèle enregistré.");
        }
        catch (Exception ex)
        {
            Outils.Erreur("Impossible d'enregistrer le modèle : " + ex.Message);
        }
    }

    private void btnParcourir_Click(object sender, EventArgs e)
    {
        using var dlg = new OpenFileDialog { Filter = "Classeur Excel (*.xlsx)|*.xlsx" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            _lignes = ImportExcel.Lire(dlg.FileName);
            lblFichier.Text = Path.GetFileName(dlg.FileName);
            MettreAJour();
        }
        catch (Exception ex)
        {
            _lignes = new List<LigneImport>();
            lblFichier.Text = "Aucun fichier sélectionné";
            MettreAJour();
            Outils.Erreur("Lecture impossible : " + ex.Message);
        }
    }

    private void MettreAJour()
    {
        var table = new System.Data.DataTable();
        table.Columns.Add("ligne", typeof(int));
        foreach (var nom in new[] { "matricule", "nom", "prenoms", "email", "resultat" }) table.Columns.Add(nom, typeof(string));
        foreach (var l in _lignes)
            table.Rows.Add(l.Numero, l.Etudiant.Matricule, l.Etudiant.Nom, l.Etudiant.Prenoms, l.Etudiant.Email, l.Valide ? "OK" : l.Erreur);
        dgvApercu.DataSource = table;

        int valides = _lignes.Count(l => l.Valide);
        int erreurs = _lignes.Count - valides;
        lblResume.Text = _lignes.Count == 0
            ? "Choisissez un fichier Excel pour vérifier les lignes."
            : $"{valides} ligne(s) valide(s), {erreurs} en erreur (ignorées à l'import)";
        btnImporter.Enabled = valides > 0;
    }

    private void dgvApercu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvApercu.Columns[e.ColumnIndex].Name != "colResultat") return;
        bool ok = Convert.ToString(e.Value) == "OK";
        e.CellStyle.ForeColor = ok ? Color.FromArgb(30, 107, 58) : Color.FromArgb(179, 38, 30);
    }

    private void btnImporter_Click(object sender, EventArgs e)
    {
        var valides = _lignes.Where(l => l.Valide).Select(l => l.Etudiant).ToList();
        if (valides.Count == 0) return;

        int? idClasse = null;
        if (cboClasse.SelectedValue is int valeur && valeur > 0) idClasse = valeur;

        string question = $"Importer {valides.Count} étudiant(s)" + (idClasse == null ? "" : " et les inscrire dans la classe « " + cboClasse.Text + " »") + " ?";
        if (!Outils.Confirmer(question)) return;

        try
        {
            int n = new EtudiantDAO().Importer(valides, idClasse, numFrais.Value, chkValider.Checked);
            Outils.Info($"{n} étudiant(s) importé(s).");
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            Outils.Erreur("Import annulé, rien n'a été enregistré : " + ex.Message);
        }
    }

    private void btnFermer_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
