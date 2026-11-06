using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcEtudiants
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
        txtRecherche = new TextBox();
        btnNouveau = new BoutonArrondi();
        btnModifier = new BoutonArrondi();
        btnSupprimer = new BoutonArrondi();
        pnlGrille = new PanelArrondi();
        dgvEtudiants = new GrilleModerne();
        lblNombre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colNom = new DataGridViewTextBoxColumn();
        colPrenoms = new DataGridViewTextBoxColumn();
        colClasse = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        colStatut = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEtudiants).BeginInit();
        pnlGrille.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Location = new Point(32, 26);
        lblTitre.Size = new Size(500, 40);
        lblTitre.Text = "Étudiants";
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
        lblSousTitre.Text = "Étudiants de l’année académique en cours";
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 1;
        //
        // txtRecherche
        //
        txtRecherche.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtRecherche.Location = new Point(32, 106);
        txtRecherche.Size = new Size(340, 27);
        txtRecherche.PlaceholderText = "Rechercher par nom, prénoms ou matricule";
        txtRecherche.Name = "txtRecherche";
        txtRecherche.TabIndex = 2;
        //
        // btnNouveau
        //
        btnNouveau.BackColor = Color.FromArgb(155, 27, 48);
        btnNouveau.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouveau.Location = new Point(594, 100);
        btnNouveau.Size = new Size(150, 40);
        btnNouveau.Text = "Nouvel étudiant";
        btnNouveau.UseVisualStyleBackColor = false;
        btnNouveau.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNouveau.Name = "btnNouveau";
        btnNouveau.TabIndex = 3;
        //
        // btnModifier
        //
        btnModifier.BackColor = Color.FromArgb(58, 47, 50);
        btnModifier.ForeColor = Color.FromArgb(255, 255, 255);
        btnModifier.Location = new Point(756, 100);
        btnModifier.Size = new Size(120, 40);
        btnModifier.Text = "Modifier";
        btnModifier.UseVisualStyleBackColor = false;
        btnModifier.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnModifier.Name = "btnModifier";
        btnModifier.TabIndex = 4;
        //
        // btnSupprimer
        //
        btnSupprimer.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimer.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimer.Location = new Point(888, 100);
        btnSupprimer.Size = new Size(120, 40);
        btnSupprimer.Text = "Supprimer";
        btnSupprimer.UseVisualStyleBackColor = false;
        btnSupprimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSupprimer.Name = "btnSupprimer";
        btnSupprimer.TabIndex = 5;
        //
        // pnlGrille
        //
        pnlGrille.BackColor = Color.FromArgb(255, 255, 255);
        pnlGrille.Location = new Point(32, 160);
        pnlGrille.Size = new Size(976, 540);
        pnlGrille.Rayon = 16;
        pnlGrille.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlGrille.Padding = new Padding(8);
        pnlGrille.Name = "pnlGrille";
        pnlGrille.TabIndex = 6;
        pnlGrille.Controls.Add(dgvEtudiants);
        //
        // dgvEtudiants
        //
        dgvEtudiants.AutoGenerateColumns = false;
        dgvEtudiants.Dock = DockStyle.Fill;
        dgvEtudiants.Columns.AddRange(new DataGridViewColumn[] { colId, colMatricule, colNom, colPrenoms, colClasse, colEmail, colStatut });
        dgvEtudiants.Name = "dgvEtudiants";
        dgvEtudiants.TabIndex = 7;
        //
        // colId
        //
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 100F;
        colId.DataPropertyName = "idEtudiant";
        colId.HeaderText = "Id";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        //
        // colMatricule
        //
        colMatricule.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colMatricule.Width = 130;
        colMatricule.DataPropertyName = "matricule";
        colMatricule.HeaderText = "Matricule";
        colMatricule.Name = "colMatricule";
        colMatricule.ReadOnly = true;
        //
        // colNom
        //
        colNom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colNom.FillWeight = 100F;
        colNom.DataPropertyName = "nom";
        colNom.HeaderText = "Nom";
        colNom.Name = "colNom";
        colNom.ReadOnly = true;
        //
        // colPrenoms
        //
        colPrenoms.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPrenoms.FillWeight = 100F;
        colPrenoms.DataPropertyName = "prenoms";
        colPrenoms.HeaderText = "Prénoms";
        colPrenoms.Name = "colPrenoms";
        colPrenoms.ReadOnly = true;
        //
        // colClasse
        //
        colClasse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colClasse.FillWeight = 110F;
        colClasse.DataPropertyName = "classe";
        colClasse.HeaderText = "Classe";
        colClasse.Name = "colClasse";
        colClasse.ReadOnly = true;
        //
        // colEmail
        //
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEmail.FillWeight = 150F;
        colEmail.DataPropertyName = "email";
        colEmail.HeaderText = "E-mail";
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        //
        // colStatut
        //
        colStatut.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colStatut.Width = 120;
        colStatut.DataPropertyName = "statutInscription";
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
        lblNombre.TabIndex = 8;
        //
        // UcEtudiants
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcEtudiants";
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(txtRecherche);
        Controls.Add(btnNouveau);
        Controls.Add(btnModifier);
        Controls.Add(btnSupprimer);
        Controls.Add(pnlGrille);
        Controls.Add(lblNombre);
        txtRecherche.TextChanged += txtRecherche_TextChanged;
        btnNouveau.Click += btnNouveau_Click;
        btnModifier.Click += btnModifier_Click;
        btnSupprimer.Click += btnSupprimer_Click;
        dgvEtudiants.CellDoubleClick += dgvEtudiants_CellDoubleClick;
        Load += UcEtudiants_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEtudiants).EndInit();
        pnlGrille.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private TextBox txtRecherche;
    private BoutonArrondi btnNouveau;
    private BoutonArrondi btnModifier;
    private BoutonArrondi btnSupprimer;
    private PanelArrondi pnlGrille;
    private GrilleModerne dgvEtudiants;
    private Label lblNombre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colNom;
    private DataGridViewTextBoxColumn colPrenoms;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colEmail;
    private DataGridViewTextBoxColumn colStatut;
}
