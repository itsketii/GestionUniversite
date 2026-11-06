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

    private int? IdClasse()
    {
        if (dgvClasses.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idClasse"];
        return null;
    }

    private int? IdCours()
    {
        if (dgvCours.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idCours"];
        return null;
    }

    private void Afficher(Action action)
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

    private void Charger() => Afficher(() =>
    {
        dgvClasses.DataSource = _dao.ListerClasses();
        ChargerCours();
    });

    private void ChargerCours() => Afficher(() =>
    {
        int? id = IdClasse();
        dgvCours.DataSource = id == null ? null : _dao.ListerCours(id.Value);
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
        if (MessageBox.Show("Supprimer cette classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        Afficher(() =>
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
        if (MessageBox.Show("Retirer ce cours de la classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        Afficher(() =>
        {
            _dao.RetirerCours(id.Value);
            ChargerCours();
        });
    }
}
