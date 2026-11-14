using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcStructure
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tlpStructure = new TableLayoutPanel();
        cardFiliere = new PanelArrondi();
        dgvFilieres = new GrilleModerne();
        pnlBoutonsFiliere = new Panel();
        tlpBoutonsFiliere = new TableLayoutPanel();
        btnAjouterFiliere = new BoutonArrondi();
        btnModifierFiliere = new BoutonArrondi();
        btnSupprimerFiliere = new BoutonArrondi();
        lblTitreFiliere = new Label();
        cardNiveau = new PanelArrondi();
        dgvNiveaux = new GrilleModerne();
        pnlBoutonsNiveau = new Panel();
        tlpBoutonsNiveau = new TableLayoutPanel();
        btnAjouterNiveau = new BoutonArrondi();
        btnModifierNiveau = new BoutonArrondi();
        btnSupprimerNiveau = new BoutonArrondi();
        lblTitreNiveau = new Label();
        cardAnnee = new PanelArrondi();
        dgvAnnees = new GrilleModerne();
        pnlBoutonsAnnee = new Panel();
        tlpBoutonsAnnee = new TableLayoutPanel();
        btnAjouterAnnee = new BoutonArrondi();
        btnModifierAnnee = new BoutonArrondi();
        btnSupprimerAnnee = new BoutonArrondi();
        lblTitreAnnee = new Label();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        colIdF = new DataGridViewTextBoxColumn();
        colCodeF = new DataGridViewTextBoxColumn();
        colLibF = new DataGridViewTextBoxColumn();
        colIdN = new DataGridViewTextBoxColumn();
        colCodeN = new DataGridViewTextBoxColumn();
        colLibN = new DataGridViewTextBoxColumn();
        colIdA = new DataGridViewTextBoxColumn();
        colLibA = new DataGridViewTextBoxColumn();
        colDebA = new DataGridViewTextBoxColumn();
        colFinA = new DataGridViewTextBoxColumn();
        colActA = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvFilieres).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvNiveaux).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvAnnees).BeginInit();
        tlpStructure.SuspendLayout();
        cardFiliere.SuspendLayout();
        pnlBoutonsFiliere.SuspendLayout();
        tlpBoutonsFiliere.SuspendLayout();
        cardNiveau.SuspendLayout();
        pnlBoutonsNiveau.SuspendLayout();
        tlpBoutonsNiveau.SuspendLayout();
        cardAnnee.SuspendLayout();
        pnlBoutonsAnnee.SuspendLayout();
        tlpBoutonsAnnee.SuspendLayout();
        pnlEntete.SuspendLayout();
        SuspendLayout();
        //
        // tlpStructure
        //
        tlpStructure.ColumnCount = 2;
        tlpStructure.RowCount = 2;
        tlpStructure.Dock = DockStyle.Fill;
        tlpStructure.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpStructure.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpStructure.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpStructure.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tlpStructure.Name = "tlpStructure";
        tlpStructure.TabIndex = 0;
        tlpStructure.Controls.Add(cardFiliere, 0, 0);
        tlpStructure.Controls.Add(cardNiveau, 1, 0);
        tlpStructure.Controls.Add(cardAnnee, 0, 1);
        tlpStructure.SetColumnSpan(cardAnnee, 2);
        //
        // cardFiliere
        //
        cardFiliere.BackColor = Color.FromArgb(255, 255, 255);
        cardFiliere.Rayon = 16;
        cardFiliere.Dock = DockStyle.Fill;
        cardFiliere.Tag = "carte";
        cardFiliere.Padding = new Padding(8, 8, 8, 4);
        cardFiliere.Margin = new Padding(6, 6, 6, 6);
        cardFiliere.Name = "cardFiliere";
        cardFiliere.TabIndex = 1;
        cardFiliere.Controls.Add(dgvFilieres);
        cardFiliere.Controls.Add(pnlBoutonsFiliere);
        cardFiliere.Controls.Add(lblTitreFiliere);
        //
        // dgvFilieres
        //
        dgvFilieres.AutoGenerateColumns = false;
        dgvFilieres.Dock = DockStyle.Fill;
        dgvFilieres.Columns.AddRange(new DataGridViewColumn[] { colIdF, colCodeF, colLibF });
        dgvFilieres.Name = "dgvFilieres";
        dgvFilieres.TabIndex = 2;
        //
        // colIdF
        //
        colIdF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colIdF.FillWeight = 100F;
        colIdF.DataPropertyName = "idFiliere";
        colIdF.HeaderText = "Id";
        colIdF.Name = "colIdF";
        colIdF.ReadOnly = true;
        colIdF.Visible = false;
        //
        // colCodeF
        //
        colCodeF.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colCodeF.Width = 90;
        colCodeF.DataPropertyName = "codeFiliere";
        colCodeF.HeaderText = "Code";
        colCodeF.Name = "colCodeF";
        colCodeF.ReadOnly = true;
        //
        // colLibF
        //
        colLibF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colLibF.FillWeight = 100F;
        colLibF.DataPropertyName = "libelle";
        colLibF.HeaderText = "Libellé";
        colLibF.Name = "colLibF";
        colLibF.ReadOnly = true;
        //
        // pnlBoutonsFiliere
        //
        pnlBoutonsFiliere.Dock = DockStyle.Bottom;
        pnlBoutonsFiliere.Size = new Size(100, 58);
        pnlBoutonsFiliere.Name = "pnlBoutonsFiliere";
        pnlBoutonsFiliere.TabIndex = 3;
        pnlBoutonsFiliere.Controls.Add(tlpBoutonsFiliere);
        //
        // tlpBoutonsFiliere
        //
        tlpBoutonsFiliere.ColumnCount = 3;
        tlpBoutonsFiliere.RowCount = 1;
        tlpBoutonsFiliere.Dock = DockStyle.Fill;
        tlpBoutonsFiliere.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        tlpBoutonsFiliere.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsFiliere.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsFiliere.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBoutonsFiliere.Name = "tlpBoutonsFiliere";
        tlpBoutonsFiliere.TabIndex = 4;
        tlpBoutonsFiliere.Controls.Add(btnAjouterFiliere, 0, 0);
        tlpBoutonsFiliere.Controls.Add(btnModifierFiliere, 1, 0);
        tlpBoutonsFiliere.Controls.Add(btnSupprimerFiliere, 2, 0);
        //
        // btnAjouterFiliere
        //
        btnAjouterFiliere.BackColor = Color.FromArgb(155, 27, 48);
        btnAjouterFiliere.ForeColor = Color.FromArgb(255, 255, 255);
        btnAjouterFiliere.Text = "Ajouter";
        btnAjouterFiliere.UseVisualStyleBackColor = false;
        btnAjouterFiliere.Dock = DockStyle.Fill;
        btnAjouterFiliere.Margin = new Padding(0, 8, 4, 4);
        btnAjouterFiliere.Name = "btnAjouterFiliere";
        btnAjouterFiliere.TabIndex = 5;
        //
        // btnModifierFiliere
        //
        btnModifierFiliere.BackColor = Color.FromArgb(58, 47, 50);
        btnModifierFiliere.ForeColor = Color.FromArgb(255, 255, 255);
        btnModifierFiliere.Text = "Modifier";
        btnModifierFiliere.UseVisualStyleBackColor = false;
        btnModifierFiliere.Dock = DockStyle.Fill;
        btnModifierFiliere.Margin = new Padding(4, 8, 4, 4);
        btnModifierFiliere.Name = "btnModifierFiliere";
        btnModifierFiliere.TabIndex = 6;
        //
        // btnSupprimerFiliere
        //
        btnSupprimerFiliere.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimerFiliere.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimerFiliere.Text = "Supprimer";
        btnSupprimerFiliere.UseVisualStyleBackColor = false;
        btnSupprimerFiliere.Dock = DockStyle.Fill;
        btnSupprimerFiliere.Margin = new Padding(4, 8, 0, 4);
        btnSupprimerFiliere.Name = "btnSupprimerFiliere";
        btnSupprimerFiliere.TabIndex = 7;
        //
        // lblTitreFiliere
        //
        lblTitreFiliere.AutoSize = false;
        lblTitreFiliere.Dock = DockStyle.Top;
        lblTitreFiliere.Text = "Filières";
        lblTitreFiliere.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiliere.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiliere.Tag = "texte";
        lblTitreFiliere.Name = "lblTitreFiliere";
        lblTitreFiliere.TabIndex = 8;
        //
        // cardNiveau
        //
        cardNiveau.BackColor = Color.FromArgb(255, 255, 255);
        cardNiveau.Rayon = 16;
        cardNiveau.Dock = DockStyle.Fill;
        cardNiveau.Tag = "carte";
        cardNiveau.Padding = new Padding(8, 8, 8, 4);
        cardNiveau.Margin = new Padding(6, 6, 6, 6);
        cardNiveau.Name = "cardNiveau";
        cardNiveau.TabIndex = 9;
        cardNiveau.Controls.Add(dgvNiveaux);
        cardNiveau.Controls.Add(pnlBoutonsNiveau);
        cardNiveau.Controls.Add(lblTitreNiveau);
        //
        // dgvNiveaux
        //
        dgvNiveaux.AutoGenerateColumns = false;
        dgvNiveaux.Dock = DockStyle.Fill;
        dgvNiveaux.Columns.AddRange(new DataGridViewColumn[] { colIdN, colCodeN, colLibN });
        dgvNiveaux.Name = "dgvNiveaux";
        dgvNiveaux.TabIndex = 10;
        //
        // colIdN
        //
        colIdN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colIdN.FillWeight = 100F;
        colIdN.DataPropertyName = "idNiveau";
        colIdN.HeaderText = "Id";
        colIdN.Name = "colIdN";
        colIdN.ReadOnly = true;
        colIdN.Visible = false;
        //
        // colCodeN
        //
        colCodeN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colCodeN.Width = 90;
        colCodeN.DataPropertyName = "codeNiveau";
        colCodeN.HeaderText = "Code";
        colCodeN.Name = "colCodeN";
        colCodeN.ReadOnly = true;
        //
        // colLibN
        //
        colLibN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colLibN.FillWeight = 100F;
        colLibN.DataPropertyName = "libelle";
        colLibN.HeaderText = "Libellé";
        colLibN.Name = "colLibN";
        colLibN.ReadOnly = true;
        //
        // pnlBoutonsNiveau
        //
        pnlBoutonsNiveau.Dock = DockStyle.Bottom;
        pnlBoutonsNiveau.Size = new Size(100, 58);
        pnlBoutonsNiveau.Name = "pnlBoutonsNiveau";
        pnlBoutonsNiveau.TabIndex = 11;
        pnlBoutonsNiveau.Controls.Add(tlpBoutonsNiveau);
        //
        // tlpBoutonsNiveau
        //
        tlpBoutonsNiveau.ColumnCount = 3;
        tlpBoutonsNiveau.RowCount = 1;
        tlpBoutonsNiveau.Dock = DockStyle.Fill;
        tlpBoutonsNiveau.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        tlpBoutonsNiveau.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsNiveau.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsNiveau.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBoutonsNiveau.Name = "tlpBoutonsNiveau";
        tlpBoutonsNiveau.TabIndex = 12;
        tlpBoutonsNiveau.Controls.Add(btnAjouterNiveau, 0, 0);
        tlpBoutonsNiveau.Controls.Add(btnModifierNiveau, 1, 0);
        tlpBoutonsNiveau.Controls.Add(btnSupprimerNiveau, 2, 0);
        //
        // btnAjouterNiveau
        //
        btnAjouterNiveau.BackColor = Color.FromArgb(155, 27, 48);
        btnAjouterNiveau.ForeColor = Color.FromArgb(255, 255, 255);
        btnAjouterNiveau.Text = "Ajouter";
        btnAjouterNiveau.UseVisualStyleBackColor = false;
        btnAjouterNiveau.Dock = DockStyle.Fill;
        btnAjouterNiveau.Margin = new Padding(0, 8, 4, 4);
        btnAjouterNiveau.Name = "btnAjouterNiveau";
        btnAjouterNiveau.TabIndex = 13;
        //
        // btnModifierNiveau
        //
        btnModifierNiveau.BackColor = Color.FromArgb(58, 47, 50);
        btnModifierNiveau.ForeColor = Color.FromArgb(255, 255, 255);
        btnModifierNiveau.Text = "Modifier";
        btnModifierNiveau.UseVisualStyleBackColor = false;
        btnModifierNiveau.Dock = DockStyle.Fill;
        btnModifierNiveau.Margin = new Padding(4, 8, 4, 4);
        btnModifierNiveau.Name = "btnModifierNiveau";
        btnModifierNiveau.TabIndex = 14;
        //
        // btnSupprimerNiveau
        //
        btnSupprimerNiveau.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimerNiveau.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimerNiveau.Text = "Supprimer";
        btnSupprimerNiveau.UseVisualStyleBackColor = false;
        btnSupprimerNiveau.Dock = DockStyle.Fill;
        btnSupprimerNiveau.Margin = new Padding(4, 8, 0, 4);
        btnSupprimerNiveau.Name = "btnSupprimerNiveau";
        btnSupprimerNiveau.TabIndex = 15;
        //
        // lblTitreNiveau
        //
        lblTitreNiveau.AutoSize = false;
        lblTitreNiveau.Dock = DockStyle.Top;
        lblTitreNiveau.Text = "Niveaux";
        lblTitreNiveau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreNiveau.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreNiveau.Tag = "texte";
        lblTitreNiveau.Name = "lblTitreNiveau";
        lblTitreNiveau.TabIndex = 16;
        //
        // cardAnnee
        //
        cardAnnee.BackColor = Color.FromArgb(255, 255, 255);
        cardAnnee.Rayon = 16;
        cardAnnee.Dock = DockStyle.Fill;
        cardAnnee.Tag = "carte";
        cardAnnee.Padding = new Padding(8, 8, 8, 4);
        cardAnnee.Margin = new Padding(6, 6, 6, 6);
        cardAnnee.Name = "cardAnnee";
        cardAnnee.TabIndex = 17;
        cardAnnee.Controls.Add(dgvAnnees);
        cardAnnee.Controls.Add(pnlBoutonsAnnee);
        cardAnnee.Controls.Add(lblTitreAnnee);
        //
        // dgvAnnees
        //
        dgvAnnees.AutoGenerateColumns = false;
        dgvAnnees.Dock = DockStyle.Fill;
        dgvAnnees.Columns.AddRange(new DataGridViewColumn[] { colIdA, colLibA, colDebA, colFinA, colActA });
        dgvAnnees.Name = "dgvAnnees";
        dgvAnnees.TabIndex = 18;
        //
        // colIdA
        //
        colIdA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colIdA.FillWeight = 100F;
        colIdA.DataPropertyName = "idAnnee";
        colIdA.HeaderText = "Id";
        colIdA.Name = "colIdA";
        colIdA.ReadOnly = true;
        colIdA.Visible = false;
        //
        // colLibA
        //
        colLibA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colLibA.Width = 130;
        colLibA.DataPropertyName = "libelle";
        colLibA.HeaderText = "Année";
        colLibA.Name = "colLibA";
        colLibA.ReadOnly = true;
        //
        // colDebA
        //
        colDebA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colDebA.Width = 120;
        colDebA.DataPropertyName = "debut";
        colDebA.HeaderText = "Début";
        colDebA.Name = "colDebA";
        colDebA.ReadOnly = true;
        //
        // colFinA
        //
        colFinA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colFinA.Width = 120;
        colFinA.DataPropertyName = "fin";
        colFinA.HeaderText = "Fin";
        colFinA.Name = "colFinA";
        colFinA.ReadOnly = true;
        //
        // colActA
        //
        colActA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colActA.FillWeight = 60F;
        colActA.DataPropertyName = "active";
        colActA.HeaderText = "Active";
        colActA.Name = "colActA";
        colActA.ReadOnly = true;
        //
        // pnlBoutonsAnnee
        //
        pnlBoutonsAnnee.Dock = DockStyle.Bottom;
        pnlBoutonsAnnee.Size = new Size(100, 58);
        pnlBoutonsAnnee.Name = "pnlBoutonsAnnee";
        pnlBoutonsAnnee.TabIndex = 19;
        pnlBoutonsAnnee.Controls.Add(tlpBoutonsAnnee);
        //
        // tlpBoutonsAnnee
        //
        tlpBoutonsAnnee.ColumnCount = 3;
        tlpBoutonsAnnee.RowCount = 1;
        tlpBoutonsAnnee.Dock = DockStyle.Fill;
        tlpBoutonsAnnee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        tlpBoutonsAnnee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsAnnee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tlpBoutonsAnnee.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBoutonsAnnee.Name = "tlpBoutonsAnnee";
        tlpBoutonsAnnee.TabIndex = 20;
        tlpBoutonsAnnee.Controls.Add(btnAjouterAnnee, 0, 0);
        tlpBoutonsAnnee.Controls.Add(btnModifierAnnee, 1, 0);
        tlpBoutonsAnnee.Controls.Add(btnSupprimerAnnee, 2, 0);
        //
        // btnAjouterAnnee
        //
        btnAjouterAnnee.BackColor = Color.FromArgb(155, 27, 48);
        btnAjouterAnnee.ForeColor = Color.FromArgb(255, 255, 255);
        btnAjouterAnnee.Text = "Ajouter";
        btnAjouterAnnee.UseVisualStyleBackColor = false;
        btnAjouterAnnee.Dock = DockStyle.Fill;
        btnAjouterAnnee.Margin = new Padding(0, 8, 4, 4);
        btnAjouterAnnee.Name = "btnAjouterAnnee";
        btnAjouterAnnee.TabIndex = 21;
        //
        // btnModifierAnnee
        //
        btnModifierAnnee.BackColor = Color.FromArgb(58, 47, 50);
        btnModifierAnnee.ForeColor = Color.FromArgb(255, 255, 255);
        btnModifierAnnee.Text = "Modifier";
        btnModifierAnnee.UseVisualStyleBackColor = false;
        btnModifierAnnee.Dock = DockStyle.Fill;
        btnModifierAnnee.Margin = new Padding(4, 8, 4, 4);
        btnModifierAnnee.Name = "btnModifierAnnee";
        btnModifierAnnee.TabIndex = 22;
        //
        // btnSupprimerAnnee
        //
        btnSupprimerAnnee.BackColor = Color.FromArgb(179, 38, 30);
        btnSupprimerAnnee.ForeColor = Color.FromArgb(255, 255, 255);
        btnSupprimerAnnee.Text = "Supprimer";
        btnSupprimerAnnee.UseVisualStyleBackColor = false;
        btnSupprimerAnnee.Dock = DockStyle.Fill;
        btnSupprimerAnnee.Margin = new Padding(4, 8, 0, 4);
        btnSupprimerAnnee.Name = "btnSupprimerAnnee";
        btnSupprimerAnnee.TabIndex = 23;
        //
        // lblTitreAnnee
        //
        lblTitreAnnee.AutoSize = false;
        lblTitreAnnee.Dock = DockStyle.Top;
        lblTitreAnnee.Text = "Années académiques";
        lblTitreAnnee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreAnnee.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreAnnee.Tag = "texte";
        lblTitreAnnee.Name = "lblTitreAnnee";
        lblTitreAnnee.TabIndex = 24;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 25;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Filières, niveaux et années académiques";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 26;
        //
        // UcStructure
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcStructure";
        Controls.Add(tlpStructure);
        Controls.Add(pnlEntete);
        btnAjouterFiliere.Click += btnAjouterFiliere_Click;
        btnModifierFiliere.Click += btnModifierFiliere_Click;
        btnSupprimerFiliere.Click += btnSupprimerFiliere_Click;
        btnAjouterNiveau.Click += btnAjouterNiveau_Click;
        btnModifierNiveau.Click += btnModifierNiveau_Click;
        btnSupprimerNiveau.Click += btnSupprimerNiveau_Click;
        btnAjouterAnnee.Click += btnAjouterAnnee_Click;
        btnModifierAnnee.Click += btnModifierAnnee_Click;
        btnSupprimerAnnee.Click += btnSupprimerAnnee_Click;
        Load += UcStructure_Load;
        ((System.ComponentModel.ISupportInitialize)dgvFilieres).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvNiveaux).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvAnnees).EndInit();
        tlpStructure.ResumeLayout(false);
        cardFiliere.ResumeLayout(false);
        pnlBoutonsFiliere.ResumeLayout(false);
        tlpBoutonsFiliere.ResumeLayout(false);
        cardNiveau.ResumeLayout(false);
        pnlBoutonsNiveau.ResumeLayout(false);
        tlpBoutonsNiveau.ResumeLayout(false);
        cardAnnee.ResumeLayout(false);
        pnlBoutonsAnnee.ResumeLayout(false);
        tlpBoutonsAnnee.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private TableLayoutPanel tlpStructure;
    private PanelArrondi cardFiliere;
    private GrilleModerne dgvFilieres;
    private Panel pnlBoutonsFiliere;
    private TableLayoutPanel tlpBoutonsFiliere;
    private BoutonArrondi btnAjouterFiliere;
    private BoutonArrondi btnModifierFiliere;
    private BoutonArrondi btnSupprimerFiliere;
    private Label lblTitreFiliere;
    private PanelArrondi cardNiveau;
    private GrilleModerne dgvNiveaux;
    private Panel pnlBoutonsNiveau;
    private TableLayoutPanel tlpBoutonsNiveau;
    private BoutonArrondi btnAjouterNiveau;
    private BoutonArrondi btnModifierNiveau;
    private BoutonArrondi btnSupprimerNiveau;
    private Label lblTitreNiveau;
    private PanelArrondi cardAnnee;
    private GrilleModerne dgvAnnees;
    private Panel pnlBoutonsAnnee;
    private TableLayoutPanel tlpBoutonsAnnee;
    private BoutonArrondi btnAjouterAnnee;
    private BoutonArrondi btnModifierAnnee;
    private BoutonArrondi btnSupprimerAnnee;
    private Label lblTitreAnnee;
    private Panel pnlEntete;
    private Label lblSousTitre;
    private DataGridViewTextBoxColumn colIdF;
    private DataGridViewTextBoxColumn colCodeF;
    private DataGridViewTextBoxColumn colLibF;
    private DataGridViewTextBoxColumn colIdN;
    private DataGridViewTextBoxColumn colCodeN;
    private DataGridViewTextBoxColumn colLibN;
    private DataGridViewTextBoxColumn colIdA;
    private DataGridViewTextBoxColumn colLibA;
    private DataGridViewTextBoxColumn colDebA;
    private DataGridViewTextBoxColumn colFinA;
    private DataGridViewTextBoxColumn colActA;
}
