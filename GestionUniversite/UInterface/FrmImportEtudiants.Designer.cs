using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmImportEtudiants
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlApercu = new PanelArrondi();
        dgvApercu = new GrilleModerne();
        pnlBas = new Panel();
        lblResume = new Label();
        flpBoutons = new FlowLayoutPanel();
        btnImporter = new BoutonArrondi();
        btnFermer = new BoutonArrondi();
        pnlOptions = new Panel();
        lblClasse = new Label();
        cboClasse = new ComboBox();
        chkValider = new CheckBox();
        lblFrais = new Label();
        numFrais = new NumericUpDown();
        pnlHaut = new Panel();
        lblTitreFiche = new Label();
        lblAide = new Label();
        btnModele = new BoutonArrondi();
        btnParcourir = new BoutonArrondi();
        lblFichier = new Label();
        colLigne = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colNom = new DataGridViewTextBoxColumn();
        colPrenoms = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        colResultat = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvApercu).BeginInit();
        pnlApercu.SuspendLayout();
        pnlBas.SuspendLayout();
        flpBoutons.SuspendLayout();
        pnlOptions.SuspendLayout();
        pnlHaut.SuspendLayout();
        SuspendLayout();
        //
        // pnlApercu
        //
        pnlApercu.BackColor = Color.FromArgb(255, 255, 255);
        pnlApercu.Rayon = 16;
        pnlApercu.Dock = DockStyle.Fill;
        pnlApercu.Tag = "carte";
        pnlApercu.Padding = new Padding(24, 6, 24, 6);
        pnlApercu.Name = "pnlApercu";
        pnlApercu.TabIndex = 0;
        pnlApercu.Controls.Add(dgvApercu);
        //
        // dgvApercu
        //
        dgvApercu.AutoGenerateColumns = false;
        dgvApercu.Dock = DockStyle.Fill;
        dgvApercu.Columns.AddRange(new DataGridViewColumn[] { colLigne, colMatricule, colNom, colPrenoms, colEmail, colResultat });
        dgvApercu.Name = "dgvApercu";
        dgvApercu.TabIndex = 1;
        //
        // colLigne
        //
        colLigne.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        colLigne.Width = 70;
        colLigne.DataPropertyName = "ligne";
        colLigne.HeaderText = "Ligne";
        colLigne.Name = "colLigne";
        colLigne.ReadOnly = true;
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
        colEmail.FillWeight = 130F;
        colEmail.DataPropertyName = "email";
        colEmail.HeaderText = "E-mail";
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        //
        // colResultat
        //
        colResultat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colResultat.FillWeight = 150F;
        colResultat.DataPropertyName = "resultat";
        colResultat.HeaderText = "Contrôle";
        colResultat.Name = "colResultat";
        colResultat.ReadOnly = true;
        //
        // pnlBas
        //
        pnlBas.Dock = DockStyle.Bottom;
        pnlBas.Size = new Size(100, 72);
        pnlBas.Name = "pnlBas";
        pnlBas.TabIndex = 2;
        pnlBas.Controls.Add(lblResume);
        pnlBas.Controls.Add(flpBoutons);
        //
        // lblResume
        //
        lblResume.AutoSize = false;
        lblResume.Location = new Point(24, 24);
        lblResume.Size = new Size(520, 26);
        lblResume.Text = "";
        lblResume.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblResume.ForeColor = Color.FromArgb(27, 20, 22);
        lblResume.Tag = "texte";
        lblResume.Name = "lblResume";
        lblResume.TabIndex = 3;
        //
        // flpBoutons
        //
        flpBoutons.AutoSize = true;
        flpBoutons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpBoutons.Dock = DockStyle.Right;
        flpBoutons.FlowDirection = FlowDirection.LeftToRight;
        flpBoutons.WrapContents = false;
        flpBoutons.Size = new Size(100, 72);
        flpBoutons.Name = "flpBoutons";
        flpBoutons.TabIndex = 4;
        flpBoutons.Controls.Add(btnImporter);
        flpBoutons.Controls.Add(btnFermer);
        //
        // btnImporter
        //
        btnImporter.BackColor = Color.FromArgb(155, 27, 48);
        btnImporter.ForeColor = Color.FromArgb(255, 255, 255);
        btnImporter.Text = "Importer";
        btnImporter.UseVisualStyleBackColor = false;
        btnImporter.Location = new Point(0, 0);
        btnImporter.Size = new Size(150, 42);
        btnImporter.Margin = new Padding(8, 15, 0, 15);
        btnImporter.Name = "btnImporter";
        btnImporter.TabIndex = 5;
        //
        // btnFermer
        //
        btnFermer.BackColor = Color.FromArgb(239, 232, 234);
        btnFermer.ForeColor = Color.FromArgb(27, 20, 22);
        btnFermer.Text = "Fermer";
        btnFermer.UseVisualStyleBackColor = false;
        btnFermer.Location = new Point(0, 0);
        btnFermer.Size = new Size(110, 42);
        btnFermer.Tag = "secondaire";
        btnFermer.Margin = new Padding(8, 15, 24, 15);
        btnFermer.Name = "btnFermer";
        btnFermer.TabIndex = 6;
        //
        // pnlOptions
        //
        pnlOptions.Dock = DockStyle.Top;
        pnlOptions.Size = new Size(100, 68);
        pnlOptions.Name = "pnlOptions";
        pnlOptions.TabIndex = 7;
        pnlOptions.Controls.Add(lblClasse);
        pnlOptions.Controls.Add(cboClasse);
        pnlOptions.Controls.Add(chkValider);
        pnlOptions.Controls.Add(lblFrais);
        pnlOptions.Controls.Add(numFrais);
        //
        // lblClasse
        //
        lblClasse.AutoSize = false;
        lblClasse.Location = new Point(24, 4);
        lblClasse.Size = new Size(330, 18);
        lblClasse.Text = "Inscrire aussi dans la classe";
        lblClasse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblClasse.ForeColor = Color.FromArgb(27, 20, 22);
        lblClasse.Tag = "texte";
        lblClasse.Name = "lblClasse";
        lblClasse.TabIndex = 8;
        //
        // cboClasse
        //
        cboClasse.BackColor = Color.FromArgb(255, 255, 255);
        cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
        cboClasse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboClasse.Location = new Point(24, 26);
        cboClasse.Size = new Size(330, 28);
        cboClasse.Tag = "input";
        cboClasse.Name = "cboClasse";
        cboClasse.TabIndex = 9;
        //
        // chkValider
        //
        chkValider.AutoSize = true;
        chkValider.BackColor = Color.Transparent;
        chkValider.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        chkValider.ForeColor = Color.FromArgb(27, 20, 22);
        chkValider.Location = new Point(374, 30);
        chkValider.Text = "Valider les inscriptions";
        chkValider.Tag = "texte";
        chkValider.Name = "chkValider";
        chkValider.TabIndex = 10;
        //
        // lblFrais
        //
        lblFrais.AutoSize = false;
        lblFrais.Location = new Point(600, 4);
        lblFrais.Size = new Size(250, 18);
        lblFrais.Text = "Frais d’inscription (FCFA)";
        lblFrais.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblFrais.ForeColor = Color.FromArgb(27, 20, 22);
        lblFrais.Tag = "texte";
        lblFrais.Name = "lblFrais";
        lblFrais.TabIndex = 11;
        //
        // numFrais
        //
        numFrais.BackColor = Color.FromArgb(255, 255, 255);
        numFrais.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        numFrais.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
        numFrais.Location = new Point(600, 26);
        numFrais.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numFrais.Size = new Size(200, 27);
        numFrais.Tag = "input";
        numFrais.ThousandsSeparator = true;
        numFrais.Name = "numFrais";
        numFrais.TabIndex = 12;
        //
        // pnlHaut
        //
        pnlHaut.Dock = DockStyle.Top;
        pnlHaut.Size = new Size(100, 146);
        pnlHaut.Name = "pnlHaut";
        pnlHaut.TabIndex = 13;
        pnlHaut.Controls.Add(lblTitreFiche);
        pnlHaut.Controls.Add(lblAide);
        pnlHaut.Controls.Add(btnModele);
        pnlHaut.Controls.Add(btnParcourir);
        pnlHaut.Controls.Add(lblFichier);
        //
        // lblTitreFiche
        //
        lblTitreFiche.AutoSize = false;
        lblTitreFiche.Location = new Point(24, 16);
        lblTitreFiche.Size = new Size(700, 34);
        lblTitreFiche.Text = "Importer des étudiants depuis Excel";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 14;
        //
        // lblAide
        //
        lblAide.AutoSize = false;
        lblAide.Location = new Point(24, 54);
        lblAide.Size = new Size(900, 22);
        lblAide.Text = "1. Téléchargez le modèle et remplissez-le   2. Choisissez le fichier pour vérifier les lignes   3. Importez : tout est enregistré, ou rien.";
        lblAide.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblAide.ForeColor = Color.FromArgb(107, 96, 99);
        lblAide.Tag = "discret";
        lblAide.Name = "lblAide";
        lblAide.TabIndex = 15;
        //
        // btnModele
        //
        btnModele.BackColor = Color.FromArgb(239, 232, 234);
        btnModele.ForeColor = Color.FromArgb(27, 20, 22);
        btnModele.Text = "Télécharger le modèle";
        btnModele.UseVisualStyleBackColor = false;
        btnModele.Location = new Point(24, 92);
        btnModele.Size = new Size(210, 40);
        btnModele.Tag = "secondaire";
        btnModele.Name = "btnModele";
        btnModele.TabIndex = 16;
        //
        // btnParcourir
        //
        btnParcourir.BackColor = Color.FromArgb(155, 27, 48);
        btnParcourir.ForeColor = Color.FromArgb(255, 255, 255);
        btnParcourir.Text = "Choisir un fichier Excel";
        btnParcourir.UseVisualStyleBackColor = false;
        btnParcourir.Location = new Point(246, 92);
        btnParcourir.Size = new Size(220, 40);
        btnParcourir.Name = "btnParcourir";
        btnParcourir.TabIndex = 17;
        //
        // lblFichier
        //
        lblFichier.AutoSize = false;
        lblFichier.Location = new Point(480, 100);
        lblFichier.Size = new Size(430, 24);
        lblFichier.Text = "Aucun fichier sélectionné";
        lblFichier.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblFichier.ForeColor = Color.FromArgb(107, 96, 99);
        lblFichier.Tag = "discret";
        lblFichier.Name = "lblFichier";
        lblFichier.TabIndex = 18;
        //
        // FrmImportEtudiants
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(960, 680);
        MinimumSize = new Size(900, 600);
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Importer des étudiants";
        Name = "FrmImportEtudiants";
        Controls.Add(pnlApercu);
        Controls.Add(pnlBas);
        Controls.Add(pnlOptions);
        Controls.Add(pnlHaut);
        dgvApercu.CellFormatting += dgvApercu_CellFormatting;
        btnImporter.Click += btnImporter_Click;
        btnFermer.Click += btnFermer_Click;
        btnModele.Click += btnModele_Click;
        btnParcourir.Click += btnParcourir_Click;
        ((System.ComponentModel.ISupportInitialize)dgvApercu).EndInit();
        pnlApercu.ResumeLayout(false);
        pnlBas.ResumeLayout(false);
        flpBoutons.ResumeLayout(false);
        pnlOptions.ResumeLayout(false);
        pnlHaut.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlApercu;
    private GrilleModerne dgvApercu;
    private Panel pnlBas;
    private Label lblResume;
    private FlowLayoutPanel flpBoutons;
    private BoutonArrondi btnImporter;
    private BoutonArrondi btnFermer;
    private Panel pnlOptions;
    private Label lblClasse;
    private ComboBox cboClasse;
    private CheckBox chkValider;
    private Label lblFrais;
    private NumericUpDown numFrais;
    private Panel pnlHaut;
    private Label lblTitreFiche;
    private Label lblAide;
    private BoutonArrondi btnModele;
    private BoutonArrondi btnParcourir;
    private Label lblFichier;
    private DataGridViewTextBoxColumn colLigne;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colNom;
    private DataGridViewTextBoxColumn colPrenoms;
    private DataGridViewTextBoxColumn colEmail;
    private DataGridViewTextBoxColumn colResultat;
}
