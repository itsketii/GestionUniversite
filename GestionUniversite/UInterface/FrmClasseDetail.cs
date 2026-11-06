using System.Data;
using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmClasseDetail : Form
{
    public FrmClasseDetail()
    {
        InitializeComponent();
        if (Outils.EstDesigner) return;
        Outils.Lier(cboFiliere, ReferentielDAO.Filieres(), "libelle", "idFiliere");
        Outils.Lier(cboNiveau, ReferentielDAO.Niveaux(), "libelle", "idNiveau");
        var annees = ReferentielDAO.Annees();
        Outils.Lier(cboAnnee, annees, "libelle", "idAnnee");
        for (int i = 0; i < annees.Rows.Count; i++)
            if ((bool)annees.Rows[i]["estActive"]) cboAnnee.SelectedIndex = i;
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (cboFiliere.SelectedValue == null || cboNiveau.SelectedValue == null || cboAnnee.SelectedValue == null)
        {
            lblErreur.Text = "Choisissez la filière, le niveau et l'année.";
            return;
        }

        string libelle = txtLibelle.Text.Trim();
        if (libelle == "")
        {
            var f = (DataRowView)cboFiliere.SelectedItem;
            var n = (DataRowView)cboNiveau.SelectedItem;
            var a = (DataRowView)cboAnnee.SelectedItem;
            libelle = $"{n["codeNiveau"]} {f["codeFiliere"]} {a["libelle"]}";
        }

        try
        {
            new ClasseDAO().Creer(libelle, (int)cboFiliere.SelectedValue, (int)cboNiveau.SelectedValue, (int)cboAnnee.SelectedValue);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Cette classe existe déjà pour cette année.";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
