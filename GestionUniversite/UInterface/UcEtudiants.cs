using System.ComponentModel;
using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcEtudiants : UserControl
{
    private readonly EtudiantDAO _dao = new EtudiantDAO();
    private DataView _vue;

    public UcEtudiants()
    {
        InitializeComponent();
    }

    private void UcEtudiants_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.GetListe().DefaultView;
            dgvEtudiants.DataSource = _vue;
            Filtrer();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Filtrer()
    {
        if (_vue == null) return;
        string t = new string(txtRecherche.Text.Trim().Where(c => "[]*%".IndexOf(c) < 0).ToArray()).Replace("'", "''");
        _vue.RowFilter = t == "" ? "" : $"nom LIKE '%{t}%' OR prenoms LIKE '%{t}%' OR matricule LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} étudiant(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvEtudiants.CurrentRow?.DataBoundItem is DataRowView ligne)
            return (int)ligne["idEtudiant"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouveau_Click(object sender, EventArgs e)
    {
        using var f = new FrmEtudiantDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            using var f = new FrmEtudiantDetail(_dao.GetById(id.Value));
            if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvEtudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnModifier_Click(sender, e);
    }

    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        if (MessageBox.Show("Supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            _dao.Delete(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Suppression impossible (l'étudiant a peut-être des inscriptions ou des absences).\n\n" + ex.Message,
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
