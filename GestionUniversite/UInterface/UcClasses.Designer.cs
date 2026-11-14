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
        tlpCorps = new TableLayoutPanel();
        cardClasses = new PanelArrondi();
        dgvClasses = new GrilleModerne();
        lblTitreClasses = new Label();
        cardCours = new PanelArrondi();
        dgvCours = new GrilleModerne();
        pnlBoutonsCours = new Panel();
        tlpBoutonsCours = new TableLayoutPanel();
        btnAjouterCours = new BoutonArrondi();
        btnRetirerCours = new BoutonArrondi();
        lblCoursTitre = new Label();
        pnlOutils = new Panel();
        flpBoutons = new FlowLayoutPanel();
        btnExporter = new BoutonArrondi();
        btnListePdf = new BoutonArrondi();
        btnListeImprimer = new BoutonArrondi();
        btnNouvelleClasse = new BoutonArrondi();
        btnSupprimerClasse = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
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
        tlpCorps.SuspendLayout();
        cardClasses.SuspendLayout();
        cardCours.SuspendLayout();
        pnlBoutonsCours.SuspendLayout();
        tlpBoutonsCours.SuspendLayout();
        pnlOutils.SuspendLayout();
        flpBoutons.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // tlpCorps
        //
        tlpCorps.ColumnCount = 2;
        tlpCorps.RowCount = 1;
        tlpCorps.Dock = DockStyle.Fill;
        tlpCorps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        tlpCorps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        tlpCorps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpCorps.Name = "tlpCorps";
        tlpCorps.TabIndex = 0;
        tlpCorps.Controls.Add(cardClasses, 0, 0);
        tlpCorps.Controls.Add(cardCours, 1, 0);
        //
        // cardClasses
        //
        cardClasses.BackColor = Color.FromArgb(255, 255, 255);
        cardClasses.Rayon = 16;
        cardClasses.Dock = DockStyle.Fill;
        cardClasses.Tag = "carte";
        cardClasses.Padding = new Padding(8, 8, 8, 8);
        cardClasses.Margin = new Padding(0, 0, 8, 0);
        cardClasses.Name = "cardClasses";
        cardClasses.TabIndex = 1;
        cardClasses.Controls.Add(dgvClasses);
        cardClasses.Controls.Add(lblTitreClasses);
        //
        // dgvClasses
        //
        dgvClasses.AutoGenerateColumns = false;
        dgvClasses.Dock = DockStyle.Fill;
        dgvClasses.Columns.AddRange(new DataGridViewColumn[] { colIdClasse, colLibelle, colFiliere, colNiveau, colAnnee, colEffectif });
        dgvClasses.Name = "dgvClasses";
        dgvClasses.TabIndex = 2;
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
        // lblTitreClasses
        //
        lblTitreClasses.AutoSize = false;
        lblTitreClasses.Dock = DockStyle.Top;
        lblTitreClasses.Text = "Classes";
        lblTitreClasses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreClasses.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreClasses.Tag = "texte";
        lblTitreClasses.Name = "lblTitreClasses";
        lblTitreClasses.TabIndex = 3;
        //
        // cardCours
        //
        cardCours.BackColor = Color.FromArgb(255, 255, 255);
        cardCours.Rayon = 16;
        cardCours.Dock = DockStyle.Fill;
        cardCours.Tag = "carte";
        cardCours.Padding = new Padding(8, 8, 8, 8);
        cardCours.Margin = new Padding(8, 0, 0, 0);
        cardCours.Name = "cardCours";
        cardCours.TabIndex = 4;
        cardCours.Controls.Add(dgvCours);
        cardCours.Controls.Add(pnlBoutonsCours);
        cardCours.Controls.Add(lblCoursTitre);
        //
        // dgvCours
        //
        dgvCours.AutoGenerateColumns = false;
        dgvCours.Dock = DockStyle.Fill;
        dgvCours.Columns.AddRange(new DataGridViewColumn[] { colIdCours, colMatiere, colEnseignant, colHeures });
        dgvCours.Name = "dgvCours";
        dgvCours.TabIndex = 5;
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
        // pnlBoutonsCours
        //
        pnlBoutonsCours.Dock = DockStyle.Bottom;
        pnlBoutonsCours.Size = new Size(100, 58);
        pnlBoutonsCours.Name = "pnlBoutonsCours";
        pnlBoutonsCours.TabIndex = 6;
        pnlBoutonsCours.Controls.Add(tlpBoutonsCours);
        //
        // tlpBoutonsCours
        //
        tlpBoutonsCours.ColumnCount = 2;
        tlpBoutonsCours.RowCount = 1;
        tlpBoutonsCours.Dock = DockStyle.Fill;
        tlpBoutonsCours.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tlpBoutonsCours.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tlpBoutonsCours.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBoutonsCours.Name = "tlpBoutonsCours";
        tlpBoutonsCours.TabIndex = 7;
        tlpBoutonsCours.Controls.Add(btnAjouterCours, 0, 0);
        tlpBoutonsCours.Controls.Add(btnRetirerCours, 1, 0);
        //
        // btnAjouterCours
        //
        btnAjouterCours.BackColor = Color.FromArgb(155, 27, 48);
        btnAjouterCours.ForeColor = Color.FromArgb(255, 255, 255);
        btnAjouterCours.Text = "Ajouter un cours";
        btnAjouterCours.UseVisualStyleBackColor = false;
        btnAjouterCours.Dock = DockStyle.Fill;
        btnAjouterCours.Margin = new Padding(4, 8, 4, 6);
        btnAjouterCours.Name = "btnAjouterCours";
        btnAjouterCours.TabIndex = 8;
        //
        // btnRetirerCours
        //
        btnRetirerCours.BackColor = Color.FromArgb(179, 38, 30);
        btnRetirerCours.ForeColor = Color.FromArgb(255, 255, 255);
        btnRetirerCours.Text = "Retirer";
        btnRetirerCours.UseVisualStyleBackColor = false;
        btnRetirerCours.Dock = DockStyle.Fill;
        btnRetirerCours.Margin = new Padding(4, 8, 4, 6);
        btnRetirerCours.Name = "btnRetirerCours";
        btnRetirerCours.TabIndex = 9;
        //
        // lblCoursTitre
        //
        lblCoursTitre.AutoSize = false;
        lblCoursTitre.Dock = DockStyle.Top;
        lblCoursTitre.Text = "Cours de la classe";
        lblCoursTitre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblCoursTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblCoursTitre.Tag = "texte";
        lblCoursTitre.Name = "lblCoursTitre";
        lblCoursTitre.TabIndex = 10;
        //
        // pnlOutils
        //
        pnlOutils.Dock = DockStyle.Top;
        pnlOutils.Size = new Size(100, 56);
        pnlOutils.Name = "pnlOutils";
        pnlOutils.TabIndex = 11;
        pnlOutils.Controls.Add(flpBoutons);
        //
        // flpBoutons
        //
        flpBoutons.AutoSize = true;
        flpBoutons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpBoutons.Dock = DockStyle.Right;
        flpBoutons.FlowDirection = FlowDirection.LeftToRight;
        flpBoutons.WrapContents = false;
        flpBoutons.Size = new Size(100, 56);
        flpBoutons.Name = "flpBoutons";
        flpBoutons.TabIndex = 12;
        flpBoutons.Controls.Add(btnExporter);
        flpBoutons.Controls.Add(btnListePdf);
        flpBoutons.Controls.Add(btnListeImprimer);
        flpBoutons.Controls.Add(btnNouvelleClasse);
        flpBoutons.Controls.Add(btnSupprimerClasse);
        //
        // btnExporter
        //
        btnExporter.BackColor = Color.FromArgb(239, 232, 234);
        btnExporter.ForeColor = Color.FromArgb(27, 20, 22);
        btnExporter.Text = "Exporter";
        btnExporter.UseVisualStyleBackColor = false;
        btnExporter.Location = new Point(0, 0);
        btnExporter.Size = new Size(92, 40);
        btnExporter.Tag = "secondaire";
        btnExporter.Margin = new Padding(8, 8, 0, 8);
        btnExporter.Name = "btnExporter";
        btnExporter.TabIndex = 13;
        //
        // btnListePdf
        //
        btnListePdf.BackColor = Color.FromArgb(239, 232, 234);
        btnListePdf.ForeColor = Color.FromArgb(27, 20, 22);
        btnListePdf.Text = "Liste en PDF";
        btnListePdf.UseVisualStyleBackColor = false;
        btnListePdf.Location = new Point(0, 0);
        btnListePdf.Size = new Size(112, 40);
        btnListePdf.Tag = "secondaire";
        btnListePdf.Margin = new Padding(8, 8, 0, 8);
        btnListePdf.Name = "btnListePdf";
        btnListePdf.TabIndex = 14;
        //
        // btnListeImprimer
        //
        btnListeImprimer.BackColor = Color.FromArgb(239, 232, 234);
        btnListeImprimer.ForeColor = Color.FromArgb(27, 20, 22);
        btnListeImprimer.Text = "Imprimer la liste";
        btnListeImprimer.UseVisualStyleBackColor = false;
        btnListeImprimer.Location = new Point(0, 0);
        btnListeImprimer.Size = new Size(140, 40);
        btnListeImprimer.Tag = "secondaire";
        btnListeImprimer.Margin = new Padding(8, 8, 0, 8);
        btnListeImprimer.Name = "btnListeImprimer";
        btnListeImprimer.TabIndex = 15;
        //
        // btnNouvelleClasse
        //
        btnNouvelleClasse.BackColor = Color.FromArgb(155, 27, 48);
        btnNouvelleClasse.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouvelleClasse.Text = "Nouvelle classe";
        btnNouvelleClasse.UseVisualStyleBackColor = false;
        btnNouvelleClasse.Location = new Point(0, 0);
        btnNouvelleClasse.Size = new Size(140, 40);
        btnNouvelleClasse.Margin = new Padding(8, 8, 0, 8);
        btnNouvelleClasse.Name = "btnNouvelleClasse";
        btnNouvelleClasse.TabIndex = 16;
        //
        // btnSupprimerClasse
        //
        btnSupprimerClasse.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimerClasse.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimerClasse.Text = "Supprimer";
        btnSupprimerClasse.UseVisualStyleBackColor = false;
        btnSupprimerClasse.Location = new Point(0, 0);
        btnSupprimerClasse.Size = new Size(108, 40);
        btnSupprimerClasse.Margin = new Padding(8, 8, 0, 8);
        btnSupprimerClasse.Name = "btnSupprimerClasse";
        btnSupprimerClasse.TabIndex = 17;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 18;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Classes de l’année et matières enseignées dans chaque classe";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 19;
        //
        // UcClasses
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcClasses";
        Controls.Add(tlpCorps);
        Controls.Add(pnlOutils);
        Controls.Add(pnlEntete);
        dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;
        btnAjouterCours.Click += btnAjouterCours_Click;
        btnRetirerCours.Click += btnRetirerCours_Click;
        btnExporter.Click += btnExporter_Click;
        btnListePdf.Click += btnListePdf_Click;
        btnListeImprimer.Click += btnListeImprimer_Click;
        btnNouvelleClasse.Click += btnNouvelleClasse_Click;
        btnSupprimerClasse.Click += btnSupprimerClasse_Click;
        Load += UcClasses_Load;
        ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvCours).EndInit();
        tlpCorps.ResumeLayout(false);
        cardClasses.ResumeLayout(false);
        cardCours.ResumeLayout(false);
        pnlBoutonsCours.ResumeLayout(false);
        tlpBoutonsCours.ResumeLayout(false);
        pnlOutils.ResumeLayout(false);
        flpBoutons.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private TableLayoutPanel tlpCorps;
    private PanelArrondi cardClasses;
    private GrilleModerne dgvClasses;
    private Label lblTitreClasses;
    private PanelArrondi cardCours;
    private GrilleModerne dgvCours;
    private Panel pnlBoutonsCours;
    private TableLayoutPanel tlpBoutonsCours;
    private BoutonArrondi btnAjouterCours;
    private BoutonArrondi btnRetirerCours;
    private Label lblCoursTitre;
    private Panel pnlOutils;
    private FlowLayoutPanel flpBoutons;
    private BoutonArrondi btnExporter;
    private BoutonArrondi btnListePdf;
    private BoutonArrondi btnListeImprimer;
    private BoutonArrondi btnNouvelleClasse;
    private BoutonArrondi btnSupprimerClasse;
    private Panel pnlEntete;
    private Label lblSousTitre;
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
