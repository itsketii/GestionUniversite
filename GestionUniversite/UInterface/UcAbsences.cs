using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcAbsences : UserControl
{
    private readonly AbsenceDAO _dao = new AbsenceDAO();
    private DataTable _appel;

    public UcAbsences()
    {
        InitializeComponent();
    }

    private void UcAbsences_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        try
        {
            Outils.Lier(cboSeance, _dao.Seances(), "libelle", "idSeance", false);
            btnEnregistrerAppel.Enabled = false;
            lblResume.Text = "Choisissez une séance pour faire l'appel.";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cboSeance_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Outils.EstDesigner || cboSeance.SelectedValue is not int idSeance) return;
        try
        {
            _appel = _dao.Appel(idSeance);
            dgvAppel.DataSource = _appel;
            btnEnregistrerAppel.Enabled = _appel.Rows.Count > 0;
            MettreAJourResume();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void MettreAJourResume()
    {
        if (_appel == null) return;
        int absents = _appel.Rows.Cast<DataRow>().Count(r => (bool)r["absent"]);
        lblResume.Text = $"{absents} absent(s) sur {_appel.Rows.Count} étudiant(s)";
    }

    private void dgvAppel_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
        if (dgvAppel.IsCurrentCellDirty) dgvAppel.CommitEdit(DataGridViewDataErrorContexts.Commit);
    }

    private void dgvAppel_CellValueChanged(object sender, DataGridViewCellEventArgs e) => MettreAJourResume();

    private void btnEnregistrerAppel_Click(object sender, EventArgs e)
    {
        if (_appel == null || cboSeance.SelectedValue is not int idSeance) return;
        try
        {
            dgvAppel.EndEdit();
            _dao.EnregistrerAppel(idSeance, _appel);
            MessageBox.Show("Appel enregistré.", "Absences", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
