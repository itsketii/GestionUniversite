using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmSeanceDetail : Form
{
    public FrmSeanceDetail() : this(DateTime.Today)
    {
    }

    public FrmSeanceDetail(DateTime dateInitiale)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        if (Outils.EstDesigner) return;

        dtpDate.Value = dateInitiale < DateTime.Today ? DateTime.Today : dateInitiale;
        dtpDebut.Value = DateTime.Today.AddHours(8);
        dtpFin.Value = DateTime.Today.AddHours(10);
        cboType.SelectedIndex = 0;
        Outils.Lier(cboClasse, ReferentielDAO.ClassesActives(), "libelle", "idClasse");
        Outils.Lier(cboSalle, ReferentielDAO.Salles(), "libelle", "idSalle");
        ChargerCours();
    }

    private void ChargerCours()
    {
        if (cboClasse.SelectedValue is int idClasse)
            Outils.Lier(cboCours, ReferentielDAO.CoursParClasse(idClasse), "libelle", "idCours");
    }

    private void cboClasse_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!Outils.EstDesigner) ChargerCours();
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (cboCours.SelectedValue == null || cboSalle.SelectedValue == null)
        {
            lblErreur.Text = "Choisissez un cours (ajoutez-en dans l'écran Classes si la liste est vide) et une salle.";
            return;
        }

        TimeSpan debut = dtpDebut.Value.TimeOfDay;
        TimeSpan fin = dtpFin.Value.TimeOfDay;
        if (fin <= debut)
        {
            lblErreur.Text = "L'heure de fin doit être après l'heure de début.";
            return;
        }

        try
        {
            new SeanceDAO().Planifier((int)cboCours.SelectedValue, (int)cboSalle.SelectedValue,
                dtpDate.Value, debut, fin, cboType.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex)
        {
            // Messages des règles de gestion : salle occupée, enseignant occupé, classe occupée, capacité
            lblErreur.Text = ex.Message;
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
