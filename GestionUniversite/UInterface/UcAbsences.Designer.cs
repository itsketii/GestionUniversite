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
        lblTitre = new Label();
        lblSousTitre = new Label();
        lblSeance = new Label();
        cboSeance = new ComboBox();
        btnEnregistrerAppel = new BoutonArrondi();
        pnlGrille = new PanelArrondi();
        dgvAppel = new GrilleModerne();
        lblResume = new Label();
        colId = new DataGridViewTextBoxColumn();
        colMatricule = new DataGridViewTextBoxColumn();
        colEtudiant = new DataGridViewTextBoxColumn();
        colAbsent = new DataGridViewCheckBoxColumn();
        colJustifiee = new DataGridViewCheckBoxColumn();
        colMotif = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvAppel).BeginInit();
        pnlGrille.SuspendLayout();
        SuspendLayout();
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Location = new Point(32, 26);
        lblTitre.Size = new Size(500, 40);
        lblTitre.Text = "Absences";
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
        lblSousTitre.Text = "Feuille d’appel par séance";
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.TabIndex = 1;
        //
        // lblSeance
        //
        lblSeance.AutoSize = false;
        lblSeance.Location = new Point(32, 100);
        lblSeance.Size = new Size(300, 20);
        lblSeance.Text = "Séance";
        lblSeance.ForeColor = Color.FromArgb(27, 20, 22);
        lblSeance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblSeance.Name = "lblSeance";
        lblSeance.TabIndex = 2;
        //
        // cboSeance
        //
        cboSeance.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSeance.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboSeance.Location = new Point(32, 122);
        cboSeance.Size = new Size(640, 28);
        cboSeance.Name = "cboSeance";
        cboSeance.TabIndex = 3;
        //
        // btnEnregistrerAppel
        //
        btnEnregistrerAppel.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrerAppel.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrerAppel.Location = new Point(828, 114);
        btnEnregistrerAppel.Size = new Size(180, 40);
        btnEnregistrerAppel.Text = "Enregistrer l’appel";
        btnEnregistrerAppel.UseVisualStyleBackColor = false;
        btnEnregistrerAppel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnEnregistrerAppel.Name = "btnEnregistrerAppel";
        btnEnregistrerAppel.TabIndex = 4;
        //
        // pnlGrille
        //
        pnlGrille.BackColor = Color.FromArgb(255, 255, 255);
        pnlGrille.Location = new Point(32, 170);
        pnlGrille.Size = new Size(976, 530);
        pnlGrille.Rayon = 16;
        pnlGrille.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlGrille.Padding = new Padding(8);
        pnlGrille.Name = "pnlGrille";
        pnlGrille.TabIndex = 5;
        pnlGrille.Controls.Add(dgvAppel);
        //
        // dgvAppel
        //
        dgvAppel.AutoGenerateColumns = false;
        dgvAppel.Dock = DockStyle.Fill;
        dgvAppel.ReadOnly = false;
        dgvAppel.Columns.AddRange(new DataGridViewColumn[] { colId, colMatricule, colEtudiant, colAbsent, colJustifiee, colMotif });
        dgvAppel.Name = "dgvAppel";
        dgvAppel.TabIndex = 6;
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
        // lblResume
        //
        lblResume.AutoSize = false;
        lblResume.Location = new Point(34, 710);
        lblResume.Size = new Size(500, 24);
        lblResume.Text = "";
        lblResume.ForeColor = Color.FromArgb(107, 96, 99);
        lblResume.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblResume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblResume.Name = "lblResume";
        lblResume.TabIndex = 7;
        //
        // UcAbsences
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcAbsences";
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(lblSeance);
        Controls.Add(cboSeance);
        Controls.Add(btnEnregistrerAppel);
        Controls.Add(pnlGrille);
        Controls.Add(lblResume);
        cboSeance.SelectedIndexChanged += cboSeance_SelectedIndexChanged;
        btnEnregistrerAppel.Click += btnEnregistrerAppel_Click;
        dgvAppel.CurrentCellDirtyStateChanged += dgvAppel_CurrentCellDirtyStateChanged;
        dgvAppel.CellValueChanged += dgvAppel_CellValueChanged;
        Load += UcAbsences_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAppel).EndInit();
        pnlGrille.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private Label lblSeance;
    private ComboBox cboSeance;
    private BoutonArrondi btnEnregistrerAppel;
    private PanelArrondi pnlGrille;
    private GrilleModerne dgvAppel;
    private Label lblResume;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colEtudiant;
    private DataGridViewCheckBoxColumn colAbsent;
    private DataGridViewCheckBoxColumn colJustifiee;
    private DataGridViewTextBoxColumn colMotif;
}
