using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcStatistiques
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlRapport = new Panel();
        tlpGraphiques = new TableLayoutPanel();
        cardFiliere = new PanelArrondi();
        grFiliere = new GraphiqueBarres();
        lblTitre_cardFiliere = new Label();
        cardNiveau = new PanelArrondi();
        grNiveau = new GraphiqueDonut();
        lblTitre_cardNiveau = new Label();
        cardStatuts = new PanelArrondi();
        grStatuts = new GraphiqueDonut();
        lblTitre_cardStatuts = new Label();
        cardClasses = new PanelArrondi();
        grClasses = new GraphiqueBarres();
        lblTitre_cardClasses = new Label();
        cardAbsences = new PanelArrondi();
        grAbsences = new GraphiqueBarres();
        lblTitre_cardAbsences = new Label();
        cardSexe = new PanelArrondi();
        grSexe = new GraphiqueDonut();
        lblTitre_cardSexe = new Label();
        tlpKpi = new TableLayoutPanel();
        carteValidees = new CarteKpi();
        carteTaux = new CarteKpi();
        carteFrais = new CarteKpi();
        carteSeancesPlan = new CarteKpi();
        pnlOutils = new Panel();
        flpBoutons = new FlowLayoutPanel();
        btnActualiser = new BoutonArrondi();
        btnPdf = new BoutonArrondi();
        btnImprimer = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        pnlRapport.SuspendLayout();
        tlpGraphiques.SuspendLayout();
        cardFiliere.SuspendLayout();
        cardNiveau.SuspendLayout();
        cardStatuts.SuspendLayout();
        cardClasses.SuspendLayout();
        cardAbsences.SuspendLayout();
        cardSexe.SuspendLayout();
        tlpKpi.SuspendLayout();
        pnlOutils.SuspendLayout();
        flpBoutons.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // pnlRapport
        //
        pnlRapport.Dock = DockStyle.Fill;
        pnlRapport.Tag = "fond";
        pnlRapport.BackColor = Color.FromArgb(246, 243, 242);
        pnlRapport.Name = "pnlRapport";
        pnlRapport.TabIndex = 0;
        pnlRapport.Controls.Add(tlpGraphiques);
        pnlRapport.Controls.Add(tlpKpi);
        //
        // tlpGraphiques
        //
        tlpGraphiques.ColumnCount = 3;
        tlpGraphiques.RowCount = 2;
        tlpGraphiques.Dock = DockStyle.Fill;
        tlpGraphiques.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpGraphiques.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        tlpGraphiques.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        tlpGraphiques.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpGraphiques.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpGraphiques.Name = "tlpGraphiques";
        tlpGraphiques.TabIndex = 1;
        tlpGraphiques.Controls.Add(cardFiliere, 0, 0);
        tlpGraphiques.Controls.Add(cardNiveau, 1, 0);
        tlpGraphiques.Controls.Add(cardStatuts, 2, 0);
        tlpGraphiques.Controls.Add(cardClasses, 0, 1);
        tlpGraphiques.Controls.Add(cardAbsences, 1, 1);
        tlpGraphiques.Controls.Add(cardSexe, 2, 1);
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
        cardFiliere.TabIndex = 2;
        cardFiliere.Controls.Add(grFiliere);
        cardFiliere.Controls.Add(lblTitre_cardFiliere);
        //
        // grFiliere
        //
        grFiliere.BackColor = Color.FromArgb(255, 255, 255);
        grFiliere.Dock = DockStyle.Fill;
        grFiliere.Tag = "carte";
        grFiliere.Name = "grFiliere";
        grFiliere.TabIndex = 3;
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
        lblTitre_cardFiliere.TabIndex = 4;
        //
        // cardNiveau
        //
        cardNiveau.BackColor = Color.FromArgb(255, 255, 255);
        cardNiveau.Rayon = 16;
        cardNiveau.Dock = DockStyle.Fill;
        cardNiveau.Tag = "carte";
        cardNiveau.Padding = new Padding(18, 12, 18, 12);
        cardNiveau.Margin = new Padding(8, 8, 8, 8);
        cardNiveau.Name = "cardNiveau";
        cardNiveau.TabIndex = 5;
        cardNiveau.Controls.Add(grNiveau);
        cardNiveau.Controls.Add(lblTitre_cardNiveau);
        //
        // grNiveau
        //
        grNiveau.BackColor = Color.FromArgb(255, 255, 255);
        grNiveau.Dock = DockStyle.Fill;
        grNiveau.Tag = "carte";
        grNiveau.Name = "grNiveau";
        grNiveau.TabIndex = 6;
        //
        // lblTitre_cardNiveau
        //
        lblTitre_cardNiveau.AutoSize = false;
        lblTitre_cardNiveau.Dock = DockStyle.Top;
        lblTitre_cardNiveau.Text = "Répartition par niveau";
        lblTitre_cardNiveau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardNiveau.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardNiveau.Tag = "texte";
        lblTitre_cardNiveau.Name = "lblTitre_cardNiveau";
        lblTitre_cardNiveau.TabIndex = 7;
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
        cardStatuts.TabIndex = 8;
        cardStatuts.Controls.Add(grStatuts);
        cardStatuts.Controls.Add(lblTitre_cardStatuts);
        //
        // grStatuts
        //
        grStatuts.BackColor = Color.FromArgb(255, 255, 255);
        grStatuts.Dock = DockStyle.Fill;
        grStatuts.Tag = "carte";
        grStatuts.Name = "grStatuts";
        grStatuts.TabIndex = 9;
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
        lblTitre_cardStatuts.TabIndex = 10;
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
        cardClasses.TabIndex = 11;
        cardClasses.Controls.Add(grClasses);
        cardClasses.Controls.Add(lblTitre_cardClasses);
        //
        // grClasses
        //
        grClasses.BackColor = Color.FromArgb(255, 255, 255);
        grClasses.Dock = DockStyle.Fill;
        grClasses.Tag = "carte";
        grClasses.Name = "grClasses";
        grClasses.TabIndex = 12;
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
        lblTitre_cardClasses.TabIndex = 13;
        //
        // cardAbsences
        //
        cardAbsences.BackColor = Color.FromArgb(255, 255, 255);
        cardAbsences.Rayon = 16;
        cardAbsences.Dock = DockStyle.Fill;
        cardAbsences.Tag = "carte";
        cardAbsences.Padding = new Padding(18, 12, 18, 12);
        cardAbsences.Margin = new Padding(8, 8, 8, 8);
        cardAbsences.Name = "cardAbsences";
        cardAbsences.TabIndex = 14;
        cardAbsences.Controls.Add(grAbsences);
        cardAbsences.Controls.Add(lblTitre_cardAbsences);
        //
        // grAbsences
        //
        grAbsences.BackColor = Color.FromArgb(255, 255, 255);
        grAbsences.Dock = DockStyle.Fill;
        grAbsences.Tag = "carte";
        grAbsences.Name = "grAbsences";
        grAbsences.TabIndex = 15;
        //
        // lblTitre_cardAbsences
        //
        lblTitre_cardAbsences.AutoSize = false;
        lblTitre_cardAbsences.Dock = DockStyle.Top;
        lblTitre_cardAbsences.Text = "Absences par matière";
        lblTitre_cardAbsences.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardAbsences.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardAbsences.Tag = "texte";
        lblTitre_cardAbsences.Name = "lblTitre_cardAbsences";
        lblTitre_cardAbsences.TabIndex = 16;
        //
        // cardSexe
        //
        cardSexe.BackColor = Color.FromArgb(255, 255, 255);
        cardSexe.Rayon = 16;
        cardSexe.Dock = DockStyle.Fill;
        cardSexe.Tag = "carte";
        cardSexe.Padding = new Padding(18, 12, 18, 12);
        cardSexe.Margin = new Padding(8, 8, 8, 8);
        cardSexe.Name = "cardSexe";
        cardSexe.TabIndex = 17;
        cardSexe.Controls.Add(grSexe);
        cardSexe.Controls.Add(lblTitre_cardSexe);
        //
        // grSexe
        //
        grSexe.BackColor = Color.FromArgb(255, 255, 255);
        grSexe.Dock = DockStyle.Fill;
        grSexe.Tag = "carte";
        grSexe.Name = "grSexe";
        grSexe.TabIndex = 18;
        //
        // lblTitre_cardSexe
        //
        lblTitre_cardSexe.AutoSize = false;
        lblTitre_cardSexe.Dock = DockStyle.Top;
        lblTitre_cardSexe.Text = "Femmes / hommes";
        lblTitre_cardSexe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardSexe.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardSexe.Tag = "texte";
        lblTitre_cardSexe.Name = "lblTitre_cardSexe";
        lblTitre_cardSexe.TabIndex = 19;
        //
        // tlpKpi
        //
        tlpKpi.ColumnCount = 4;
        tlpKpi.RowCount = 1;
        tlpKpi.Dock = DockStyle.Top;
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpKpi.Size = new Size(100, 108);
        tlpKpi.Name = "tlpKpi";
        tlpKpi.TabIndex = 20;
        tlpKpi.Controls.Add(carteValidees, 0, 0);
        tlpKpi.Controls.Add(carteTaux, 1, 0);
        tlpKpi.Controls.Add(carteFrais, 2, 0);
        tlpKpi.Controls.Add(carteSeancesPlan, 3, 0);
        //
        // carteValidees
        //
        carteValidees.Dock = DockStyle.Fill;
        carteValidees.Icone = 0xf19d;
        carteValidees.Margin = new Padding(8, 8, 8, 8);
        carteValidees.Teinte = Color.FromArgb(155, 27, 48);
        carteValidees.Titre = "Inscriptions validées";
        carteValidees.Valeur = "0";
        carteValidees.Name = "carteValidees";
        carteValidees.TabIndex = 21;
        //
        // carteTaux
        //
        carteTaux.Dock = DockStyle.Fill;
        carteTaux.Icone = 0xf201;
        carteTaux.Margin = new Padding(8, 8, 8, 8);
        carteTaux.Teinte = Color.FromArgb(30, 107, 58);
        carteTaux.Titre = "Taux de validation";
        carteTaux.Valeur = "0 %";
        carteTaux.Name = "carteTaux";
        carteTaux.TabIndex = 22;
        //
        // carteFrais
        //
        carteFrais.Dock = DockStyle.Fill;
        carteFrais.Icone = 0xf0d6;
        carteFrais.Margin = new Padding(8, 8, 8, 8);
        carteFrais.Teinte = Color.FromArgb(180, 83, 9);
        carteFrais.Titre = "Frais encaissés";
        carteFrais.Valeur = "0";
        carteFrais.Name = "carteFrais";
        carteFrais.TabIndex = 23;
        //
        // carteSeancesPlan
        //
        carteSeancesPlan.Dock = DockStyle.Fill;
        carteSeancesPlan.Icone = 0xf073;
        carteSeancesPlan.Margin = new Padding(8, 8, 8, 8);
        carteSeancesPlan.Teinte = Color.FromArgb(74, 85, 104);
        carteSeancesPlan.Titre = "Séances planifiées";
        carteSeancesPlan.Valeur = "0";
        carteSeancesPlan.Name = "carteSeancesPlan";
        carteSeancesPlan.TabIndex = 24;
        //
        // pnlOutils
        //
        pnlOutils.Dock = DockStyle.Top;
        pnlOutils.Size = new Size(100, 56);
        pnlOutils.Name = "pnlOutils";
        pnlOutils.TabIndex = 25;
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
        flpBoutons.TabIndex = 26;
        flpBoutons.Controls.Add(btnActualiser);
        flpBoutons.Controls.Add(btnPdf);
        flpBoutons.Controls.Add(btnImprimer);
        //
        // btnActualiser
        //
        btnActualiser.BackColor = Color.FromArgb(239, 232, 234);
        btnActualiser.ForeColor = Color.FromArgb(27, 20, 22);
        btnActualiser.Text = "Actualiser";
        btnActualiser.UseVisualStyleBackColor = false;
        btnActualiser.Location = new Point(0, 0);
        btnActualiser.Size = new Size(100, 40);
        btnActualiser.Tag = "secondaire";
        btnActualiser.Margin = new Padding(8, 8, 0, 8);
        btnActualiser.Name = "btnActualiser";
        btnActualiser.TabIndex = 27;
        //
        // btnPdf
        //
        btnPdf.BackColor = Color.FromArgb(239, 232, 234);
        btnPdf.ForeColor = Color.FromArgb(27, 20, 22);
        btnPdf.Text = "Enregistrer en PDF";
        btnPdf.UseVisualStyleBackColor = false;
        btnPdf.Location = new Point(0, 0);
        btnPdf.Size = new Size(160, 40);
        btnPdf.Tag = "secondaire";
        btnPdf.Margin = new Padding(8, 8, 0, 8);
        btnPdf.Name = "btnPdf";
        btnPdf.TabIndex = 28;
        //
        // btnImprimer
        //
        btnImprimer.BackColor = Color.FromArgb(155, 27, 48);
        btnImprimer.ForeColor = Color.FromArgb(255, 255, 255);
        btnImprimer.Text = "Imprimer";
        btnImprimer.UseVisualStyleBackColor = false;
        btnImprimer.Location = new Point(0, 0);
        btnImprimer.Size = new Size(110, 40);
        btnImprimer.Margin = new Padding(8, 8, 0, 8);
        btnImprimer.Name = "btnImprimer";
        btnImprimer.TabIndex = 29;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 30;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Indicateurs de l’année académique en cours";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 31;
        //
        // UcStatistiques
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcStatistiques";
        Controls.Add(pnlRapport);
        Controls.Add(pnlOutils);
        Controls.Add(pnlEntete);
        btnActualiser.Click += btnActualiser_Click;
        btnPdf.Click += btnPdf_Click;
        btnImprimer.Click += btnImprimer_Click;
        Load += UcStatistiques_Load;
        pnlRapport.ResumeLayout(false);
        tlpGraphiques.ResumeLayout(false);
        cardFiliere.ResumeLayout(false);
        cardNiveau.ResumeLayout(false);
        cardStatuts.ResumeLayout(false);
        cardClasses.ResumeLayout(false);
        cardAbsences.ResumeLayout(false);
        cardSexe.ResumeLayout(false);
        tlpKpi.ResumeLayout(false);
        pnlOutils.ResumeLayout(false);
        flpBoutons.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel pnlRapport;
    private TableLayoutPanel tlpGraphiques;
    private PanelArrondi cardFiliere;
    private GraphiqueBarres grFiliere;
    private Label lblTitre_cardFiliere;
    private PanelArrondi cardNiveau;
    private GraphiqueDonut grNiveau;
    private Label lblTitre_cardNiveau;
    private PanelArrondi cardStatuts;
    private GraphiqueDonut grStatuts;
    private Label lblTitre_cardStatuts;
    private PanelArrondi cardClasses;
    private GraphiqueBarres grClasses;
    private Label lblTitre_cardClasses;
    private PanelArrondi cardAbsences;
    private GraphiqueBarres grAbsences;
    private Label lblTitre_cardAbsences;
    private PanelArrondi cardSexe;
    private GraphiqueDonut grSexe;
    private Label lblTitre_cardSexe;
    private TableLayoutPanel tlpKpi;
    private CarteKpi carteValidees;
    private CarteKpi carteTaux;
    private CarteKpi carteFrais;
    private CarteKpi carteSeancesPlan;
    private Panel pnlOutils;
    private FlowLayoutPanel flpBoutons;
    private BoutonArrondi btnActualiser;
    private BoutonArrondi btnPdf;
    private BoutonArrondi btnImprimer;
    private Panel pnlEntete;
    private Label lblSousTitre;
}
