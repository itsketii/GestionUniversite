using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcClasses : UserControl
{
    private readonly ClasseDAO _dao = new ClasseDAO();

    public UcClasses()
    {
        InitializeComponent();
    }

    private void UcClasses_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private DataRowView ClasseCourante() => dgvClasses.CurrentRow?.DataBoundItem as DataRowView;

    private int? IdClasse()
    {
        var ligne = ClasseCourante();
        return ligne == null ? (int?)null : (int)ligne["idClasse"];
    }

    private int? IdCours()
    {
        if (dgvCours.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idCours"];
        return null;
    }

    private void Securise(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void Charger() => Securise(() =>
    {
        dgvClasses.DataSource = _dao.ListerClasses();
        ChargerCours();
    });

    private void ChargerCours() => Securise(() =>
    {
        int? id = IdClasse();
        dgvCours.DataSource = id == null ? null : _dao.ListerCours(id.Value);
        var ligne = ClasseCourante();
        lblCoursTitre.Text = ligne == null ? "Cours de la classe" : "Cours de " + ligne["libelle"];
        btnAjouterCours.Enabled = id != null;
        btnRetirerCours.Enabled = id != null;
    });

    private void dgvClasses_SelectionChanged(object sender, EventArgs e) => ChargerCours();

    private void btnNouvelleClasse_Click(object sender, EventArgs e)
    {
        using var f = new FrmClasseDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnSupprimerClasse_Click(object sender, EventArgs e)
    {
        int? id = IdClasse();
        if (id == null) return;
        if (!Outils.Confirmer("Supprimer cette classe ?")) return;
        Securise(() =>
        {
            _dao.Supprimer(id.Value);
            Charger();
        });
    }

    private void btnAjouterCours_Click(object sender, EventArgs e)
    {
        int? id = IdClasse();
        if (id == null) return;
        using var f = new FrmCoursDetail(id.Value);
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnRetirerCours_Click(object sender, EventArgs e)
    {
        int? id = IdCours();
        if (id == null) return;
        if (!Outils.Confirmer("Retirer ce cours de la classe ?")) return;
        Securise(() =>
        {
            _dao.RetirerCours(id.Value);
            ChargerCours();
        });
    }

    private Rapport RapportClasse()
    {
        var ligne = ClasseCourante();
        if (ligne == null) return null;
        var table = _dao.ListeEtudiants((int)ligne["idClasse"]);
        var r = new Rapport
        {
            Titre = "Liste de classe : " + ligne["libelle"],
            SousTitre = table.Rows.Count + " étudiant(s) inscrit(s) · année " + ligne["annee"],
            Paysage = false
        };
        r.Entetes.AddRange(new[] { "N°", "Matricule", "Nom", "Prénoms", "E-mail" });
        r.Poids.AddRange(new float[] { 36, 100, 130, 150, 220 });
        int i = 1;
        foreach (DataRow row in table.Rows)
            r.Lignes.Add(new[] { (i++).ToString(), (string)row["matricule"], (string)row["nom"], (string)row["prenoms"], (string)row["email"] });
        return r;
    }

    private void btnListeImprimer_Click(object sender, EventArgs e)
    {
        var r = RapportClasse();
        if (r != null) Securise(() => Impression.Apercu(FindForm(), r.CreerDocument()));
    }

    private void btnListePdf_Click(object sender, EventArgs e)
    {
        var r = RapportClasse();
        if (r != null) Securise(() => Impression.Pdf(FindForm(), r.CreerDocument(), "liste_classe"));
    }

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvClasses, FindForm(), "classes");
}
