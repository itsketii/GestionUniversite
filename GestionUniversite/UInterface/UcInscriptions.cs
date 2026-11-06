using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcInscriptions : UserControl
{
    private readonly InscriptionDAO _dao = new InscriptionDAO();
    private DataView _vue;

    public UcInscriptions()
    {
        InitializeComponent();
    }

    private void UcInscriptions_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.GetListe().DefaultView;
            dgvInscriptions.DataSource = _vue;
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
        _vue.RowFilter = t == "" ? "" : $"etudiant LIKE '%{t}%' OR classe LIKE '%{t}%' OR matricule LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} inscription(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvInscriptions.CurrentRow?.DataBoundItem is DataRowView ligne)
            return (int)ligne["idInscription"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouvelle_Click(object sender, EventArgs e)
    {
        using var f = new FrmInscriptionDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void Executer(Action<int> action)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            action(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnValider_Click(object sender, EventArgs e) => Executer(id => _dao.Valider(id));

    private void btnAnnulerInscription_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Annuler cette inscription ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        Executer(id => _dao.Annuler(id));
    }
}
