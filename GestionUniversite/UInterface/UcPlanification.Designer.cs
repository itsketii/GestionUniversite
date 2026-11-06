using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcPlanification
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitre = new Label();
        lblSousTitre = new Label();
        btnPrecedente = new BoutonArrondi();
        lblSemaine = new Label();
        btnSuivante = new BoutonArrondi();
        btnPlanifier = new BoutonArrondi();
        btnAnnulerSeance = new BoutonArrondi();
        cboClasse = new ComboBox();
        btnCetteSemaine = new BoutonArrondi();
        pnlGrille = new PanelArrondi();
        dgvSeances = new GrilleModerne();
        lblNombre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colJour = new DataGridViewTextBoxColumn();
        colHeure = new DataGridViewTextBoxColumn();
        colMatiere = new DataGridViewTextBoxColumn();
        colClasse = new DataGridViewTextBoxColumn();
        colEnseignant = new DataGridViewTextBoxColumn();
        colSalle = new DataGridViewTextBoxColumn();
        colType = new DataGridViewTextBoxColumn();
        colStatut = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvSeances).BeginInit();
        pnlGrille.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Location = new Point(32, 26);
        lblTitre.Size = new Size(500, 40);
        lblTitre.Text = "Planification";
        lblTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre.Name = "lblTitre";
        lblTitre.TabIndex = 0;
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(34, 66);
        lblSousTitre.Size = new Size(500, 24);
        lblSousTitre.Text = "Séances de la semaine";
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 1;
        //
        // btnPrecedente
        //
        btnPrecedente.BackColor = Color.FromArgb(58, 47, 50);
        btnPrecedente.ForeColor = Color.FromArgb(255, 255, 255);
        btnPrecedente.Location = new Point(32, 100);
        btnPrecedente.Size = new Size(100, 40);
        btnPrecedente.Text = "Précédente";
        btnPrecedente.UseVisualStyleBackColor = false;
        btnPrecedente.Name = "btnPrecedente";
        btnPrecedente.TabIndex = 2;
        //
        // lblSemaine
        //
        lblSemaine.AutoSize = false;
        lblSemaine.Location = new Point(140, 100);
        lblSemaine.Size = new Size(300, 40);
        lblSemaine.Text = "";
        lblSemaine.ForeColor = Color.FromArgb(27, 20, 22);
        lblSemaine.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblSemaine.TextAlign = ContentAlignment.MiddleCenter;
        lblSemaine.Name = "lblSemaine";
        lblSemaine.TabIndex = 3;
        //
        // btnSuivante
        //
        btnSuivante.BackColor = Color.FromArgb(58, 47, 50);
        btnSuivante.ForeColor = Color.FromArgb(255, 255, 255);
        btnSuivante.Location = new Point(448, 100);
        btnSuivante.Size = new Size(100, 40);
        btnSuivante.Text = "Suivante";
        btnSuivante.UseVisualStyleBackColor = false;
        btnSuivante.Name = "btnSuivante";
        btnSuivante.TabIndex = 4;
        //
        // btnPlanifier
        //
        btnPlanifier.BackColor = Color.FromArgb(155, 27, 48);
        btnPlanifier.ForeColor = Color.FromArgb(255, 255, 255);
        btnPlanifier.Location = new Point(668, 100);
        btnPlanifier.Size = new Size(200, 40);
        btnPlanifier.Text = "Planifier une séance";
        btnPlanifier.UseVisualStyleBackColor = false;
        btnPlanifier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnPlanifier.Name = "btnPlanifier";
        btnPlanifier.TabIndex = 5;
        //
        // btnAnnulerSeance
        //
        btnAnnulerSeance.BackColor = Color.FromArgb(179, 38, 30);
        btnAnnulerSeance.ForeColor = Color.FromArgb(255, 255, 255);
        btnAnnulerSeance.Location = new Point(880, 100);
        btnAnnulerSeance.Size = new Size(128, 40);
        btnAnnulerSeance.Text = "Annuler la séance";
        btnAnnulerSeance.UseVisualStyleBackColor = false;
        btnAnnulerSeance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAnnulerSeance.Name = "btnAnnulerSeance";
        btnAnnulerSeance.TabIndex = 6;
        //
        // cboClasse
        //
        cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
        cboClasse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboClasse.Location = new Point(32, 154);
        cboClasse.Size = new Size(300, 28);
        cboClasse.Name = "cboClasse";
        cboClasse.TabIndex = 7;
        //
        // btnCetteSemaine
        //
        btnCetteSemaine.BackColor = Color.FromArgb(58, 47, 50);
        btnCetteSemaine.ForeColor = Color.FromArgb(255, 255, 255);
        btnCetteSemaine.Location = new Point(344, 150);
        btnCetteSemaine.Size = new Size(150, 36);
        btnCetteSemaine.Text = "Cette semaine";
        btnCetteSemaine.UseVisualStyleBackColor = false;
        btnCetteSemaine.Name = "btnCetteSemaine";
        btnCetteSemaine.TabIndex = 8;
        //
        // pnlGrille
        //
        pnlGrille.BackColor = Color.FromArgb(255, 255, 255);
        pnlGrille.Location = new Point(32, 204);
        pnlGrille.Size = new Size(976, 496);
        pnlGrille.Rayon = 16;
        pnlGrille.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlGrille.Padding = new Padding(8);
        pnlGrille.Name = "pnlGrille";
        pnlGrille.TabIndex = 9;
        pnlGrille.Controls.Add(dgvSeances);
        //
        // dgvSeances
        //
        dgvSeances.AutoGenerateColumns = false;
        dgvSeances.Dock = DockStyle.Fill;
        dgvSeances.Columns.AddRange(new DataGridViewColumn[] { colId, colJour, colHeure, colMatiere, colClasse, colEnseignant, colSalle, colType, colStatut });
        dgvSeances.Name = "dgvSeances";
        dgvSeances.TabIndex = 10;
        //
        // colId
        //
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 100F;
        colId.DataPropertyName = "idSeance";
        colId.HeaderText = "Id";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        //
        // colJour
        //
        colJour.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colJour.Width = 110;
        colJour.DataPropertyName = "jour";
        colJour.HeaderText = "Jour";
        colJour.Name = "colJour";
        colJour.ReadOnly = true;
        //
        // colHeure
        //
        colHeure.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colHeure.Width = 120;
        colHeure.DataPropertyName = "heure";
        colHeure.HeaderText = "Heure";
        colHeure.Name = "colHeure";
        colHeure.ReadOnly = true;
        //
        // colMatiere
        //
        colMatiere.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colMatiere.FillWeight = 130F;
        colMatiere.DataPropertyName = "matiere";
        colMatiere.HeaderText = "Matière";
        colMatiere.Name = "colMatiere";
        colMatiere.ReadOnly = true;
        //
        // colClasse
        //
        colClasse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colClasse.FillWeight = 90F;
        colClasse.DataPropertyName = "classe";
        colClasse.HeaderText = "Classe";
        colClasse.Name = "colClasse";
        colClasse.ReadOnly = true;
        //
        // colEnseignant
        //
        colEnseignant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEnseignant.FillWeight = 100F;
        colEnseignant.DataPropertyName = "enseignant";
        colEnseignant.HeaderText = "Enseignant";
        colEnseignant.Name = "colEnseignant";
        colEnseignant.ReadOnly = true;
        //
        // colSalle
        //
        colSalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colSalle.Width = 80;
        colSalle.DataPropertyName = "salle";
        colSalle.HeaderText = "Salle";
        colSalle.Name = "colSalle";
        colSalle.ReadOnly = true;
        //
        // colType
        //
        colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colType.Width = 60;
        colType.DataPropertyName = "typeSeance";
        colType.HeaderText = "Type";
        colType.Name = "colType";
        colType.ReadOnly = true;
        //
        // colStatut
        //
        colStatut.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colStatut.Width = 100;
        colStatut.DataPropertyName = "statut";
        colStatut.HeaderText = "Statut";
        colStatut.Name = "colStatut";
        colStatut.ReadOnly = true;
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.Location = new Point(34, 710);
        lblNombre.Size = new Size(400, 24);
        lblNombre.Text = "";
        lblNombre.ForeColor = Color.FromArgb(107, 96, 99);
        lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblNombre.Name = "lblNombre";
        lblNombre.TabIndex = 11;
        //
        // UcPlanification
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcPlanification";
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(btnPrecedente);
        Controls.Add(lblSemaine);
        Controls.Add(btnSuivante);
        Controls.Add(btnPlanifier);
        Controls.Add(btnAnnulerSeance);
        Controls.Add(cboClasse);
        Controls.Add(btnCetteSemaine);
        Controls.Add(pnlGrille);
        Controls.Add(lblNombre);
        btnPrecedente.Click += btnPrecedente_Click;
        btnSuivante.Click += btnSuivante_Click;
        btnPlanifier.Click += btnPlanifier_Click;
        btnAnnulerSeance.Click += btnAnnulerSeance_Click;
        cboClasse.SelectedIndexChanged += cboClasse_SelectedIndexChanged;
        btnCetteSemaine.Click += btnCetteSemaine_Click;
        Load += UcPlanification_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSeances).EndInit();
        pnlGrille.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private BoutonArrondi btnPrecedente;
    private Label lblSemaine;
    private BoutonArrondi btnSuivante;
    private BoutonArrondi btnPlanifier;
    private BoutonArrondi btnAnnulerSeance;
    private ComboBox cboClasse;
    private BoutonArrondi btnCetteSemaine;
    private PanelArrondi pnlGrille;
    private GrilleModerne dgvSeances;
    private Label lblNombre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colJour;
    private DataGridViewTextBoxColumn colHeure;
    private DataGridViewTextBoxColumn colMatiere;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colEnseignant;
    private DataGridViewTextBoxColumn colSalle;
    private DataGridViewTextBoxColumn colType;
    private DataGridViewTextBoxColumn colStatut;
}
