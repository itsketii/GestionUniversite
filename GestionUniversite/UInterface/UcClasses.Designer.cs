using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcClasses
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
        btnNouvelleClasse = new BoutonArrondi();
        btnSupprimerClasse = new BoutonArrondi();
        pnlClasses = new PanelArrondi();
        lblClassesTitre = new Label();
        dgvClasses = new GrilleModerne();
        pnlCours = new PanelArrondi();
        lblCoursTitre = new Label();
        dgvCours = new GrilleModerne();
        btnAjouterCours = new BoutonArrondi();
        btnRetirerCours = new BoutonArrondi();
        colIdClasse = new DataGridViewTextBoxColumn();
        colLibelle = new DataGridViewTextBoxColumn();
        colFiliere = new DataGridViewTextBoxColumn();
        colNiveau = new DataGridViewTextBoxColumn();
        colAnnee = new DataGridViewTextBoxColumn();
        colEffectif = new DataGridViewTextBoxColumn();
        colIdCours = new DataGridViewTextBoxColumn();
        colMatiere = new DataGridViewTextBoxColumn();
        colEnseignant = new DataGridViewTextBoxColumn();
        colHeures = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvCours).BeginInit();
        pnlClasses.SuspendLayout();
        pnlCours.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Location = new Point(32, 26);
        lblTitre.Size = new Size(500, 40);
        lblTitre.Text = "Classes";
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
        lblSousTitre.Text = "Classes de l’université et cours de chaque classe";
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 1;
        //
        // btnNouvelleClasse
        //
        btnNouvelleClasse.BackColor = Color.FromArgb(155, 27, 48);
        btnNouvelleClasse.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouvelleClasse.Location = new Point(736, 100);
        btnNouvelleClasse.Size = new Size(140, 40);
        btnNouvelleClasse.Text = "Nouvelle classe";
        btnNouvelleClasse.UseVisualStyleBackColor = false;
        btnNouvelleClasse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNouvelleClasse.Name = "btnNouvelleClasse";
        btnNouvelleClasse.TabIndex = 2;
        //
        // btnSupprimerClasse
        //
        btnSupprimerClasse.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimerClasse.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimerClasse.Location = new Point(888, 100);
        btnSupprimerClasse.Size = new Size(120, 40);
        btnSupprimerClasse.Text = "Supprimer";
        btnSupprimerClasse.UseVisualStyleBackColor = false;
        btnSupprimerClasse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSupprimerClasse.Name = "btnSupprimerClasse";
        btnSupprimerClasse.TabIndex = 3;
        //
        // pnlClasses
        //
        pnlClasses.BackColor = Color.FromArgb(255, 255, 255);
        pnlClasses.Location = new Point(32, 160);
        pnlClasses.Size = new Size(560, 540);
        pnlClasses.Rayon = 16;
        pnlClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlClasses.Name = "pnlClasses";
        pnlClasses.TabIndex = 4;
        pnlClasses.Controls.Add(lblClassesTitre);
        pnlClasses.Controls.Add(dgvClasses);
        //
        // lblClassesTitre
        //
        lblClassesTitre.AutoSize = false;
        lblClassesTitre.Location = new Point(20, 14);
        lblClassesTitre.Size = new Size(300, 26);
        lblClassesTitre.Text = "Classes";
        lblClassesTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblClassesTitre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblClassesTitre.Name = "lblClassesTitre";
        lblClassesTitre.TabIndex = 5;
        //
        // dgvClasses
        //
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvClasses.Location = new Point(8, 48);
        dgvClasses.Size = new Size(544, 484);
        dgvClasses.Columns.AddRange(new DataGridViewColumn[] { colIdClasse, colLibelle, colFiliere, colNiveau, colAnnee, colEffectif });
        dgvClasses.Name = "dgvClasses";
        dgvClasses.TabIndex = 6;
        //
        // colIdClasse
        //
        colIdClasse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colIdClasse.FillWeight = 100F;
        colIdClasse.DataPropertyName = "idClasse";
        colIdClasse.HeaderText = "Id";
        colIdClasse.Name = "colIdClasse";
        colIdClasse.ReadOnly = true;
        colIdClasse.Visible = false;
        //
        // colLibelle
        //
        colLibelle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colLibelle.FillWeight = 150F;
        colLibelle.DataPropertyName = "libelle";
        colLibelle.HeaderText = "Classe";
        colLibelle.Name = "colLibelle";
        colLibelle.ReadOnly = true;
        //
        // colFiliere
        //
        colFiliere.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colFiliere.Width = 80;
        colFiliere.DataPropertyName = "filiere";
        colFiliere.HeaderText = "Filière";
        colFiliere.Name = "colFiliere";
        colFiliere.ReadOnly = true;
        //
        // colNiveau
        //
        colNiveau.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colNiveau.Width = 70;
        colNiveau.DataPropertyName = "niveau";
        colNiveau.HeaderText = "Niveau";
        colNiveau.Name = "colNiveau";
        colNiveau.ReadOnly = true;
        //
        // colAnnee
        //
        colAnnee.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colAnnee.Width = 100;
        colAnnee.DataPropertyName = "annee";
        colAnnee.HeaderText = "Année";
        colAnnee.Name = "colAnnee";
        colAnnee.ReadOnly = true;
        //
        // colEffectif
        //
        colEffectif.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colEffectif.Width = 80;
        colEffectif.DataPropertyName = "effectif";
        colEffectif.HeaderText = "Effectif";
        colEffectif.Name = "colEffectif";
        colEffectif.ReadOnly = true;
        //
        // pnlCours
        //
        pnlCours.BackColor = Color.FromArgb(255, 255, 255);
        pnlCours.Location = new Point(608, 160);
        pnlCours.Size = new Size(400, 540);
        pnlCours.Rayon = 16;
        pnlCours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        pnlCours.Name = "pnlCours";
        pnlCours.TabIndex = 7;
        pnlCours.Controls.Add(lblCoursTitre);
        pnlCours.Controls.Add(dgvCours);
        pnlCours.Controls.Add(btnAjouterCours);
        pnlCours.Controls.Add(btnRetirerCours);
        //
        // lblCoursTitre
        //
        lblCoursTitre.AutoSize = false;
        lblCoursTitre.Location = new Point(20, 14);
        lblCoursTitre.Size = new Size(360, 26);
        lblCoursTitre.Text = "Cours de la classe";
        lblCoursTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblCoursTitre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblCoursTitre.Name = "lblCoursTitre";
        lblCoursTitre.TabIndex = 8;
        //
        // dgvCours
        //
        dgvCours.AutoGenerateColumns = false;
        dgvCours.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCours.Location = new Point(8, 48);
        dgvCours.Size = new Size(384, 424);
        dgvCours.Columns.AddRange(new DataGridViewColumn[] { colIdCours, colMatiere, colEnseignant, colHeures });
        dgvCours.Name = "dgvCours";
        dgvCours.TabIndex = 9;
        //
        // colIdCours
        //
        colIdCours.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colIdCours.FillWeight = 100F;
        colIdCours.DataPropertyName = "idCours";
        colIdCours.HeaderText = "Id";
        colIdCours.Name = "colIdCours";
        colIdCours.ReadOnly = true;
        colIdCours.Visible = false;
        //
        // colMatiere
        //
        colMatiere.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colMatiere.FillWeight = 120F;
        colMatiere.DataPropertyName = "matiere";
        colMatiere.HeaderText = "Matière";
        colMatiere.Name = "colMatiere";
        colMatiere.ReadOnly = true;
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
        // colHeures
        //
        colHeures.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colHeures.Width = 70;
        colHeures.DataPropertyName = "volumeHoraire";
        colHeures.HeaderText = "Heures";
        colHeures.Name = "colHeures";
        colHeures.ReadOnly = true;
        //
        // btnAjouterCours
        //
        btnAjouterCours.BackColor = Color.FromArgb(155, 27, 48);
        btnAjouterCours.ForeColor = Color.FromArgb(255, 255, 255);
        btnAjouterCours.Location = new Point(20, 484);
        btnAjouterCours.Size = new Size(180, 40);
        btnAjouterCours.Text = "Ajouter un cours";
        btnAjouterCours.UseVisualStyleBackColor = false;
        btnAjouterCours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAjouterCours.Name = "btnAjouterCours";
        btnAjouterCours.TabIndex = 10;
        //
        // btnRetirerCours
        //
        btnRetirerCours.BackColor = Color.FromArgb(179, 38, 30);
        btnRetirerCours.ForeColor = Color.FromArgb(255, 255, 255);
        btnRetirerCours.Location = new Point(212, 484);
        btnRetirerCours.Size = new Size(168, 40);
        btnRetirerCours.Text = "Retirer";
        btnRetirerCours.UseVisualStyleBackColor = false;
        btnRetirerCours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnRetirerCours.Name = "btnRetirerCours";
        btnRetirerCours.TabIndex = 11;
        //
        // UcClasses
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcClasses";
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(btnNouvelleClasse);
        Controls.Add(btnSupprimerClasse);
        Controls.Add(pnlClasses);
        Controls.Add(pnlCours);
        btnNouvelleClasse.Click += btnNouvelleClasse_Click;
        btnSupprimerClasse.Click += btnSupprimerClasse_Click;
        dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;
        btnAjouterCours.Click += btnAjouterCours_Click;
        btnRetirerCours.Click += btnRetirerCours_Click;
        Load += UcClasses_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvCours).EndInit();
        pnlClasses.ResumeLayout(false);
        pnlCours.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private BoutonArrondi btnNouvelleClasse;
    private BoutonArrondi btnSupprimerClasse;
    private PanelArrondi pnlClasses;
    private Label lblClassesTitre;
    private GrilleModerne dgvClasses;
    private PanelArrondi pnlCours;
    private Label lblCoursTitre;
    private GrilleModerne dgvCours;
    private BoutonArrondi btnAjouterCours;
    private BoutonArrondi btnRetirerCours;
    private DataGridViewTextBoxColumn colIdClasse;
    private DataGridViewTextBoxColumn colLibelle;
    private DataGridViewTextBoxColumn colFiliere;
    private DataGridViewTextBoxColumn colNiveau;
    private DataGridViewTextBoxColumn colAnnee;
    private DataGridViewTextBoxColumn colEffectif;
    private DataGridViewTextBoxColumn colIdCours;
    private DataGridViewTextBoxColumn colMatiere;
    private DataGridViewTextBoxColumn colEnseignant;
    private DataGridViewTextBoxColumn colHeures;
}
