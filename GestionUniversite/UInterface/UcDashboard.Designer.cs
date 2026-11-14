using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tlpBas = new TableLayoutPanel();
        cardFiliere = new PanelArrondi();
        grFiliere = new GraphiqueBarres();
        lblTitre_cardFiliere = new Label();
        cardStatuts = new PanelArrondi();
        grStatuts = new GraphiqueDonut();
        lblTitre_cardStatuts = new Label();
        cardClasses = new PanelArrondi();
        grClasses = new GraphiqueBarres();
        lblTitre_cardClasses = new Label();
        cardSeances = new PanelArrondi();
        dgvSeances = new GrilleModerne();
        lblTitre_cardSeances = new Label();
        cardInscriptions = new PanelArrondi();
        dgvInscriptions = new GrilleModerne();
        lblTitre_cardInscriptions = new Label();
        tlpKpi = new TableLayoutPanel();
        carteInscrits = new CarteKpi();
        carteAttente = new CarteKpi();
        carteClasses = new CarteKpi();
        carteSeances = new CarteKpi();
        carteAbsences = new CarteKpi();
        pnlBanniereZone = new Panel();
        imgBanniere = new ImageCouverture();
        lblBonjour = new Label();
        lblAccroche = new Label();
        lblDetail = new Label();
        btnNouvelleInscription = new BoutonArrondi();
        btnVoirStats = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        colJour = new DataGridViewTextBoxColumn();
        colHeure = new DataGridViewTextBoxColumn();
        colMatiere = new DataGridViewTextBoxColumn();
        colClasse = new DataGridViewTextBoxColumn();
        colSalle = new DataGridViewTextBoxColumn();
        colType = new DataGridViewTextBoxColumn();
        colJ = new DataGridViewTextBoxColumn();
        colEtud = new DataGridViewTextBoxColumn();
        colCl = new DataGridViewTextBoxColumn();
        colSt = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvSeances).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).BeginInit();
        tlpBas.SuspendLayout();
        cardFiliere.SuspendLayout();
        cardStatuts.SuspendLayout();
        cardClasses.SuspendLayout();
        cardSeances.SuspendLayout();
        cardInscriptions.SuspendLayout();
        tlpKpi.SuspendLayout();
        pnlBanniereZone.SuspendLayout();
        imgBanniere.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // tlpBas
        //
        tlpBas.ColumnCount = 3;
        tlpBas.RowCount = 2;
        tlpBas.Dock = DockStyle.Fill;
        tlpBas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpBas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpBas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        tlpBas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpBas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpBas.Name = "tlpBas";
        tlpBas.TabIndex = 0;
        tlpBas.Controls.Add(cardFiliere, 0, 0);
        tlpBas.Controls.Add(cardStatuts, 1, 0);
        tlpBas.Controls.Add(cardClasses, 2, 0);
        tlpBas.Controls.Add(cardSeances, 0, 1);
        tlpBas.SetColumnSpan(cardSeances, 2);
        tlpBas.Controls.Add(cardInscriptions, 2, 1);
        //
        // cardFiliere
        //
        cardFiliere.BackColor = Color.FromArgb(255, 255, 255);
        cardFiliere.Rayon = 16;
        cardFiliere.Dock = DockStyle.Fill;
        cardFiliere.Tag = "carte";
        cardFiliere.Padding = new Padding(18, 12, 18, 12);
        cardFiliere.Margin = new Padding(8, 8, 8, 8);
        cardFiliere.Name = "cardFiliere";
        cardFiliere.TabIndex = 1;
        cardFiliere.Controls.Add(grFiliere);
        cardFiliere.Controls.Add(lblTitre_cardFiliere);
        //
        // grFiliere
        //
        grFiliere.BackColor = Color.FromArgb(255, 255, 255);
        grFiliere.Dock = DockStyle.Fill;
        grFiliere.Tag = "carte";
        grFiliere.Name = "grFiliere";
        grFiliere.TabIndex = 2;
        //
        // lblTitre_cardFiliere
        //
        lblTitre_cardFiliere.AutoSize = false;
        lblTitre_cardFiliere.Dock = DockStyle.Top;
        lblTitre_cardFiliere.Text = "Inscriptions par filière";
        lblTitre_cardFiliere.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardFiliere.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardFiliere.Tag = "texte";
        lblTitre_cardFiliere.Name = "lblTitre_cardFiliere";
        lblTitre_cardFiliere.TabIndex = 3;
        //
        // cardStatuts
        //
        cardStatuts.BackColor = Color.FromArgb(255, 255, 255);
        cardStatuts.Rayon = 16;
        cardStatuts.Dock = DockStyle.Fill;
        cardStatuts.Tag = "carte";
        cardStatuts.Padding = new Padding(18, 12, 18, 12);
        cardStatuts.Margin = new Padding(8, 8, 8, 8);
        cardStatuts.Name = "cardStatuts";
        cardStatuts.TabIndex = 4;
        cardStatuts.Controls.Add(grStatuts);
        cardStatuts.Controls.Add(lblTitre_cardStatuts);
        //
        // grStatuts
        //
        grStatuts.BackColor = Color.FromArgb(255, 255, 255);
        grStatuts.Dock = DockStyle.Fill;
        grStatuts.Tag = "carte";
        grStatuts.Name = "grStatuts";
        grStatuts.TabIndex = 5;
        //
        // lblTitre_cardStatuts
        //
        lblTitre_cardStatuts.AutoSize = false;
        lblTitre_cardStatuts.Dock = DockStyle.Top;
        lblTitre_cardStatuts.Text = "Statut des inscriptions";
        lblTitre_cardStatuts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardStatuts.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardStatuts.Tag = "texte";
        lblTitre_cardStatuts.Name = "lblTitre_cardStatuts";
        lblTitre_cardStatuts.TabIndex = 6;
        //
        // cardClasses
        //
        cardClasses.BackColor = Color.FromArgb(255, 255, 255);
        cardClasses.Rayon = 16;
        cardClasses.Dock = DockStyle.Fill;
        cardClasses.Tag = "carte";
        cardClasses.Padding = new Padding(18, 12, 18, 12);
        cardClasses.Margin = new Padding(8, 8, 8, 8);
        cardClasses.Name = "cardClasses";
        cardClasses.TabIndex = 7;
        cardClasses.Controls.Add(grClasses);
        cardClasses.Controls.Add(lblTitre_cardClasses);
        //
        // grClasses
        //
        grClasses.BackColor = Color.FromArgb(255, 255, 255);
        grClasses.Dock = DockStyle.Fill;
        grClasses.Tag = "carte";
        grClasses.Name = "grClasses";
        grClasses.TabIndex = 8;
        //
        // lblTitre_cardClasses
        //
        lblTitre_cardClasses.AutoSize = false;
        lblTitre_cardClasses.Dock = DockStyle.Top;
        lblTitre_cardClasses.Text = "Effectif par classe";
        lblTitre_cardClasses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardClasses.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardClasses.Tag = "texte";
        lblTitre_cardClasses.Name = "lblTitre_cardClasses";
        lblTitre_cardClasses.TabIndex = 9;
        //
        // cardSeances
        //
        cardSeances.BackColor = Color.FromArgb(255, 255, 255);
        cardSeances.Rayon = 16;
        cardSeances.Dock = DockStyle.Fill;
        cardSeances.Tag = "carte";
        cardSeances.Padding = new Padding(8, 8, 8, 8);
        cardSeances.Margin = new Padding(8, 8, 8, 8);
        cardSeances.Name = "cardSeances";
        cardSeances.TabIndex = 10;
        cardSeances.Controls.Add(dgvSeances);
        cardSeances.Controls.Add(lblTitre_cardSeances);
        //
        // dgvSeances
        //
        dgvSeances.AutoGenerateColumns = false;
        dgvSeances.Dock = DockStyle.Fill;
        dgvSeances.Columns.AddRange(new DataGridViewColumn[] { colJour, colHeure, colMatiere, colClasse, colSalle, colType });
        dgvSeances.Name = "dgvSeances";
        dgvSeances.TabIndex = 11;
        //
        // colJour
        //
        colJour.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colJour.Width = 70;
        colJour.DataPropertyName = "jour";
        colJour.HeaderText = "Date";
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
        colMatiere.FillWeight = 140F;
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
        // lblTitre_cardSeances
        //
        lblTitre_cardSeances.AutoSize = false;
        lblTitre_cardSeances.Dock = DockStyle.Top;
        lblTitre_cardSeances.Text = "Prochaines séances";
        lblTitre_cardSeances.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardSeances.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardSeances.Tag = "texte";
        lblTitre_cardSeances.Name = "lblTitre_cardSeances";
        lblTitre_cardSeances.TabIndex = 12;
        //
        // cardInscriptions
        //
        cardInscriptions.BackColor = Color.FromArgb(255, 255, 255);
        cardInscriptions.Rayon = 16;
        cardInscriptions.Dock = DockStyle.Fill;
        cardInscriptions.Tag = "carte";
        cardInscriptions.Padding = new Padding(8, 8, 8, 8);
        cardInscriptions.Margin = new Padding(8, 8, 8, 8);
        cardInscriptions.Name = "cardInscriptions";
        cardInscriptions.TabIndex = 13;
        cardInscriptions.Controls.Add(dgvInscriptions);
        cardInscriptions.Controls.Add(lblTitre_cardInscriptions);
        //
        // dgvInscriptions
        //
        dgvInscriptions.AutoGenerateColumns = false;
        dgvInscriptions.Dock = DockStyle.Fill;
        dgvInscriptions.Columns.AddRange(new DataGridViewColumn[] { colJ, colEtud, colCl, colSt });
        dgvInscriptions.Name = "dgvInscriptions";
        dgvInscriptions.TabIndex = 14;
        //
        // colJ
        //
        colJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colJ.Width = 90;
        colJ.DataPropertyName = "jour";
        colJ.HeaderText = "Date";
        colJ.Name = "colJ";
        colJ.ReadOnly = true;
        //
        // colEtud
        //
        colEtud.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEtud.FillWeight = 130F;
        colEtud.DataPropertyName = "etudiant";
        colEtud.HeaderText = "Étudiant";
        colEtud.Name = "colEtud";
        colEtud.ReadOnly = true;
        //
        // colCl
        //
        colCl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colCl.FillWeight = 80F;
        colCl.DataPropertyName = "classe";
        colCl.HeaderText = "Classe";
        colCl.Name = "colCl";
        colCl.ReadOnly = true;
        //
        // colSt
        //
        colSt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colSt.Width = 100;
        colSt.DataPropertyName = "statut";
        colSt.HeaderText = "Statut";
        colSt.Name = "colSt";
        colSt.ReadOnly = true;
        //
        // lblTitre_cardInscriptions
        //
        lblTitre_cardInscriptions.AutoSize = false;
        lblTitre_cardInscriptions.Dock = DockStyle.Top;
        lblTitre_cardInscriptions.Text = "Dernières inscriptions";
        lblTitre_cardInscriptions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardInscriptions.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardInscriptions.Tag = "texte";
        lblTitre_cardInscriptions.Name = "lblTitre_cardInscriptions";
        lblTitre_cardInscriptions.TabIndex = 15;
        //
        // tlpKpi
        //
        tlpKpi.ColumnCount = 5;
        tlpKpi.RowCount = 1;
        tlpKpi.Dock = DockStyle.Top;
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpKpi.Size = new Size(100, 108);
        tlpKpi.Name = "tlpKpi";
        tlpKpi.TabIndex = 16;
        tlpKpi.Controls.Add(carteInscrits, 0, 0);
        tlpKpi.Controls.Add(carteAttente, 1, 0);
        tlpKpi.Controls.Add(carteClasses, 2, 0);
        tlpKpi.Controls.Add(carteSeances, 3, 0);
        tlpKpi.Controls.Add(carteAbsences, 4, 0);
        //
        // carteInscrits
        //
        carteInscrits.Dock = DockStyle.Fill;
        carteInscrits.Icone = 0xf19d;
        carteInscrits.Margin = new Padding(8, 8, 8, 8);
        carteInscrits.Teinte = Color.FromArgb(155, 27, 48);
        carteInscrits.Titre = "Étudiants inscrits";
        carteInscrits.Valeur = "0";
        carteInscrits.Name = "carteInscrits";
        carteInscrits.TabIndex = 17;
        //
        // carteAttente
        //
        carteAttente.Dock = DockStyle.Fill;
        carteAttente.Icone = 0xf017;
        carteAttente.Margin = new Padding(8, 8, 8, 8);
        carteAttente.Teinte = Color.FromArgb(180, 83, 9);
        carteAttente.Titre = "Inscriptions en attente";
        carteAttente.Valeur = "0";
        carteAttente.Name = "carteAttente";
        carteAttente.TabIndex = 18;
        //
        // carteClasses
        //
        carteClasses.Dock = DockStyle.Fill;
        carteClasses.Icone = 0xf0c0;
        carteClasses.Margin = new Padding(8, 8, 8, 8);
        carteClasses.Teinte = Color.FromArgb(94, 15, 30);
        carteClasses.Titre = "Classes ouvertes";
        carteClasses.Valeur = "0";
        carteClasses.Name = "carteClasses";
        carteClasses.TabIndex = 19;
        //
        // carteSeances
        //
        carteSeances.Dock = DockStyle.Fill;
        carteSeances.Icone = 0xf073;
        carteSeances.Margin = new Padding(8, 8, 8, 8);
        carteSeances.Teinte = Color.FromArgb(74, 85, 104);
        carteSeances.Titre = "Séances (7 prochains jours)";
        carteSeances.Valeur = "0";
        carteSeances.Name = "carteSeances";
        carteSeances.TabIndex = 20;
        //
        // carteAbsences
        //
        carteAbsences.Dock = DockStyle.Fill;
        carteAbsences.Icone = 0xf235;
        carteAbsences.Margin = new Padding(8, 8, 8, 8);
        carteAbsences.Teinte = Color.FromArgb(179, 38, 30);
        carteAbsences.Titre = "Absences non justifiées";
        carteAbsences.Valeur = "0";
        carteAbsences.Name = "carteAbsences";
        carteAbsences.TabIndex = 21;
        //
        // pnlBanniereZone
        //
        pnlBanniereZone.Dock = DockStyle.Top;
        pnlBanniereZone.Size = new Size(100, 150);
        pnlBanniereZone.Padding = new Padding(4, 0, 4, 14);
        pnlBanniereZone.Name = "pnlBanniereZone";
        pnlBanniereZone.TabIndex = 22;
        pnlBanniereZone.Controls.Add(imgBanniere);
        //
        // imgBanniere
        //
        imgBanniere.Dock = DockStyle.Fill;
        imgBanniere.Image = Properties.Resources.IIT_Paysage;
        imgBanniere.Rayon = 20;
        imgBanniere.Name = "imgBanniere";
        imgBanniere.TabIndex = 23;
        imgBanniere.Controls.Add(lblBonjour);
        imgBanniere.Controls.Add(lblAccroche);
        imgBanniere.Controls.Add(lblDetail);
        imgBanniere.Controls.Add(btnNouvelleInscription);
        imgBanniere.Controls.Add(btnVoirStats);
        //
        // lblBonjour
        //
        lblBonjour.AutoSize = false;
        lblBonjour.Location = new Point(32, 10);
        lblBonjour.Size = new Size(700, 24);
        lblBonjour.Text = "Bonjour,";
        lblBonjour.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblBonjour.ForeColor = Color.FromArgb(255, 255, 255);
        lblBonjour.BackColor = Color.Transparent;
        lblBonjour.Name = "lblBonjour";
        lblBonjour.TabIndex = 24;
        //
        // lblAccroche
        //
        lblAccroche.AutoSize = false;
        lblAccroche.Location = new Point(32, 34);
        lblAccroche.Size = new Size(800, 40);
        lblAccroche.Text = "Pilotez votre université en un coup d’œil";
        lblAccroche.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Regular, GraphicsUnit.Point);
        lblAccroche.ForeColor = Color.FromArgb(255, 255, 255);
        lblAccroche.BackColor = Color.Transparent;
        lblAccroche.Name = "lblAccroche";
        lblAccroche.TabIndex = 25;
        //
        // lblDetail
        //
        lblDetail.AutoSize = false;
        lblDetail.Location = new Point(32, 76);
        lblDetail.Size = new Size(800, 22);
        lblDetail.Text = "";
        lblDetail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblDetail.ForeColor = Color.FromArgb(246, 213, 219);
        lblDetail.BackColor = Color.Transparent;
        lblDetail.Name = "lblDetail";
        lblDetail.TabIndex = 26;
        //
        // btnNouvelleInscription
        //
        btnNouvelleInscription.BackColor = Color.FromArgb(255, 255, 255);
        btnNouvelleInscription.ForeColor = Color.FromArgb(122, 20, 38);
        btnNouvelleInscription.Text = "Nouvelle inscription";
        btnNouvelleInscription.UseVisualStyleBackColor = false;
        btnNouvelleInscription.Location = new Point(32, 98);
        btnNouvelleInscription.Size = new Size(190, 32);
        btnNouvelleInscription.Name = "btnNouvelleInscription";
        btnNouvelleInscription.TabIndex = 27;
        //
        // btnVoirStats
        //
        btnVoirStats.BackColor = Color.FromArgb(94, 15, 30);
        btnVoirStats.ForeColor = Color.FromArgb(255, 255, 255);
        btnVoirStats.Text = "Voir les statistiques";
        btnVoirStats.UseVisualStyleBackColor = false;
        btnVoirStats.Location = new Point(232, 98);
        btnVoirStats.Size = new Size(190, 32);
        btnVoirStats.Name = "btnVoirStats";
        btnVoirStats.TabIndex = 28;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 29;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Vue d’ensemble de l’année académique";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 30;
        //
        // UcDashboard
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcDashboard";
        Controls.Add(tlpBas);
        Controls.Add(tlpKpi);
        Controls.Add(pnlBanniereZone);
        Controls.Add(pnlEntete);
        btnNouvelleInscription.Click += btnNouvelleInscription_Click;
        btnVoirStats.Click += btnVoirStats_Click;
        Load += UcDashboard_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSeances).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).EndInit();
        tlpBas.ResumeLayout(false);
        cardFiliere.ResumeLayout(false);
        cardStatuts.ResumeLayout(false);
        cardClasses.ResumeLayout(false);
        cardSeances.ResumeLayout(false);
        cardInscriptions.ResumeLayout(false);
        tlpKpi.ResumeLayout(false);
        pnlBanniereZone.ResumeLayout(false);
        imgBanniere.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private TableLayoutPanel tlpBas;
    private PanelArrondi cardFiliere;
    private GraphiqueBarres grFiliere;
    private Label lblTitre_cardFiliere;
    private PanelArrondi cardStatuts;
    private GraphiqueDonut grStatuts;
    private Label lblTitre_cardStatuts;
    private PanelArrondi cardClasses;
    private GraphiqueBarres grClasses;
    private Label lblTitre_cardClasses;
    private PanelArrondi cardSeances;
    private GrilleModerne dgvSeances;
    private Label lblTitre_cardSeances;
    private PanelArrondi cardInscriptions;
    private GrilleModerne dgvInscriptions;
    private Label lblTitre_cardInscriptions;
    private TableLayoutPanel tlpKpi;
    private CarteKpi carteInscrits;
    private CarteKpi carteAttente;
    private CarteKpi carteClasses;
    private CarteKpi carteSeances;
    private CarteKpi carteAbsences;
    private Panel pnlBanniereZone;
    private ImageCouverture imgBanniere;
    private Label lblBonjour;
    private Label lblAccroche;
    private Label lblDetail;
    private BoutonArrondi btnNouvelleInscription;
    private BoutonArrondi btnVoirStats;
    private Panel pnlEntete;
    private Label lblSousTitre;
    private DataGridViewTextBoxColumn colJour;
    private DataGridViewTextBoxColumn colHeure;
    private DataGridViewTextBoxColumn colMatiere;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colSalle;
    private DataGridViewTextBoxColumn colType;
    private DataGridViewTextBoxColumn colJ;
    private DataGridViewTextBoxColumn colEtud;
    private DataGridViewTextBoxColumn colCl;
    private DataGridViewTextBoxColumn colSt;
}
