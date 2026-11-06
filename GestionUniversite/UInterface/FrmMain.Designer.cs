namespace GestionUniversite.UInterface;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblStatut = new Label();
        btnCharger = new Button();
        dgvEtudiants = new DataGridView();
        colMatricule = new DataGridViewTextBoxColumn();
        colNom = new DataGridViewTextBoxColumn();
        colPrenoms = new DataGridViewTextBoxColumn();
        colEmail = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvEtudiants).BeginInit();
        SuspendLayout();
        //
        // lblStatut
        //
        lblStatut.AutoSize = true;
        lblStatut.Location = new Point(24, 20);
        lblStatut.Name = "lblStatut";
        lblStatut.Text = "Connexion en cours...";
        //
        // btnCharger
        //
        btnCharger.Location = new Point(24, 52);
        btnCharger.Name = "btnCharger";
        btnCharger.Size = new Size(180, 34);
        btnCharger.Text = "Charger les étudiants";
        btnCharger.UseVisualStyleBackColor = true;
        btnCharger.Click += btnCharger_Click;
        //
        // dgvEtudiants : colonnes définies ici, visibles dans le designer
        //
        dgvEtudiants.AllowUserToAddRows = false;
        dgvEtudiants.AllowUserToDeleteRows = false;
        dgvEtudiants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEtudiants.AutoGenerateColumns = false;
        dgvEtudiants.Columns.AddRange(new DataGridViewColumn[] { colMatricule, colNom, colPrenoms, colEmail });
        dgvEtudiants.Location = new Point(24, 100);
        dgvEtudiants.Name = "dgvEtudiants";
        dgvEtudiants.ReadOnly = true;
        dgvEtudiants.Size = new Size(752, 300);
        //
        // colMatricule
        //
        colMatricule.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colMatricule.DataPropertyName = "Matricule";
        colMatricule.HeaderText = "Matricule";
        colMatricule.Name = "colMatricule";
        colMatricule.ReadOnly = true;
        //
        // colNom
        //
        colNom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colNom.DataPropertyName = "Nom";
        colNom.HeaderText = "Nom";
        colNom.Name = "colNom";
        colNom.ReadOnly = true;
        //
        // colPrenoms
        //
        colPrenoms.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colPrenoms.DataPropertyName = "Prenoms";
        colPrenoms.HeaderText = "Prénoms";
        colPrenoms.Name = "colPrenoms";
        colPrenoms.ReadOnly = true;
        //
        // colEmail
        //
        colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEmail.DataPropertyName = "Email";
        colEmail.HeaderText = "E-mail";
        colEmail.Name = "colEmail";
        colEmail.ReadOnly = true;
        //
        // FrmMain
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 424);
        Controls.Add(dgvEtudiants);
        Controls.Add(btnCharger);
        Controls.Add(lblStatut);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestion de l'université";
        Load += FrmMain_Load;
        ((System.ComponentModel.ISupportInitialize)dgvEtudiants).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblStatut;
    private Button btnCharger;
    private DataGridView dgvEtudiants;
    private DataGridViewTextBoxColumn colMatricule;
    private DataGridViewTextBoxColumn colNom;
    private DataGridViewTextBoxColumn colPrenoms;
    private DataGridViewTextBoxColumn colEmail;
}
