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
        lblTitre = new Label();
        lblSousTitre = new Label();
        txtRecherche = new TextBox();
        btnNouvelle = new BoutonArrondi();
        btnValider = new BoutonArrondi();
        btnAnnulerInscription = new BoutonArrondi();
        pnlGrille = new PanelArrondi();
        dgvInscriptions = new GrilleModerne();
        lblNombre = new Label();
        colId = new DataGridViewTextBoxColumn();
        colDate = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colEtudiant = new DataGridViewTextBoxColumn();
        colClasse = new DataGridViewTextBoxColumn();
        colFrais = new DataGridViewTextBoxColumn();
        colStatut = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).BeginInit();
        pnlGrille.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Location = new Point(32, 26);
        lblTitre.Size = new Size(500, 40);
        lblTitre.Text = "Inscriptions";
        lblTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitre.Name = "lblTitre";
        lblTitre.TabIndex = 0;
        //
        // lblSousTitre
        //
        lblSousTitre.AutoSize = false;
        lblSousTitre.Location = new Point(34, 66);
        lblSousTitre.Size = new Size(500, 24);
        lblSousTitre.Text = "Inscriptions de l’année académique en cours";
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 1;
        //
        // txtRecherche
        //
        txtRecherche.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtRecherche.Location = new Point(32, 106);
        txtRecherche.Size = new Size(340, 27);
        txtRecherche.PlaceholderText = "Rechercher un étudiant, une classe, un matricule";
        txtRecherche.Name = "txtRecherche";
        txtRecherche.TabIndex = 2;
        //
        // btnNouvelle
        //
        btnNouvelle.BackColor = Color.FromArgb(155, 27, 48);
        btnNouvelle.ForeColor = Color.FromArgb(255, 255, 255);
        btnNouvelle.Location = new Point(556, 100);
        btnNouvelle.Size = new Size(180, 40);
        btnNouvelle.Text = "Nouvelle inscription";
        btnNouvelle.UseVisualStyleBackColor = false;
        btnNouvelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnNouvelle.Name = "btnNouvelle";
        btnNouvelle.TabIndex = 3;
        //
        // btnValider
        //
        btnValider.BackColor = Color.FromArgb(30, 107, 58);
        btnValider.ForeColor = Color.FromArgb(255, 255, 255);
        btnValider.Location = new Point(748, 100);
        btnValider.Size = new Size(120, 40);
        btnValider.Text = "Valider";
        btnValider.UseVisualStyleBackColor = false;
        btnValider.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnValider.Name = "btnValider";
        btnValider.TabIndex = 4;
        //
        // btnAnnulerInscription
        //
        btnAnnulerInscription.BackColor = Color.FromArgb(179, 38, 30);
        btnAnnulerInscription.ForeColor = Color.FromArgb(255, 255, 255);
        btnAnnulerInscription.Location = new Point(880, 100);
        btnAnnulerInscription.Size = new Size(128, 40);
        btnAnnulerInscription.Text = "Annuler";
        btnAnnulerInscription.UseVisualStyleBackColor = false;
        btnAnnulerInscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAnnulerInscription.Name = "btnAnnulerInscription";
        btnAnnulerInscription.TabIndex = 5;
        //
        // pnlGrille
        //
        pnlGrille.BackColor = Color.FromArgb(255, 255, 255);
        pnlGrille.Location = new Point(32, 160);
        pnlGrille.Size = new Size(976, 540);
        pnlGrille.Rayon = 16;
        pnlGrille.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlGrille.Padding = new Padding(8);
        pnlGrille.Name = "pnlGrille";
        pnlGrille.TabIndex = 6;
        pnlGrille.Controls.Add(dgvInscriptions);
        //
        // dgvInscriptions
        //
        dgvInscriptions.AutoGenerateColumns = false;
        dgvInscriptions.Dock = DockStyle.Fill;
        dgvInscriptions.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colMatricule, colEtudiant, colClasse, colFrais, colStatut });
        dgvInscriptions.Name = "dgvInscriptions";
        dgvInscriptions.TabIndex = 7;
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
        colStatut.Width = 120;
        colStatut.DataPropertyName = "statut";
        colStatut.HeaderText = "Statut";
        colStatut.Name = "colStatut";
        colStatut.ReadOnly = true;
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.Location = new Point(34, 710);
        lblNombre.Size = new Size(400, 24);
        lblNombre.Text = "";
        lblNombre.ForeColor = Color.FromArgb(107, 96, 99);
        lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblNombre.Name = "lblNombre";
        lblNombre.TabIndex = 8;
        //
        // UcInscriptions
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcInscriptions";
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(txtRecherche);
        Controls.Add(btnNouvelle);
        Controls.Add(btnValider);
        Controls.Add(btnAnnulerInscription);
        Controls.Add(pnlGrille);
        Controls.Add(lblNombre);
        txtRecherche.TextChanged += txtRecherche_TextChanged;
        btnNouvelle.Click += btnNouvelle_Click;
        btnValider.Click += btnValider_Click;
        btnAnnulerInscription.Click += btnAnnulerInscription_Click;
        Load += UcInscriptions_Load;
        ((System.ComponentModel.ISupportInitialize)dgvInscriptions).EndInit();
        pnlGrille.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private TextBox txtRecherche;
    private BoutonArrondi btnNouvelle;
    private BoutonArrondi btnValider;
    private BoutonArrondi btnAnnulerInscription;
    private PanelArrondi pnlGrille;
    private GrilleModerne dgvInscriptions;
    private Label lblNombre;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colDate;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colEtudiant;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colFrais;
    private DataGridViewTextBoxColumn colStatut;
}
