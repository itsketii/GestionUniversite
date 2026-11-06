using GestionUniversite.UInterface.Composants;

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
        pnlContenu = new Panel();
        pnlMenu = new Panel();
        lblNomApp = new Label();
        btnDashboard = new Button();
        btnEtudiants = new Button();
        btnInscriptions = new Button();
        btnClasses = new Button();
        btnPlanification = new Button();
        btnAbsences = new Button();
        lblUtilisateur = new Label();
        btnDeconnexion = new BoutonArrondi();
        pictureBox1 = new PictureBox();
        pnlMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pnlContenu
        // 
        pnlContenu.BackColor = Color.FromArgb(246, 243, 242);
        pnlContenu.Dock = DockStyle.Fill;
        pnlContenu.Location = new Point(343, 0);
        pnlContenu.Margin = new Padding(4, 5, 4, 5);
        pnlContenu.Name = "pnlContenu";
        pnlContenu.Size = new Size(1486, 1170);
        pnlContenu.TabIndex = 0;
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.FromArgb(27, 20, 22);
        pnlMenu.Controls.Add(pictureBox1);
        pnlMenu.Controls.Add(lblNomApp);
        pnlMenu.Controls.Add(btnDashboard);
        pnlMenu.Controls.Add(btnEtudiants);
        pnlMenu.Controls.Add(btnInscriptions);
        pnlMenu.Controls.Add(btnClasses);
        pnlMenu.Controls.Add(btnPlanification);
        pnlMenu.Controls.Add(btnAbsences);
        pnlMenu.Controls.Add(lblUtilisateur);
        pnlMenu.Controls.Add(btnDeconnexion);
        pnlMenu.Dock = DockStyle.Left;
        pnlMenu.Location = new Point(0, 0);
        pnlMenu.Margin = new Padding(4, 5, 4, 5);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(343, 1170);
        pnlMenu.TabIndex = 1;
        // 
        // lblNomApp
        // 
        lblNomApp.Font = new Font("Segoe UI Semibold", 11F);
        lblNomApp.ForeColor = Color.FromArgb(255, 255, 255);
        lblNomApp.Location = new Point(149, 45);
        lblNomApp.Margin = new Padding(4, 0, 4, 0);
        lblNomApp.Name = "lblNomApp";
        lblNomApp.Size = new Size(171, 73);
        lblNomApp.TabIndex = 3;
        lblNomApp.Text = "Gestion\r\nuniversitaire";
        lblNomApp.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnDashboard
        // 
        btnDashboard.BackColor = Color.FromArgb(27, 20, 22);
        btnDashboard.Cursor = Cursors.Hand;
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.Font = new Font("Segoe UI", 10.5F);
        btnDashboard.ForeColor = Color.FromArgb(214, 204, 207);
        btnDashboard.Location = new Point(17, 167);
        btnDashboard.Margin = new Padding(4, 5, 4, 5);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Padding = new Padding(23, 0, 0, 0);
        btnDashboard.Size = new Size(309, 77);
        btnDashboard.TabIndex = 4;
        btnDashboard.Text = "Tableau de bord";
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashboard.UseVisualStyleBackColor = false;
        btnDashboard.Click += btnDashboard_Click;
        // 
        // btnEtudiants
        // 
        btnEtudiants.BackColor = Color.FromArgb(27, 20, 22);
        btnEtudiants.Cursor = Cursors.Hand;
        btnEtudiants.FlatAppearance.BorderSize = 0;
        btnEtudiants.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnEtudiants.FlatStyle = FlatStyle.Flat;
        btnEtudiants.Font = new Font("Segoe UI", 10.5F);
        btnEtudiants.ForeColor = Color.FromArgb(214, 204, 207);
        btnEtudiants.Location = new Point(17, 253);
        btnEtudiants.Margin = new Padding(4, 5, 4, 5);
        btnEtudiants.Name = "btnEtudiants";
        btnEtudiants.Padding = new Padding(23, 0, 0, 0);
        btnEtudiants.Size = new Size(309, 77);
        btnEtudiants.TabIndex = 5;
        btnEtudiants.Text = "Étudiants";
        btnEtudiants.TextAlign = ContentAlignment.MiddleLeft;
        btnEtudiants.UseVisualStyleBackColor = false;
        btnEtudiants.Click += btnEtudiants_Click;
        // 
        // btnInscriptions
        // 
        btnInscriptions.BackColor = Color.FromArgb(27, 20, 22);
        btnInscriptions.Cursor = Cursors.Hand;
        btnInscriptions.FlatAppearance.BorderSize = 0;
        btnInscriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnInscriptions.FlatStyle = FlatStyle.Flat;
        btnInscriptions.Font = new Font("Segoe UI", 10.5F);
        btnInscriptions.ForeColor = Color.FromArgb(214, 204, 207);
        btnInscriptions.Location = new Point(17, 340);
        btnInscriptions.Margin = new Padding(4, 5, 4, 5);
        btnInscriptions.Name = "btnInscriptions";
        btnInscriptions.Padding = new Padding(23, 0, 0, 0);
        btnInscriptions.Size = new Size(309, 77);
        btnInscriptions.TabIndex = 6;
        btnInscriptions.Text = "Inscriptions";
        btnInscriptions.TextAlign = ContentAlignment.MiddleLeft;
        btnInscriptions.UseVisualStyleBackColor = false;
        btnInscriptions.Click += btnInscriptions_Click;
        // 
        // btnClasses
        // 
        btnClasses.BackColor = Color.FromArgb(27, 20, 22);
        btnClasses.Cursor = Cursors.Hand;
        btnClasses.FlatAppearance.BorderSize = 0;
        btnClasses.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnClasses.FlatStyle = FlatStyle.Flat;
        btnClasses.Font = new Font("Segoe UI", 10.5F);
        btnClasses.ForeColor = Color.FromArgb(214, 204, 207);
        btnClasses.Location = new Point(17, 427);
        btnClasses.Margin = new Padding(4, 5, 4, 5);
        btnClasses.Name = "btnClasses";
        btnClasses.Padding = new Padding(23, 0, 0, 0);
        btnClasses.Size = new Size(309, 77);
        btnClasses.TabIndex = 7;
        btnClasses.Text = "Classes";
        btnClasses.TextAlign = ContentAlignment.MiddleLeft;
        btnClasses.UseVisualStyleBackColor = false;
        btnClasses.Click += btnClasses_Click;
        // 
        // btnPlanification
        // 
        btnPlanification.BackColor = Color.FromArgb(27, 20, 22);
        btnPlanification.Cursor = Cursors.Hand;
        btnPlanification.FlatAppearance.BorderSize = 0;
        btnPlanification.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnPlanification.FlatStyle = FlatStyle.Flat;
        btnPlanification.Font = new Font("Segoe UI", 10.5F);
        btnPlanification.ForeColor = Color.FromArgb(214, 204, 207);
        btnPlanification.Location = new Point(17, 513);
        btnPlanification.Margin = new Padding(4, 5, 4, 5);
        btnPlanification.Name = "btnPlanification";
        btnPlanification.Padding = new Padding(23, 0, 0, 0);
        btnPlanification.Size = new Size(309, 77);
        btnPlanification.TabIndex = 8;
        btnPlanification.Text = "Planification";
        btnPlanification.TextAlign = ContentAlignment.MiddleLeft;
        btnPlanification.UseVisualStyleBackColor = false;
        btnPlanification.Click += btnPlanification_Click;
        // 
        // btnAbsences
        // 
        btnAbsences.BackColor = Color.FromArgb(27, 20, 22);
        btnAbsences.Cursor = Cursors.Hand;
        btnAbsences.FlatAppearance.BorderSize = 0;
        btnAbsences.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 47, 50);
        btnAbsences.FlatStyle = FlatStyle.Flat;
        btnAbsences.Font = new Font("Segoe UI", 10.5F);
        btnAbsences.ForeColor = Color.FromArgb(214, 204, 207);
        btnAbsences.Location = new Point(17, 600);
        btnAbsences.Margin = new Padding(4, 5, 4, 5);
        btnAbsences.Name = "btnAbsences";
        btnAbsences.Padding = new Padding(23, 0, 0, 0);
        btnAbsences.Size = new Size(309, 77);
        btnAbsences.TabIndex = 9;
        btnAbsences.Text = "Absences";
        btnAbsences.TextAlign = ContentAlignment.MiddleLeft;
        btnAbsences.UseVisualStyleBackColor = false;
        btnAbsences.Click += btnAbsences_Click;
        // 
        // lblUtilisateur
        // 
        lblUtilisateur.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblUtilisateur.Font = new Font("Segoe UI", 9.5F);
        lblUtilisateur.ForeColor = Color.FromArgb(255, 255, 255);
        lblUtilisateur.Location = new Point(34, 996);
        lblUtilisateur.Margin = new Padding(4, 0, 4, 0);
        lblUtilisateur.Name = "lblUtilisateur";
        lblUtilisateur.Size = new Size(286, 60);
        lblUtilisateur.TabIndex = 10;
        lblUtilisateur.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnDeconnexion
        // 
        btnDeconnexion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeconnexion.BackColor = Color.FromArgb(58, 47, 50);
        btnDeconnexion.FlatStyle = FlatStyle.Flat;
        btnDeconnexion.Font = new Font("Segoe UI Semibold", 10F);
        btnDeconnexion.ForeColor = Color.FromArgb(255, 255, 255);
        btnDeconnexion.Location = new Point(17, 1073);
        btnDeconnexion.Margin = new Padding(4, 5, 4, 5);
        btnDeconnexion.Name = "btnDeconnexion";
        btnDeconnexion.Size = new Size(309, 70);
        btnDeconnexion.TabIndex = 11;
        btnDeconnexion.Text = "Déconnexion";
        btnDeconnexion.UseVisualStyleBackColor = false;
        btnDeconnexion.Click += btnDeconnexion_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.Logo_IIT_4x4;
        pictureBox1.Location = new Point(34, 27);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(105, 105);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1829, 1170);
        Controls.Add(pnlContenu);
        Controls.Add(pnlMenu);
        Margin = new Padding(4, 5, 4, 5);
        MinimumSize = new Size(1562, 1096);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestion de l'université";
        Load += FrmMain_Load;
        pnlMenu.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private Panel pnlContenu;
    private Panel pnlMenu;
    private Label lblNomApp;
    private Button btnDashboard;
    private Button btnEtudiants;
    private Button btnInscriptions;
    private Button btnClasses;
    private Button btnPlanification;
    private Button btnAbsences;
    private Label lblUtilisateur;
    private BoutonArrondi btnDeconnexion;
    private PictureBox pictureBox1;
}
