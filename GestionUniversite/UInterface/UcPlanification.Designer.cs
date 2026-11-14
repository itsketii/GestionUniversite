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
        pnlCarte = new PanelArrondi();
        grilleHebdo = new GrilleHebdo();
        dgvSeances = new GrilleModerne();
        pnlActions = new Panel();
        lblLegCM = new Label();
        lblLegTD = new Label();
        lblLegTP = new Label();
        lblNombre = new Label();
        flpActions = new FlowLayoutPanel();
        btnExporter = new BoutonArrondi();
        btnPdf = new BoutonArrondi();
        btnImprimer = new BoutonArrondi();
        btnPlanifier = new BoutonArrondi();
        btnAnnulerSeance = new BoutonArrondi();
        pnlNav = new Panel();
        btnPrecedente = new BoutonArrondi();
        lblSemaine = new Label();
        btnSuivante = new BoutonArrondi();
        btnCetteSemaine = new BoutonArrondi();
        cboClasse = new ComboBox();
        flpVues = new FlowLayoutPanel();
        btnVueListe = new BoutonArrondi();
        btnVueCalendrier = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
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
        pnlCarte.SuspendLayout();
        pnlActions.SuspendLayout();
        flpActions.SuspendLayout();
        pnlNav.SuspendLayout();
        flpVues.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // pnlCarte
        //
        pnlCarte.BackColor = Color.FromArgb(255, 255, 255);
        pnlCarte.Rayon = 16;
        pnlCarte.Dock = DockStyle.Fill;
        pnlCarte.Tag = "carte";
        pnlCarte.Padding = new Padding(8, 8, 8, 8);
        pnlCarte.Name = "pnlCarte";
        pnlCarte.TabIndex = 0;
        pnlCarte.Controls.Add(grilleHebdo);
        pnlCarte.Controls.Add(dgvSeances);
        //
        // grilleHebdo
        //
        grilleHebdo.BackColor = Color.FromArgb(255, 255, 255);
        grilleHebdo.Dock = DockStyle.Fill;
        grilleHebdo.Tag = "carte";
        grilleHebdo.Name = "grilleHebdo";
        grilleHebdo.TabIndex = 1;
        //
        // dgvSeances
        //
        dgvSeances.AutoGenerateColumns = false;
        dgvSeances.Dock = DockStyle.Fill;
        dgvSeances.Visible = false;
        dgvSeances.Columns.AddRange(new DataGridViewColumn[] { colId, colJour, colHeure, colMatiere, colClasse, colEnseignant, colSalle, colType, colStatut });
        dgvSeances.Name = "dgvSeances";
        dgvSeances.TabIndex = 2;
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
        colJour.Width = 120;
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
        // pnlActions
        //
        pnlActions.Dock = DockStyle.Top;
        pnlActions.Size = new Size(100, 56);
        pnlActions.Name = "pnlActions";
        pnlActions.TabIndex = 3;
        pnlActions.Controls.Add(lblLegCM);
        pnlActions.Controls.Add(lblLegTD);
        pnlActions.Controls.Add(lblLegTP);
        pnlActions.Controls.Add(lblNombre);
        pnlActions.Controls.Add(flpActions);
        //
        // lblLegCM
        //
        lblLegCM.AutoSize = false;
        lblLegCM.BackColor = Color.FromArgb(155, 27, 48);
        lblLegCM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblLegCM.ForeColor = Color.FromArgb(255, 255, 255);
        lblLegCM.Location = new Point(4, 16);
        lblLegCM.Size = new Size(46, 24);
        lblLegCM.Text = "CM";
        lblLegCM.TextAlign = ContentAlignment.MiddleCenter;
        lblLegCM.Name = "lblLegCM";
        lblLegCM.TabIndex = 4;
        //
        // lblLegTD
        //
        lblLegTD.AutoSize = false;
        lblLegTD.BackColor = Color.FromArgb(74, 85, 104);
        lblLegTD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblLegTD.ForeColor = Color.FromArgb(255, 255, 255);
        lblLegTD.Location = new Point(56, 16);
        lblLegTD.Size = new Size(46, 24);
        lblLegTD.Text = "TD";
        lblLegTD.TextAlign = ContentAlignment.MiddleCenter;
        lblLegTD.Name = "lblLegTD";
        lblLegTD.TabIndex = 5;
        //
        // lblLegTP
        //
        lblLegTP.AutoSize = false;
        lblLegTP.BackColor = Color.FromArgb(180, 83, 9);
        lblLegTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblLegTP.ForeColor = Color.FromArgb(255, 255, 255);
        lblLegTP.Location = new Point(108, 16);
        lblLegTP.Size = new Size(46, 24);
        lblLegTP.Text = "TP";
        lblLegTP.TextAlign = ContentAlignment.MiddleCenter;
        lblLegTP.Name = "lblLegTP";
        lblLegTP.TabIndex = 6;
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.Location = new Point(166, 16);
        lblNombre.Size = new Size(200, 24);
        lblNombre.Text = "";
        lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.ForeColor = Color.FromArgb(107, 96, 99);
        lblNombre.Tag = "discret";
        lblNombre.Name = "lblNombre";
        lblNombre.TabIndex = 7;
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
        flpActions.TabIndex = 8;
        flpActions.Controls.Add(btnExporter);
        flpActions.Controls.Add(btnPdf);
        flpActions.Controls.Add(btnImprimer);
        flpActions.Controls.Add(btnPlanifier);
        flpActions.Controls.Add(btnAnnulerSeance);
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
        // btnPlanifier
        //
        btnPlanifier.BackColor = Color.FromArgb(155, 27, 48);
        btnPlanifier.ForeColor = Color.FromArgb(255, 255, 255);
        btnPlanifier.Text = "Planifier une séance";
        btnPlanifier.UseVisualStyleBackColor = false;
        btnPlanifier.Location = new Point(0, 0);
        btnPlanifier.Size = new Size(170, 40);
        btnPlanifier.Margin = new Padding(8, 8, 0, 8);
        btnPlanifier.Name = "btnPlanifier";
        btnPlanifier.TabIndex = 12;
        //
        // btnAnnulerSeance
        //
        btnAnnulerSeance.BackColor = Color.FromArgb(179, 38, 30);
        btnAnnulerSeance.ForeColor = Color.FromArgb(255, 255, 255);
        btnAnnulerSeance.Text = "Annuler la séance";
        btnAnnulerSeance.UseVisualStyleBackColor = false;
        btnAnnulerSeance.Location = new Point(0, 0);
        btnAnnulerSeance.Size = new Size(150, 40);
        btnAnnulerSeance.Margin = new Padding(8, 8, 0, 8);
        btnAnnulerSeance.Name = "btnAnnulerSeance";
        btnAnnulerSeance.TabIndex = 13;
        //
        // pnlNav
        //
        pnlNav.Dock = DockStyle.Top;
        pnlNav.Size = new Size(100, 56);
        pnlNav.Name = "pnlNav";
        pnlNav.TabIndex = 14;
        pnlNav.Controls.Add(btnPrecedente);
        pnlNav.Controls.Add(lblSemaine);
        pnlNav.Controls.Add(btnSuivante);
        pnlNav.Controls.Add(btnCetteSemaine);
        pnlNav.Controls.Add(cboClasse);
        pnlNav.Controls.Add(flpVues);
        //
        // btnPrecedente
        //
        btnPrecedente.BackColor = Color.FromArgb(58, 47, 50);
        btnPrecedente.ForeColor = Color.FromArgb(255, 255, 255);
        btnPrecedente.Text = "Précédente";
        btnPrecedente.UseVisualStyleBackColor = false;
        btnPrecedente.Location = new Point(0, 8);
        btnPrecedente.Size = new Size(96, 40);
        btnPrecedente.Name = "btnPrecedente";
        btnPrecedente.TabIndex = 15;
        //
        // lblSemaine
        //
        lblSemaine.AutoSize = false;
        lblSemaine.Location = new Point(100, 8);
        lblSemaine.Size = new Size(240, 40);
        lblSemaine.Text = "";
        lblSemaine.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblSemaine.ForeColor = Color.FromArgb(27, 20, 22);
        lblSemaine.Tag = "texte";
        lblSemaine.TextAlign = ContentAlignment.MiddleCenter;
        lblSemaine.Name = "lblSemaine";
        lblSemaine.TabIndex = 16;
        //
        // btnSuivante
        //
        btnSuivante.BackColor = Color.FromArgb(58, 47, 50);
        btnSuivante.ForeColor = Color.FromArgb(255, 255, 255);
        btnSuivante.Text = "Suivante";
        btnSuivante.UseVisualStyleBackColor = false;
        btnSuivante.Location = new Point(344, 8);
        btnSuivante.Size = new Size(96, 40);
        btnSuivante.Name = "btnSuivante";
        btnSuivante.TabIndex = 17;
        //
        // btnCetteSemaine
        //
        btnCetteSemaine.BackColor = Color.FromArgb(58, 47, 50);
        btnCetteSemaine.ForeColor = Color.FromArgb(255, 255, 255);
        btnCetteSemaine.Text = "Cette semaine";
        btnCetteSemaine.UseVisualStyleBackColor = false;
        btnCetteSemaine.Location = new Point(448, 8);
        btnCetteSemaine.Size = new Size(130, 40);
        btnCetteSemaine.Name = "btnCetteSemaine";
        btnCetteSemaine.TabIndex = 18;
        //
        // cboClasse
        //
        cboClasse.BackColor = Color.FromArgb(255, 255, 255);
        cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
        cboClasse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboClasse.Location = new Point(592, 14);
        cboClasse.Size = new Size(190, 28);
        cboClasse.Tag = "input";
        cboClasse.Name = "cboClasse";
        cboClasse.TabIndex = 19;
        //
        // flpVues
        //
        flpVues.AutoSize = true;
        flpVues.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpVues.Dock = DockStyle.Right;
        flpVues.FlowDirection = FlowDirection.LeftToRight;
        flpVues.WrapContents = false;
        flpVues.Size = new Size(100, 56);
        flpVues.Name = "flpVues";
        flpVues.TabIndex = 20;
        flpVues.Controls.Add(btnVueListe);
        flpVues.Controls.Add(btnVueCalendrier);
        //
        // btnVueListe
        //
        btnVueListe.BackColor = Color.FromArgb(239, 232, 234);
        btnVueListe.ForeColor = Color.FromArgb(27, 20, 22);
        btnVueListe.Text = "Liste";
        btnVueListe.UseVisualStyleBackColor = false;
        btnVueListe.Location = new Point(0, 0);
        btnVueListe.Size = new Size(84, 40);
        btnVueListe.Tag = "secondaire";
        btnVueListe.Margin = new Padding(8, 8, 0, 8);
        btnVueListe.Name = "btnVueListe";
        btnVueListe.TabIndex = 21;
        //
        // btnVueCalendrier
        //
        btnVueCalendrier.BackColor = Color.FromArgb(155, 27, 48);
        btnVueCalendrier.ForeColor = Color.FromArgb(255, 255, 255);
        btnVueCalendrier.Text = "Calendrier";
        btnVueCalendrier.UseVisualStyleBackColor = false;
        btnVueCalendrier.Location = new Point(0, 0);
        btnVueCalendrier.Size = new Size(116, 40);
        btnVueCalendrier.Margin = new Padding(8, 8, 0, 8);
        btnVueCalendrier.Name = "btnVueCalendrier";
        btnVueCalendrier.TabIndex = 22;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 23;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Emploi du temps de la semaine";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 24;
        //
        // UcPlanification
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcPlanification";
        Controls.Add(pnlCarte);
        Controls.Add(pnlActions);
        Controls.Add(pnlNav);
        Controls.Add(pnlEntete);
        btnExporter.Click += btnExporter_Click;
        btnPdf.Click += btnPdf_Click;
        btnImprimer.Click += btnImprimer_Click;
        btnPlanifier.Click += btnPlanifier_Click;
        btnAnnulerSeance.Click += btnAnnulerSeance_Click;
        btnPrecedente.Click += btnPrecedente_Click;
        btnSuivante.Click += btnSuivante_Click;
        btnCetteSemaine.Click += btnCetteSemaine_Click;
        cboClasse.SelectedIndexChanged += cboClasse_SelectedIndexChanged;
        btnVueListe.Click += btnVueListe_Click;
        btnVueCalendrier.Click += btnVueCalendrier_Click;
        Load += UcPlanification_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSeances).EndInit();
        pnlCarte.ResumeLayout(false);
        pnlActions.ResumeLayout(false);
        flpActions.ResumeLayout(false);
        pnlNav.ResumeLayout(false);
        flpVues.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlCarte;
    private GrilleHebdo grilleHebdo;
    private GrilleModerne dgvSeances;
    private Panel pnlActions;
    private Label lblLegCM;
    private Label lblLegTD;
    private Label lblLegTP;
    private Label lblNombre;
    private FlowLayoutPanel flpActions;
    private BoutonArrondi btnExporter;
    private BoutonArrondi btnPdf;
    private BoutonArrondi btnImprimer;
    private BoutonArrondi btnPlanifier;
    private BoutonArrondi btnAnnulerSeance;
    private Panel pnlNav;
    private BoutonArrondi btnPrecedente;
    private Label lblSemaine;
    private BoutonArrondi btnSuivante;
    private BoutonArrondi btnCetteSemaine;
    private ComboBox cboClasse;
    private FlowLayoutPanel flpVues;
    private BoutonArrondi btnVueListe;
    private BoutonArrondi btnVueCalendrier;
    private Panel pnlEntete;
    private Label lblSousTitre;
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
