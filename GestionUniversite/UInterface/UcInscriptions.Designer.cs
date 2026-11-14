using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcInscriptions
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
        dgvInscriptions = new GrilleModerne();
        pnlNombre = new Panel();
        lblNombre = new Label();
        pnlOutils2 = new Panel();
        flpRecus = new FlowLayoutPanel();
        btnRecu = new BoutonArrondi();
        btnRecuPdf = new BoutonArrondi();
        flpExports = new FlowLayoutPanel();
        btnExporter = new BoutonArrondi();
        btnPdf = new BoutonArrondi();
        btnImprimer = new BoutonArrondi();
        pnlOutils = new Panel();
        pnlRecherche = new PanelArrondi();
        txtRecherche = new TextBox();
        icoRecherche = new FontAwesome.Sharp.IconPictureBox();
        flpActions = new FlowLayoutPanel();
        btnNouvelle = new BoutonArrondi();
        btnValider = new BoutonArrondi();
        btnAnnulerInscription = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colDate = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colEtudiant = new DataGridViewTextBoxColumn();
        colClasse = new DataGridViewTextBoxColumn();
        colFrais = new DataGridViewTextBoxColumn();
        colStatut = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).BeginInit();
        pnlCarte.SuspendLayout();
        pnlNombre.SuspendLayout();
        pnlOutils2.SuspendLayout();
        flpRecus.SuspendLayout();
        flpExports.SuspendLayout();
        pnlOutils.SuspendLayout();
        pnlRecherche.SuspendLayout();
        flpActions.SuspendLayout();
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
        pnlCarte.Controls.Add(dgvInscriptions);
        //
        // dgvInscriptions
        //
        dgvInscriptions.AutoGenerateColumns = false;
        dgvInscriptions.Dock = DockStyle.Fill;
        dgvInscriptions.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colMatricule, colEtudiant, colClasse, colFrais, colStatut });
        dgvInscriptions.Name = "dgvInscriptions";
        dgvInscriptions.TabIndex = 1;
        //
        // colId
        //
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colId.FillWeight = 100F;
        colId.DataPropertyName = "idInscription";
        colId.HeaderText = "Id";
        colId.Name = "colId";
        colId.ReadOnly = true;
        colId.Visible = false;
        //
        // colDate
        //
        colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colDate.Width = 100;
        colDate.DataPropertyName = "jour";
        colDate.HeaderText = "Date";
        colDate.Name = "colDate";
        colDate.ReadOnly = true;
        //
        // colMatricule
        //
        colMatricule.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colMatricule.Width = 120;
        colMatricule.DataPropertyName = "matricule";
        colMatricule.HeaderText = "Matricule";
        colMatricule.Name = "colMatricule";
        colMatricule.ReadOnly = true;
        //
        // colEtudiant
        //
        colEtudiant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEtudiant.FillWeight = 140F;
        colEtudiant.DataPropertyName = "etudiant";
        colEtudiant.HeaderText = "Étudiant";
        colEtudiant.Name = "colEtudiant";
        colEtudiant.ReadOnly = true;
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
        // colFrais
        //
        colFrais.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colFrais.Width = 130;
        colFrais.DataPropertyName = "frais";
        colFrais.HeaderText = "Frais";
        colFrais.Name = "colFrais";
        colFrais.ReadOnly = true;
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
        // pnlOutils2
        //
        pnlOutils2.Dock = DockStyle.Top;
        pnlOutils2.Size = new Size(100, 52);
        pnlOutils2.Name = "pnlOutils2";
        pnlOutils2.TabIndex = 4;
        pnlOutils2.Controls.Add(flpRecus);
        pnlOutils2.Controls.Add(flpExports);
        //
        // flpRecus
        //
        flpRecus.AutoSize = true;
        flpRecus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpRecus.Dock = DockStyle.Left;
        flpRecus.FlowDirection = FlowDirection.LeftToRight;
        flpRecus.WrapContents = false;
        flpRecus.Size = new Size(100, 52);
        flpRecus.Name = "flpRecus";
        flpRecus.TabIndex = 5;
        flpRecus.Controls.Add(btnRecu);
        flpRecus.Controls.Add(btnRecuPdf);
        //
        // btnRecu
        //
        btnRecu.BackColor = Color.FromArgb(239, 232, 234);
        btnRecu.ForeColor = Color.FromArgb(27, 20, 22);
        btnRecu.Text = "Reçu";
        btnRecu.UseVisualStyleBackColor = false;
        btnRecu.Location = new Point(0, 0);
        btnRecu.Size = new Size(80, 40);
        btnRecu.Tag = "secondaire";
        btnRecu.Margin = new Padding(0, 6, 8, 6);
        btnRecu.Name = "btnRecu";
        btnRecu.TabIndex = 6;
        //
        // btnRecuPdf
        //
        btnRecuPdf.BackColor = Color.FromArgb(239, 232, 234);
        btnRecuPdf.ForeColor = Color.FromArgb(27, 20, 22);
        btnRecuPdf.Text = "Reçu en PDF";
        btnRecuPdf.UseVisualStyleBackColor = false;
        btnRecuPdf.Location = new Point(0, 0);
        btnRecuPdf.Size = new Size(120, 40);
        btnRecuPdf.Tag = "secondaire";
        btnRecuPdf.Margin = new Padding(0, 6, 8, 6);
        btnRecuPdf.Name = "btnRecuPdf";
        btnRecuPdf.TabIndex = 7;
        //
        // flpExports
        //
        flpExports.AutoSize = true;
        flpExports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpExports.Dock = DockStyle.Right;
        flpExports.FlowDirection = FlowDirection.LeftToRight;
        flpExports.WrapContents = false;
        flpExports.Size = new Size(100, 52);
        flpExports.Name = "flpExports";
        flpExports.TabIndex = 8;
        flpExports.Controls.Add(btnExporter);
        flpExports.Controls.Add(btnPdf);
        flpExports.Controls.Add(btnImprimer);
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
        btnExporter.Margin = new Padding(8, 6, 0, 6);
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
        btnPdf.Margin = new Padding(8, 6, 0, 6);
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
        btnImprimer.Margin = new Padding(8, 6, 0, 6);
        btnImprimer.Name = "btnImprimer";
        btnImprimer.TabIndex = 11;
        //
        // pnlOutils
        //
        pnlOutils.Dock = DockStyle.Top;
        pnlOutils.Size = new Size(100, 56);
        pnlOutils.Name = "pnlOutils";
        pnlOutils.TabIndex = 12;
        pnlOutils.Controls.Add(pnlRecherche);
        pnlOutils.Controls.Add(flpActions);
        //
        // pnlRecherche
        //
        pnlRecherche.BackColor = Color.FromArgb(255, 255, 255);
        pnlRecherche.Rayon = 12;
        pnlRecherche.Location = new Point(0, 8);
        pnlRecherche.Size = new Size(320, 40);
        pnlRecherche.Tag = "input";
        pnlRecherche.Name = "pnlRecherche";
        pnlRecherche.TabIndex = 13;
        pnlRecherche.Controls.Add(txtRecherche);
        pnlRecherche.Controls.Add(icoRecherche);
        //
        // txtRecherche
        //
        txtRecherche.BackColor = Color.FromArgb(255, 255, 255);
        txtRecherche.BorderStyle = BorderStyle.None;
        txtRecherche.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtRecherche.Location = new Point(44, 11);
        txtRecherche.PlaceholderText = "Rechercher un étudiant, une classe…";
        txtRecherche.Size = new Size(260, 20);
        txtRecherche.Tag = "input";
        txtRecherche.Name = "txtRecherche";
        txtRecherche.TabIndex = 14;
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
        icoRecherche.TabIndex = 15;
        //
        // flpActions
        //
        flpActions.AutoSize = true;
        flpActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpActions.Dock = DockStyle.Right;
        flpActions.FlowDirection = FlowDirection.LeftToRight;
        flpActions.WrapContents = false;
        flpActions.Size = new Size(100, 56);
        flpActions.Name = "flpActions";
        flpActions.TabIndex = 16;
        flpActions.Controls.Add(btnNouvelle);
        flpActions.Controls.Add(btnValider);
        flpActions.Controls.Add(btnAnnulerInscription);
        //
        // btnNouvelle
        //
        btnNouvelle.BackColor = Color.FromArgb(155, 27, 48);
        btnNouvelle.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouvelle.Text = "Nouvelle inscription";
        btnNouvelle.UseVisualStyleBackColor = false;
        btnNouvelle.Location = new Point(0, 0);
        btnNouvelle.Size = new Size(170, 40);
        btnNouvelle.Margin = new Padding(8, 8, 0, 8);
        btnNouvelle.Name = "btnNouvelle";
        btnNouvelle.TabIndex = 17;
        //
        // btnValider
        //
        btnValider.BackColor = Color.FromArgb(30, 107, 58);
        btnValider.ForeColor = Color.FromArgb(255, 255, 255);
        btnValider.Text = "Valider";
        btnValider.UseVisualStyleBackColor = false;
        btnValider.Location = new Point(0, 0);
        btnValider.Size = new Size(90, 40);
        btnValider.Margin = new Padding(8, 8, 0, 8);
        btnValider.Name = "btnValider";
        btnValider.TabIndex = 18;
        //
        // btnAnnulerInscription
        //
        btnAnnulerInscription.BackColor = Color.FromArgb(179, 38, 30);
        btnAnnulerInscription.ForeColor = Color.FromArgb(255, 255, 255);
        btnAnnulerInscription.Text = "Annuler l’inscription";
        btnAnnulerInscription.UseVisualStyleBackColor = false;
        btnAnnulerInscription.Location = new Point(0, 0);
        btnAnnulerInscription.Size = new Size(160, 40);
        btnAnnulerInscription.Margin = new Padding(8, 8, 0, 8);
        btnAnnulerInscription.Name = "btnAnnulerInscription";
        btnAnnulerInscription.TabIndex = 19;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 20;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Inscriptions de l’année académique en cours";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 21;
        //
        // UcInscriptions
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcInscriptions";
        Controls.Add(pnlCarte);
        Controls.Add(pnlNombre);
        Controls.Add(pnlOutils2);
        Controls.Add(pnlOutils);
        Controls.Add(pnlEntete);
        btnRecu.Click += btnRecu_Click;
        btnRecuPdf.Click += btnRecuPdf_Click;
        btnExporter.Click += btnExporter_Click;
        btnPdf.Click += btnPdf_Click;
        btnImprimer.Click += btnImprimer_Click;
        txtRecherche.TextChanged += txtRecherche_TextChanged;
        btnNouvelle.Click += btnNouvelle_Click;
        btnValider.Click += btnValider_Click;
        btnAnnulerInscription.Click += btnAnnulerInscription_Click;
        Load += UcInscriptions_Load;
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).EndInit();
        pnlCarte.ResumeLayout(false);
        pnlNombre.ResumeLayout(false);
        pnlOutils2.ResumeLayout(false);
        flpRecus.ResumeLayout(false);
        flpExports.ResumeLayout(false);
        pnlOutils.ResumeLayout(false);
        pnlRecherche.ResumeLayout(false);
        flpActions.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlCarte;
    private GrilleModerne dgvInscriptions;
    private Panel pnlNombre;
    private Label lblNombre;
    private Panel pnlOutils2;
    private FlowLayoutPanel flpRecus;
    private BoutonArrondi btnRecu;
    private BoutonArrondi btnRecuPdf;
    private FlowLayoutPanel flpExports;
    private BoutonArrondi btnExporter;
    private BoutonArrondi btnPdf;
    private BoutonArrondi btnImprimer;
    private Panel pnlOutils;
    private PanelArrondi pnlRecherche;
    private TextBox txtRecherche;
    private FontAwesome.Sharp.IconPictureBox icoRecherche;
    private FlowLayoutPanel flpActions;
    private BoutonArrondi btnNouvelle;
    private BoutonArrondi btnValider;
    private BoutonArrondi btnAnnulerInscription;
    private Panel pnlEntete;
    private Label lblSousTitre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colDate;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colEtudiant;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colFrais;
    private DataGridViewTextBoxColumn colStatut;
}
