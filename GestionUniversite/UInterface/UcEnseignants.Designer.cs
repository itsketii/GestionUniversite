using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcEnseignants
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlCarte = new PanelArrondi();
        dgvEnseignants = new GrilleModerne();
        pnlNombre = new Panel();
        lblNombre = new Label();
        pnlOutils = new Panel();
        pnlRecherche = new PanelArrondi();
        txtRecherche = new TextBox();
        icoRecherche = new FontAwesome.Sharp.IconPictureBox();
        flpBoutons = new FlowLayoutPanel();
        btnExporter = new BoutonArrondi();
        btnPdf = new BoutonArrondi();
        btnImprimer = new BoutonArrondi();
        btnNouveau = new BoutonArrondi();
        btnModifier = new BoutonArrondi();
        btnSupprimer = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colNom = new DataGridViewTextBoxColumn();
        colPrenoms = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        colTel = new DataGridViewTextBoxColumn();
        colGrade = new DataGridViewTextBoxColumn();
        colSpec = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEnseignants).BeginInit();
        pnlCarte.SuspendLayout();
        pnlNombre.SuspendLayout();
        pnlOutils.SuspendLayout();
        pnlRecherche.SuspendLayout();
        flpBoutons.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // pnlCarte
        //
        pnlCarte.BackColor = Color.FromArgb(255, 255, 255);
        pnlCarte.Rayon = 16;
        pnlCarte.Dock = DockStyle.Fill;
        pnlCarte.Tag = "carte";
        pnlCarte.Padding = new Padding(6, 6, 6, 6);
        pnlCarte.Name = "pnlCarte";
        pnlCarte.TabIndex = 0;
        pnlCarte.Controls.Add(dgvEnseignants);
        //
        // dgvEnseignants
        //
        dgvEnseignants.AutoGenerateColumns = false;
        dgvEnseignants.Dock = DockStyle.Fill;
        dgvEnseignants.Columns.AddRange(new DataGridViewColumn[] { colId, colMatricule, colNom, colPrenoms, colEmail, colTel, colGrade, colSpec });
        dgvEnseignants.Name = "dgvEnseignants";
        dgvEnseignants.TabIndex = 1;
        //
        // colId
        //
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 100F;
        colId.DataPropertyName = "idEnseignant";
        colId.HeaderText = "Id";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        //
        // colMatricule
        //
        colMatricule.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colMatricule.Width = 110;
        colMatricule.DataPropertyName = "matricule";
        colMatricule.HeaderText = "Matricule";
        colMatricule.Name = "colMatricule";
        colMatricule.ReadOnly = true;
        //
        // colNom
        //
        colNom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colNom.FillWeight = 90F;
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
        // colEmail
        //
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEmail.FillWeight = 140F;
        colEmail.DataPropertyName = "email";
        colEmail.HeaderText = "E-mail";
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        //
        // colTel
        //
        colTel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colTel.Width = 120;
        colTel.DataPropertyName = "telephone";
        colTel.HeaderText = "Téléphone";
        colTel.Name = "colTel";
        colTel.ReadOnly = true;
        //
        // colGrade
        //
        colGrade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colGrade.Width = 100;
        colGrade.DataPropertyName = "grade";
        colGrade.HeaderText = "Grade";
        colGrade.Name = "colGrade";
        colGrade.ReadOnly = true;
        //
        // colSpec
        //
        colSpec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colSpec.FillWeight = 100F;
        colSpec.DataPropertyName = "specialite";
        colSpec.HeaderText = "Spécialité";
        colSpec.Name = "colSpec";
        colSpec.ReadOnly = true;
        //
        // pnlNombre
        //
        pnlNombre.Dock = DockStyle.Bottom;
        pnlNombre.Size = new Size(100, 30);
        pnlNombre.Name = "pnlNombre";
        pnlNombre.TabIndex = 2;
        pnlNombre.Controls.Add(lblNombre);
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.Location = new Point(6, 5);
        lblNombre.Size = new Size(500, 22);
        lblNombre.Text = "";
        lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.ForeColor = Color.FromArgb(107, 96, 99);
        lblNombre.Tag = "discret";
        lblNombre.Name = "lblNombre";
        lblNombre.TabIndex = 3;
        //
        // pnlOutils
        //
        pnlOutils.Dock = DockStyle.Top;
        pnlOutils.Size = new Size(100, 56);
        pnlOutils.Name = "pnlOutils";
        pnlOutils.TabIndex = 4;
        pnlOutils.Controls.Add(pnlRecherche);
        pnlOutils.Controls.Add(flpBoutons);
        //
        // pnlRecherche
        //
        pnlRecherche.BackColor = Color.FromArgb(255, 255, 255);
        pnlRecherche.Rayon = 12;
        pnlRecherche.Location = new Point(0, 8);
        pnlRecherche.Size = new Size(340, 40);
        pnlRecherche.Tag = "input";
        pnlRecherche.Name = "pnlRecherche";
        pnlRecherche.TabIndex = 5;
        pnlRecherche.Controls.Add(txtRecherche);
        pnlRecherche.Controls.Add(icoRecherche);
        //
        // txtRecherche
        //
        txtRecherche.BackColor = Color.FromArgb(255, 255, 255);
        txtRecherche.BorderStyle = BorderStyle.None;
        txtRecherche.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtRecherche.Location = new Point(44, 11);
        txtRecherche.PlaceholderText = "Rechercher…";
        txtRecherche.Size = new Size(280, 20);
        txtRecherche.Tag = "input";
        txtRecherche.Name = "txtRecherche";
        txtRecherche.TabIndex = 6;
        //
        // icoRecherche
        //
        icoRecherche.BackColor = Color.Transparent;
        icoRecherche.ForeColor = Color.FromArgb(138, 127, 131);
        icoRecherche.IconChar = (FontAwesome.Sharp.IconChar)0xf002;
        icoRecherche.IconColor = Color.FromArgb(138, 127, 131);
        icoRecherche.IconSize = 18;
        icoRecherche.Location = new Point(16, 11);
        icoRecherche.Size = new Size(18, 18);
        icoRecherche.TabStop = false;
        icoRecherche.Name = "icoRecherche";
        icoRecherche.TabIndex = 7;
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
        flpBoutons.TabIndex = 8;
        flpBoutons.Controls.Add(btnExporter);
        flpBoutons.Controls.Add(btnPdf);
        flpBoutons.Controls.Add(btnImprimer);
        flpBoutons.Controls.Add(btnNouveau);
        flpBoutons.Controls.Add(btnModifier);
        flpBoutons.Controls.Add(btnSupprimer);
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
        btnExporter.TabIndex = 9;
        //
        // btnPdf
        //
        btnPdf.BackColor = Color.FromArgb(239, 232, 234);
        btnPdf.ForeColor = Color.FromArgb(27, 20, 22);
        btnPdf.Text = "PDF";
        btnPdf.UseVisualStyleBackColor = false;
        btnPdf.Location = new Point(0, 0);
        btnPdf.Size = new Size(60, 40);
        btnPdf.Tag = "secondaire";
        btnPdf.Margin = new Padding(8, 8, 0, 8);
        btnPdf.Name = "btnPdf";
        btnPdf.TabIndex = 10;
        //
        // btnImprimer
        //
        btnImprimer.BackColor = Color.FromArgb(239, 232, 234);
        btnImprimer.ForeColor = Color.FromArgb(27, 20, 22);
        btnImprimer.Text = "Imprimer";
        btnImprimer.UseVisualStyleBackColor = false;
        btnImprimer.Location = new Point(0, 0);
        btnImprimer.Size = new Size(92, 40);
        btnImprimer.Tag = "secondaire";
        btnImprimer.Margin = new Padding(8, 8, 0, 8);
        btnImprimer.Name = "btnImprimer";
        btnImprimer.TabIndex = 11;
        //
        // btnNouveau
        //
        btnNouveau.BackColor = Color.FromArgb(155, 27, 48);
        btnNouveau.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouveau.Text = "Nouvel enseignant";
        btnNouveau.UseVisualStyleBackColor = false;
        btnNouveau.Location = new Point(0, 0);
        btnNouveau.Size = new Size(160, 40);
        btnNouveau.Margin = new Padding(8, 8, 0, 8);
        btnNouveau.Name = "btnNouveau";
        btnNouveau.TabIndex = 12;
        //
        // btnModifier
        //
        btnModifier.BackColor = Color.FromArgb(58, 47, 50);
        btnModifier.ForeColor = Color.FromArgb(255, 255, 255);
        btnModifier.Text = "Modifier";
        btnModifier.UseVisualStyleBackColor = false;
        btnModifier.Location = new Point(0, 0);
        btnModifier.Size = new Size(96, 40);
        btnModifier.Margin = new Padding(8, 8, 0, 8);
        btnModifier.Name = "btnModifier";
        btnModifier.TabIndex = 13;
        //
        // btnSupprimer
        //
        btnSupprimer.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimer.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimer.Text = "Supprimer";
        btnSupprimer.UseVisualStyleBackColor = false;
        btnSupprimer.Location = new Point(0, 0);
        btnSupprimer.Size = new Size(108, 40);
        btnSupprimer.Margin = new Padding(8, 8, 0, 8);
        btnSupprimer.Name = "btnSupprimer";
        btnSupprimer.TabIndex = 14;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 15;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Corps enseignant de l’université";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 16;
        //
        // UcEnseignants
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcEnseignants";
        Controls.Add(pnlCarte);
        Controls.Add(pnlNombre);
        Controls.Add(pnlOutils);
        Controls.Add(pnlEntete);
        dgvEnseignants.CellDoubleClick += dgvEnseignants_CellDoubleClick;
        txtRecherche.TextChanged += txtRecherche_TextChanged;
        btnExporter.Click += btnExporter_Click;
        btnPdf.Click += btnPdf_Click;
        btnImprimer.Click += btnImprimer_Click;
        btnNouveau.Click += btnNouveau_Click;
        btnModifier.Click += btnModifier_Click;
        btnSupprimer.Click += btnSupprimer_Click;
        Load += UcEnseignants_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEnseignants).EndInit();
        pnlCarte.ResumeLayout(false);
        pnlNombre.ResumeLayout(false);
        pnlOutils.ResumeLayout(false);
        pnlRecherche.ResumeLayout(false);
        flpBoutons.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlCarte;
    private GrilleModerne dgvEnseignants;
    private Panel pnlNombre;
    private Label lblNombre;
    private Panel pnlOutils;
    private PanelArrondi pnlRecherche;
    private TextBox txtRecherche;
    private FontAwesome.Sharp.IconPictureBox icoRecherche;
    private FlowLayoutPanel flpBoutons;
    private BoutonArrondi btnExporter;
    private BoutonArrondi btnPdf;
    private BoutonArrondi btnImprimer;
    private BoutonArrondi btnNouveau;
    private BoutonArrondi btnModifier;
    private BoutonArrondi btnSupprimer;
    private Panel pnlEntete;
    private Label lblSousTitre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colNom;
    private DataGridViewTextBoxColumn colPrenoms;
    private DataGridViewTextBoxColumn colEmail;
    private DataGridViewTextBoxColumn colTel;
    private DataGridViewTextBoxColumn colGrade;
    private DataGridViewTextBoxColumn colSpec;
}
