using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcAbsences
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
        dgvAppel = new GrilleModerne();
        pnlBas = new Panel();
        lblResume = new Label();
        pnlOutils = new Panel();
        lblSeance = new Label();
        cboSeance = new ComboBox();
        flpBoutons = new FlowLayoutPanel();
        btnFeuille = new BoutonArrondi();
        btnFeuillePdf = new BoutonArrondi();
        btnExporter = new BoutonArrondi();
        btnEnregistrerAppel = new BoutonArrondi();
        pnlEntete = new Panel();
        lblSousTitre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colEtudiant = new DataGridViewTextBoxColumn();
        colAbsent = new DataGridViewCheckBoxColumn();
        colJustifiee = new DataGridViewCheckBoxColumn();
        colMotif = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvAppel).BeginInit();
        pnlCarte.SuspendLayout();
        pnlBas.SuspendLayout();
        pnlOutils.SuspendLayout();
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
        pnlCarte.Controls.Add(dgvAppel);
        //
        // dgvAppel
        //
        dgvAppel.AutoGenerateColumns = false;
        dgvAppel.Dock = DockStyle.Fill;
        dgvAppel.ReadOnly = false;
        dgvAppel.Columns.AddRange(new DataGridViewColumn[] { colId, colMatricule, colEtudiant, colAbsent, colJustifiee, colMotif });
        dgvAppel.Name = "dgvAppel";
        dgvAppel.TabIndex = 1;
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
        // colEtudiant
        //
        colEtudiant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEtudiant.FillWeight = 160F;
        colEtudiant.DataPropertyName = "etudiant";
        colEtudiant.HeaderText = "Étudiant";
        colEtudiant.Name = "colEtudiant";
        colEtudiant.ReadOnly = true;
        //
        // colAbsent
        //
        colAbsent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colAbsent.Width = 90;
        colAbsent.DataPropertyName = "absent";
        colAbsent.HeaderText = "Absent";
        colAbsent.Name = "colAbsent";
        colAbsent.ReadOnly = false;
        //
        // colJustifiee
        //
        colJustifiee.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colJustifiee.Width = 100;
        colJustifiee.DataPropertyName = "justifiee";
        colJustifiee.HeaderText = "Justifiée";
        colJustifiee.Name = "colJustifiee";
        colJustifiee.ReadOnly = false;
        //
        // colMotif
        //
        colMotif.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colMotif.FillWeight = 140F;
        colMotif.DataPropertyName = "motif";
        colMotif.HeaderText = "Motif";
        colMotif.Name = "colMotif";
        colMotif.ReadOnly = false;
        //
        // pnlBas
        //
        pnlBas.Dock = DockStyle.Bottom;
        pnlBas.Size = new Size(100, 30);
        pnlBas.Name = "pnlBas";
        pnlBas.TabIndex = 2;
        pnlBas.Controls.Add(lblResume);
        //
        // lblResume
        //
        lblResume.AutoSize = false;
        lblResume.Location = new Point(6, 5);
        lblResume.Size = new Size(700, 22);
        lblResume.Text = "";
        lblResume.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblResume.ForeColor = Color.FromArgb(107, 96, 99);
        lblResume.Tag = "discret";
        lblResume.Name = "lblResume";
        lblResume.TabIndex = 3;
        //
        // pnlOutils
        //
        pnlOutils.Dock = DockStyle.Top;
        pnlOutils.Size = new Size(100, 64);
        pnlOutils.Name = "pnlOutils";
        pnlOutils.TabIndex = 4;
        pnlOutils.Controls.Add(lblSeance);
        pnlOutils.Controls.Add(cboSeance);
        pnlOutils.Controls.Add(flpBoutons);
        //
        // lblSeance
        //
        lblSeance.AutoSize = false;
        lblSeance.Location = new Point(2, 2);
        lblSeance.Size = new Size(200, 18);
        lblSeance.Text = "Séance";
        lblSeance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        lblSeance.ForeColor = Color.FromArgb(107, 96, 99);
        lblSeance.Tag = "discret";
        lblSeance.Name = "lblSeance";
        lblSeance.TabIndex = 5;
        //
        // cboSeance
        //
        cboSeance.BackColor = Color.FromArgb(255, 255, 255);
        cboSeance.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSeance.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboSeance.Location = new Point(0, 24);
        cboSeance.Size = new Size(430, 28);
        cboSeance.Tag = "input";
        cboSeance.Name = "cboSeance";
        cboSeance.TabIndex = 6;
        //
        // flpBoutons
        //
        flpBoutons.AutoSize = true;
        flpBoutons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpBoutons.Dock = DockStyle.Right;
        flpBoutons.FlowDirection = FlowDirection.LeftToRight;
        flpBoutons.WrapContents = false;
        flpBoutons.Size = new Size(100, 64);
        flpBoutons.Name = "flpBoutons";
        flpBoutons.TabIndex = 7;
        flpBoutons.Controls.Add(btnFeuille);
        flpBoutons.Controls.Add(btnFeuillePdf);
        flpBoutons.Controls.Add(btnExporter);
        flpBoutons.Controls.Add(btnEnregistrerAppel);
        //
        // btnFeuille
        //
        btnFeuille.BackColor = Color.FromArgb(239, 232, 234);
        btnFeuille.ForeColor = Color.FromArgb(27, 20, 22);
        btnFeuille.Text = "Feuille d’appel";
        btnFeuille.UseVisualStyleBackColor = false;
        btnFeuille.Location = new Point(0, 0);
        btnFeuille.Size = new Size(140, 40);
        btnFeuille.Tag = "secondaire";
        btnFeuille.Margin = new Padding(8, 12, 0, 12);
        btnFeuille.Name = "btnFeuille";
        btnFeuille.TabIndex = 8;
        //
        // btnFeuillePdf
        //
        btnFeuillePdf.BackColor = Color.FromArgb(239, 232, 234);
        btnFeuillePdf.ForeColor = Color.FromArgb(27, 20, 22);
        btnFeuillePdf.Text = "PDF";
        btnFeuillePdf.UseVisualStyleBackColor = false;
        btnFeuillePdf.Location = new Point(0, 0);
        btnFeuillePdf.Size = new Size(60, 40);
        btnFeuillePdf.Tag = "secondaire";
        btnFeuillePdf.Margin = new Padding(8, 12, 0, 12);
        btnFeuillePdf.Name = "btnFeuillePdf";
        btnFeuillePdf.TabIndex = 9;
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
        btnExporter.Margin = new Padding(8, 12, 0, 12);
        btnExporter.Name = "btnExporter";
        btnExporter.TabIndex = 10;
        //
        // btnEnregistrerAppel
        //
        btnEnregistrerAppel.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrerAppel.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrerAppel.Text = "Enregistrer l’appel";
        btnEnregistrerAppel.UseVisualStyleBackColor = false;
        btnEnregistrerAppel.Location = new Point(0, 0);
        btnEnregistrerAppel.Size = new Size(170, 40);
        btnEnregistrerAppel.Margin = new Padding(8, 12, 0, 12);
        btnEnregistrerAppel.Name = "btnEnregistrerAppel";
        btnEnregistrerAppel.TabIndex = 11;
        //
        // pnlEntete
        //
        pnlEntete.Dock = DockStyle.Top;
        pnlEntete.Size = new Size(100, 34);
        pnlEntete.Name = "pnlEntete";
        pnlEntete.TabIndex = 12;
        pnlEntete.Controls.Add(lblSousTitre);
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(4, 6);
        lblSousTitre.Size = new Size(900, 24);
        lblSousTitre.Text = "Feuille d’appel : cochez les étudiants absents puis enregistrez";
        lblSousTitre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Tag = "discret";
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 13;
        //
        // UcAbsences
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Padding = new Padding(20, 12, 20, 12);
        Size = new Size(1073, 724);
        Tag = "fond";
        Name = "UcAbsences";
        Controls.Add(pnlCarte);
        Controls.Add(pnlBas);
        Controls.Add(pnlOutils);
        Controls.Add(pnlEntete);
        dgvAppel.CurrentCellDirtyStateChanged += dgvAppel_CurrentCellDirtyStateChanged;
        dgvAppel.CellValueChanged += dgvAppel_CellValueChanged;
        cboSeance.SelectedIndexChanged += cboSeance_SelectedIndexChanged;
        btnFeuille.Click += btnFeuille_Click;
        btnFeuillePdf.Click += btnFeuillePdf_Click;
        btnExporter.Click += btnExporter_Click;
        btnEnregistrerAppel.Click += btnEnregistrerAppel_Click;
        Load += UcAbsences_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAppel).EndInit();
        pnlCarte.ResumeLayout(false);
        pnlBas.ResumeLayout(false);
        pnlOutils.ResumeLayout(false);
        flpBoutons.ResumeLayout(false);
        pnlEntete.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlCarte;
    private GrilleModerne dgvAppel;
    private Panel pnlBas;
    private Label lblResume;
    private Panel pnlOutils;
    private Label lblSeance;
    private ComboBox cboSeance;
    private FlowLayoutPanel flpBoutons;
    private BoutonArrondi btnFeuille;
    private BoutonArrondi btnFeuillePdf;
    private BoutonArrondi btnExporter;
    private BoutonArrondi btnEnregistrerAppel;
    private Panel pnlEntete;
    private Label lblSousTitre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colEtudiant;
    private DataGridViewCheckBoxColumn colAbsent;
    private DataGridViewCheckBoxColumn colJustifiee;
    private DataGridViewTextBoxColumn colMotif;
}
