using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcParametres
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tlpParametres = new TableLayoutPanel();
        cardApparence = new PanelArrondi();
        lblExpApparence = new Label();
        btnClair = new BoutonArrondi();
        btnSombre = new BoutonArrondi();
        lblTitre_cardApparence = new Label();
        cardEtablissement = new PanelArrondi();
        lblExpEtab = new Label();
        txtEtablissement = new TextBox();
        btnEnregistrerEtab = new BoutonArrondi();
        lblTitre_cardEtablissement = new Label();
        cardCompte = new PanelArrondi();
        lblNomCompte = new Label();
        lblEmailCompte = new Label();
        lblRoleCompte = new Label();
        btnMotDePasse = new BoutonArrondi();
        lblTitre_cardCompte = new Label();
        cardBase = new PanelArrondi();
        lblServeur = new Label();
        lblBase = new Label();
        lblEtat = new Label();
        btnTester = new BoutonArrondi();
        lblTitre_cardBase = new Label();
        cardApropos = new PanelArrondi();
        lblApropos = new Label();
        lblTitre_cardApropos = new Label();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        tlpParametres.SuspendLayout();
        cardApparence.SuspendLayout();
        cardEtablissement.SuspendLayout();
        cardCompte.SuspendLayout();
        cardBase.SuspendLayout();
        cardApropos.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // tlpParametres
        //
        tlpParametres.ColumnCount = 2;
        tlpParametres.RowCount = 3;
        tlpParametres.Dock = DockStyle.Fill;
        tlpParametres.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpParametres.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpParametres.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
        tlpParametres.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
        tlpParametres.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
        tlpParametres.Name = "tlpParametres";
        tlpParametres.TabIndex = 0;
        tlpParametres.Controls.Add(cardApparence, 0, 0);
        tlpParametres.Controls.Add(cardEtablissement, 1, 0);
        tlpParametres.Controls.Add(cardCompte, 0, 1);
        tlpParametres.Controls.Add(cardBase, 1, 1);
        tlpParametres.Controls.Add(cardApropos, 0, 2);
        tlpParametres.SetColumnSpan(cardApropos, 2);
        //
        // cardApparence
        //
        cardApparence.BackColor = Color.FromArgb(255, 255, 255);
        cardApparence.Rayon = 16;
        cardApparence.Dock = DockStyle.Fill;
        cardApparence.Tag = "carte";
        cardApparence.Padding = new Padding(14, 10, 14, 10);
        cardApparence.Margin = new Padding(6, 6, 6, 6);
        cardApparence.Name = "cardApparence";
        cardApparence.TabIndex = 1;
        cardApparence.Controls.Add(lblExpApparence);
        cardApparence.Controls.Add(btnClair);
        cardApparence.Controls.Add(btnSombre);
        cardApparence.Controls.Add(lblTitre_cardApparence);
        //
        // lblExpApparence
        //
        lblExpApparence.AutoSize = false;
        lblExpApparence.Location = new Point(6, 46);
        lblExpApparence.Size = new Size(420, 44);
        lblExpApparence.Text = "Choisissez l’apparence de l’application. Votre choix est conservé à la prochaine ouverture.";
        lblExpApparence.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblExpApparence.ForeColor = Color.FromArgb(107, 96, 99);
        lblExpApparence.Tag = "discret";
        lblExpApparence.Name = "lblExpApparence";
        lblExpApparence.TabIndex = 2;
        //
        // btnClair
        //
        btnClair.BackColor = Color.FromArgb(155, 27, 48);
        btnClair.ForeColor = Color.FromArgb(255, 255, 255);
        btnClair.Text = "Mode clair";
        btnClair.UseVisualStyleBackColor = false;
        btnClair.Location = new Point(6, 100);
        btnClair.Size = new Size(170, 44);
        btnClair.Name = "btnClair";
        btnClair.TabIndex = 3;
        //
        // btnSombre
        //
        btnSombre.BackColor = Color.FromArgb(239, 232, 234);
        btnSombre.ForeColor = Color.FromArgb(27, 20, 22);
        btnSombre.Text = "Mode sombre";
        btnSombre.UseVisualStyleBackColor = false;
        btnSombre.Location = new Point(190, 100);
        btnSombre.Size = new Size(170, 44);
        btnSombre.Tag = "secondaire";
        btnSombre.Name = "btnSombre";
        btnSombre.TabIndex = 4;
        //
        // lblTitre_cardApparence
        //
        lblTitre_cardApparence.AutoSize = false;
        lblTitre_cardApparence.Dock = DockStyle.Top;
        lblTitre_cardApparence.Text = "Apparence";
        lblTitre_cardApparence.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardApparence.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardApparence.Tag = "texte";
        lblTitre_cardApparence.Name = "lblTitre_cardApparence";
        lblTitre_cardApparence.TabIndex = 5;
        //
        // cardEtablissement
        //
        cardEtablissement.BackColor = Color.FromArgb(255, 255, 255);
        cardEtablissement.Rayon = 16;
        cardEtablissement.Dock = DockStyle.Fill;
        cardEtablissement.Tag = "carte";
        cardEtablissement.Padding = new Padding(14, 10, 14, 10);
        cardEtablissement.Margin = new Padding(6, 6, 6, 6);
        cardEtablissement.Name = "cardEtablissement";
        cardEtablissement.TabIndex = 6;
        cardEtablissement.Controls.Add(lblExpEtab);
        cardEtablissement.Controls.Add(txtEtablissement);
        cardEtablissement.Controls.Add(btnEnregistrerEtab);
        cardEtablissement.Controls.Add(lblTitre_cardEtablissement);
        //
        // lblExpEtab
        //
        lblExpEtab.AutoSize = false;
        lblExpEtab.Location = new Point(6, 46);
        lblExpEtab.Size = new Size(420, 40);
        lblExpEtab.Text = "Nom affiché dans l’en-tête des documents imprimés et des PDF.";
        lblExpEtab.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblExpEtab.ForeColor = Color.FromArgb(107, 96, 99);
        lblExpEtab.Tag = "discret";
        lblExpEtab.Name = "lblExpEtab";
        lblExpEtab.TabIndex = 7;
        //
        // txtEtablissement
        //
        txtEtablissement.BackColor = Color.FromArgb(255, 255, 255);
        txtEtablissement.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtEtablissement.Location = new Point(6, 92);
        txtEtablissement.Size = new Size(420, 28);
        txtEtablissement.Tag = "input";
        txtEtablissement.Name = "txtEtablissement";
        txtEtablissement.TabIndex = 8;
        //
        // btnEnregistrerEtab
        //
        btnEnregistrerEtab.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrerEtab.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrerEtab.Text = "Enregistrer";
        btnEnregistrerEtab.UseVisualStyleBackColor = false;
        btnEnregistrerEtab.Location = new Point(6, 134);
        btnEnregistrerEtab.Size = new Size(170, 44);
        btnEnregistrerEtab.Name = "btnEnregistrerEtab";
        btnEnregistrerEtab.TabIndex = 9;
        //
        // lblTitre_cardEtablissement
        //
        lblTitre_cardEtablissement.AutoSize = false;
        lblTitre_cardEtablissement.Dock = DockStyle.Top;
        lblTitre_cardEtablissement.Text = "Établissement";
        lblTitre_cardEtablissement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardEtablissement.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardEtablissement.Tag = "texte";
        lblTitre_cardEtablissement.Name = "lblTitre_cardEtablissement";
        lblTitre_cardEtablissement.TabIndex = 10;
        //
        // cardCompte
        //
        cardCompte.BackColor = Color.FromArgb(255, 255, 255);
        cardCompte.Rayon = 16;
        cardCompte.Dock = DockStyle.Fill;
        cardCompte.Tag = "carte";
        cardCompte.Padding = new Padding(14, 10, 14, 10);
        cardCompte.Margin = new Padding(6, 6, 6, 6);
        cardCompte.Name = "cardCompte";
        cardCompte.TabIndex = 11;
        cardCompte.Controls.Add(lblNomCompte);
        cardCompte.Controls.Add(lblEmailCompte);
        cardCompte.Controls.Add(lblRoleCompte);
        cardCompte.Controls.Add(btnMotDePasse);
        cardCompte.Controls.Add(lblTitre_cardCompte);
        //
        // lblNomCompte
        //
        lblNomCompte.AutoSize = false;
        lblNomCompte.Location = new Point(6, 46);
        lblNomCompte.Size = new Size(420, 26);
        lblNomCompte.Text = "";
        lblNomCompte.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblNomCompte.ForeColor = Color.FromArgb(27, 20, 22);
        lblNomCompte.Tag = "texte";
        lblNomCompte.Name = "lblNomCompte";
        lblNomCompte.TabIndex = 12;
        //
        // lblEmailCompte
        //
        lblEmailCompte.AutoSize = false;
        lblEmailCompte.Location = new Point(6, 74);
        lblEmailCompte.Size = new Size(420, 24);
        lblEmailCompte.Text = "";
        lblEmailCompte.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblEmailCompte.ForeColor = Color.FromArgb(107, 96, 99);
        lblEmailCompte.Tag = "discret";
        lblEmailCompte.Name = "lblEmailCompte";
        lblEmailCompte.TabIndex = 13;
        //
        // lblRoleCompte
        //
        lblRoleCompte.AutoSize = false;
        lblRoleCompte.Location = new Point(6, 98);
        lblRoleCompte.Size = new Size(420, 24);
        lblRoleCompte.Text = "";
        lblRoleCompte.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblRoleCompte.ForeColor = Color.FromArgb(107, 96, 99);
        lblRoleCompte.Tag = "discret";
        lblRoleCompte.Name = "lblRoleCompte";
        lblRoleCompte.TabIndex = 14;
        //
        // btnMotDePasse
        //
        btnMotDePasse.BackColor = Color.FromArgb(58, 47, 50);
        btnMotDePasse.ForeColor = Color.FromArgb(255, 255, 255);
        btnMotDePasse.Text = "Changer mon mot de passe";
        btnMotDePasse.UseVisualStyleBackColor = false;
        btnMotDePasse.Location = new Point(6, 134);
        btnMotDePasse.Size = new Size(250, 44);
        btnMotDePasse.Name = "btnMotDePasse";
        btnMotDePasse.TabIndex = 15;
        //
        // lblTitre_cardCompte
        //
        lblTitre_cardCompte.AutoSize = false;
        lblTitre_cardCompte.Dock = DockStyle.Top;
        lblTitre_cardCompte.Text = "Mon compte";
        lblTitre_cardCompte.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardCompte.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardCompte.Tag = "texte";
        lblTitre_cardCompte.Name = "lblTitre_cardCompte";
        lblTitre_cardCompte.TabIndex = 16;
        //
        // cardBase
        //
        cardBase.BackColor = Color.FromArgb(255, 255, 255);
        cardBase.Rayon = 16;
        cardBase.Dock = DockStyle.Fill;
        cardBase.Tag = "carte";
        cardBase.Padding = new Padding(14, 10, 14, 10);
        cardBase.Margin = new Padding(6, 6, 6, 6);
        cardBase.Name = "cardBase";
        cardBase.TabIndex = 17;
        cardBase.Controls.Add(lblServeur);
        cardBase.Controls.Add(lblBase);
        cardBase.Controls.Add(lblEtat);
        cardBase.Controls.Add(btnTester);
        cardBase.Controls.Add(lblTitre_cardBase);
        //
        // lblServeur
        //
        lblServeur.AutoSize = false;
        lblServeur.Location = new Point(6, 46);
        lblServeur.Size = new Size(420, 24);
        lblServeur.Text = "";
        lblServeur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblServeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblServeur.Tag = "texte";
        lblServeur.Name = "lblServeur";
        lblServeur.TabIndex = 18;
        //
        // lblBase
        //
        lblBase.AutoSize = false;
        lblBase.Location = new Point(6, 72);
        lblBase.Size = new Size(420, 24);
        lblBase.Text = "";
        lblBase.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblBase.ForeColor = Color.FromArgb(27, 20, 22);
        lblBase.Tag = "texte";
        lblBase.Name = "lblBase";
        lblBase.TabIndex = 19;
        //
        // lblEtat
        //
        lblEtat.AutoSize = false;
        lblEtat.Location = new Point(6, 98);
        lblEtat.Size = new Size(420, 32);
        lblEtat.Text = "";
        lblEtat.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblEtat.ForeColor = Color.FromArgb(107, 96, 99);
        lblEtat.Tag = "discret";
        lblEtat.Name = "lblEtat";
        lblEtat.TabIndex = 20;
        //
        // btnTester
        //
        btnTester.BackColor = Color.FromArgb(239, 232, 234);
        btnTester.ForeColor = Color.FromArgb(27, 20, 22);
        btnTester.Text = "Tester la connexion";
        btnTester.UseVisualStyleBackColor = false;
        btnTester.Location = new Point(6, 134);
        btnTester.Size = new Size(220, 44);
        btnTester.Tag = "secondaire";
        btnTester.Name = "btnTester";
        btnTester.TabIndex = 21;
        //
        // lblTitre_cardBase
        //
        lblTitre_cardBase.AutoSize = false;
        lblTitre_cardBase.Dock = DockStyle.Top;
        lblTitre_cardBase.Text = "Base de données";
        lblTitre_cardBase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardBase.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardBase.Tag = "texte";
        lblTitre_cardBase.Name = "lblTitre_cardBase";
        lblTitre_cardBase.TabIndex = 22;
        //
        // cardApropos
        //
        cardApropos.BackColor = Color.FromArgb(255, 255, 255);
        cardApropos.Rayon = 16;
        cardApropos.Dock = DockStyle.Fill;
        cardApropos.Tag = "carte";
        cardApropos.Padding = new Padding(14, 10, 14, 10);
        cardApropos.Margin = new Padding(6, 6, 6, 6);
        cardApropos.Name = "cardApropos";
        cardApropos.TabIndex = 23;
        cardApropos.Controls.Add(lblApropos);
        cardApropos.Controls.Add(lblTitre_cardApropos);
        //
        // lblApropos
        //
        lblApropos.AutoSize = false;
        lblApropos.Location = new Point(6, 46);
        lblApropos.Size = new Size(860, 52);
        lblApropos.Text = "Gestion universitaire : inscriptions, classes et cours, planification des séances, absences, statistiques, impression et export.\r\nApplication Windows Forms (.NET 8) reliée à SQL Server, développée dans le cadre du projet de Base de Données II.";
        lblApropos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblApropos.ForeColor = Color.FromArgb(107, 96, 99);
        lblApropos.Tag = "discret";
        lblApropos.Name = "lblApropos";
        lblApropos.TabIndex = 24;
        //
        // lblTitre_cardApropos
        //
        lblTitre_cardApropos.AutoSize = false;
        lblTitre_cardApropos.Dock = DockStyle.Top;
        lblTitre_cardApropos.Text = "À propos";
        lblTitre_cardApropos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre_cardApropos.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre_cardApropos.Tag = "texte";
        lblTitre_cardApropos.Name = "lblTitre_cardApropos";
        lblTitre_cardApropos.TabIndex = 25;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 26;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Apparence, établissement, compte et connexion";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 27;
        //
        // UcParametres
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        AutoScroll = true;
        Name = "UcParametres";
        Controls.Add(tlpParametres);
        Controls.Add(pnlEntete);
        btnClair.Click += btnClair_Click;
        btnSombre.Click += btnSombre_Click;
        btnEnregistrerEtab.Click += btnEnregistrerEtab_Click;
        btnMotDePasse.Click += btnMotDePasse_Click;
        btnTester.Click += btnTester_Click;
        Load += UcParametres_Load;
        tlpParametres.ResumeLayout(false);
        cardApparence.ResumeLayout(false);
        cardEtablissement.ResumeLayout(false);
        cardCompte.ResumeLayout(false);
        cardBase.ResumeLayout(false);
        cardApropos.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private TableLayoutPanel tlpParametres;
    private PanelArrondi cardApparence;
    private Label lblExpApparence;
    private BoutonArrondi btnClair;
    private BoutonArrondi btnSombre;
    private Label lblTitre_cardApparence;
    private PanelArrondi cardEtablissement;
    private Label lblExpEtab;
    private TextBox txtEtablissement;
    private BoutonArrondi btnEnregistrerEtab;
    private Label lblTitre_cardEtablissement;
    private PanelArrondi cardCompte;
    private Label lblNomCompte;
    private Label lblEmailCompte;
    private Label lblRoleCompte;
    private BoutonArrondi btnMotDePasse;
    private Label lblTitre_cardCompte;
    private PanelArrondi cardBase;
    private Label lblServeur;
    private Label lblBase;
    private Label lblEtat;
    private BoutonArrondi btnTester;
    private Label lblTitre_cardBase;
    private PanelArrondi cardApropos;
    private Label lblApropos;
    private Label lblTitre_cardApropos;
    private Panel pnlEntete;
    private Label lblSousTitre;
}
