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
        pnlHaut = new Panel();
        flpHaut = new FlowLayoutPanel();
        lblDate = new Label();
        pnlAnnee = new PanelArrondi();
        lblAnnee = new Label();
        btnTheme = new FontAwesome.Sharp.IconButton();
        pnlLigne = new Panel();
        lblPage = new Label();
        pnlMenu = new Panel();
        pnlItems = new Panel();
        lblSecPrincipal = new Label();
        btnDashboard = new FontAwesome.Sharp.IconButton();
        btnStatistiques = new FontAwesome.Sharp.IconButton();
        lblSecGestion = new Label();
        btnEtudiants = new FontAwesome.Sharp.IconButton();
        btnInscriptions = new FontAwesome.Sharp.IconButton();
        btnClasses = new FontAwesome.Sharp.IconButton();
        btnPlanification = new FontAwesome.Sharp.IconButton();
        btnAbsences = new FontAwesome.Sharp.IconButton();
        lblSecRef = new Label();
        btnEnseignants = new FontAwesome.Sharp.IconButton();
        btnMatieres = new FontAwesome.Sharp.IconButton();
        btnSalles = new FontAwesome.Sharp.IconButton();
        btnStructure = new FontAwesome.Sharp.IconButton();
        lblSecSysteme = new Label();
        btnUtilisateurs = new FontAwesome.Sharp.IconButton();
        btnParametres = new FontAwesome.Sharp.IconButton();
        pnlBas = new Panel();
        pnlAvatar = new PanelArrondi();
        lblInitiales = new Label();
        lblUtilisateur = new Label();
        lblRole = new Label();
        btnDeconnexion = new FontAwesome.Sharp.IconButton();
        pnlLogo = new Panel();
        picLogo = new PictureBox();
        lblNomApp = new Label();
        pnlHaut.SuspendLayout();
        flpHaut.SuspendLayout();
        pnlAnnee.SuspendLayout();
        pnlMenu.SuspendLayout();
        pnlItems.SuspendLayout();
        pnlBas.SuspendLayout();
        pnlAvatar.SuspendLayout();
        pnlLogo.SuspendLayout();
        SuspendLayout();
        //
        // pnlContenu
        //
        pnlContenu.BackColor = Color.FromArgb(246, 243, 242);
        pnlContenu.Dock = DockStyle.Fill;
        pnlContenu.Tag = "fond";
        pnlContenu.Name = "pnlContenu";
        pnlContenu.TabIndex = 0;
        //
        // pnlHaut
        //
        pnlHaut.BackColor = Color.FromArgb(255, 255, 255);
        pnlHaut.Dock = DockStyle.Top;
        pnlHaut.Size = new Size(1010, 64);
        pnlHaut.Tag = "carte";
        pnlHaut.Name = "pnlHaut";
        pnlHaut.TabIndex = 1;
        pnlHaut.Controls.Add(flpHaut);
        pnlHaut.Controls.Add(pnlLigne);
        pnlHaut.Controls.Add(lblPage);
        //
        // flpHaut
        //
        flpHaut.AutoSize = true;
        flpHaut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flpHaut.Dock = DockStyle.Right;
        flpHaut.FlowDirection = FlowDirection.LeftToRight;
        flpHaut.WrapContents = false;
        flpHaut.Size = new Size(100, 64);
        flpHaut.Name = "flpHaut";
        flpHaut.TabIndex = 2;
        flpHaut.Controls.Add(lblDate);
        flpHaut.Controls.Add(pnlAnnee);
        flpHaut.Controls.Add(btnTheme);
        //
        // lblDate
        //
        lblDate.AutoSize = true;
        lblDate.Text = "";
        lblDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblDate.ForeColor = Color.FromArgb(107, 96, 99);
        lblDate.Tag = "discret";
        lblDate.Location = new Point(0, 0);
        lblDate.Margin = new Padding(0, 20, 18, 0);
        lblDate.Name = "lblDate";
        lblDate.TabIndex = 3;
        //
        // pnlAnnee
        //
        pnlAnnee.BackColor = Color.FromArgb(246, 227, 231);
        pnlAnnee.Rayon = 17;
        pnlAnnee.Location = new Point(0, 0);
        pnlAnnee.Size = new Size(200, 34);
        pnlAnnee.Tag = "pastille";
        pnlAnnee.AfficherBordure = false;
        pnlAnnee.Margin = new Padding(0, 15, 14, 0);
        pnlAnnee.Name = "pnlAnnee";
        pnlAnnee.TabIndex = 4;
        pnlAnnee.Controls.Add(lblAnnee);
        //
        // lblAnnee
        //
        lblAnnee.AutoSize = false;
        lblAnnee.Dock = DockStyle.Fill;
        lblAnnee.Text = "Année";
        lblAnnee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblAnnee.ForeColor = Color.FromArgb(122, 20, 38);
        lblAnnee.Tag = "accent";
        lblAnnee.BackColor = Color.Transparent;
        lblAnnee.TextAlign = ContentAlignment.MiddleCenter;
        lblAnnee.Name = "lblAnnee";
        lblAnnee.TabIndex = 5;
        //
        // btnTheme
        //
        btnTheme.BackColor = Color.FromArgb(255, 255, 255);
        btnTheme.ForeColor = Color.FromArgb(27, 20, 22);
        btnTheme.Cursor = Cursors.Hand;
        btnTheme.FlatStyle = FlatStyle.Flat;
        btnTheme.FlatAppearance.BorderSize = 0;
        btnTheme.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnTheme.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        btnTheme.IconChar = (FontAwesome.Sharp.IconChar)0xf186;
        btnTheme.IconColor = Color.FromArgb(27, 20, 22);
        btnTheme.IconSize = 18;
        btnTheme.Location = new Point(0, 0);
        btnTheme.Size = new Size(44, 44);
        btnTheme.Text = "";
        btnTheme.UseVisualStyleBackColor = false;
        btnTheme.Tag = "icone";
        btnTheme.Margin = new Padding(0, 10, 18, 0);
        btnTheme.Name = "btnTheme";
        btnTheme.TabIndex = 6;
        //
        // pnlLigne
        //
        pnlLigne.BackColor = Color.FromArgb(239, 232, 234);
        pnlLigne.Dock = DockStyle.Bottom;
        pnlLigne.Size = new Size(1010, 1);
        pnlLigne.Tag = "bordure";
        pnlLigne.Name = "pnlLigne";
        pnlLigne.TabIndex = 7;
        //
        // lblPage
        //
        lblPage.AutoSize = false;
        lblPage.Location = new Point(28, 14);
        lblPage.Size = new Size(500, 36);
        lblPage.Text = "Tableau de bord";
        lblPage.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblPage.ForeColor = Color.FromArgb(27, 20, 22);
        lblPage.Tag = "texte";
        lblPage.TextAlign = ContentAlignment.MiddleLeft;
        lblPage.Name = "lblPage";
        lblPage.TabIndex = 8;
        //
        // pnlMenu
        //
        pnlMenu.BackColor = Color.FromArgb(27, 20, 22);
        pnlMenu.Dock = DockStyle.Left;
        pnlMenu.Size = new Size(270, 800);
        pnlMenu.Tag = "menu";
        pnlMenu.Name = "pnlMenu";
        pnlMenu.TabIndex = 9;
        pnlMenu.Controls.Add(pnlItems);
        pnlMenu.Controls.Add(pnlBas);
        pnlMenu.Controls.Add(pnlLogo);
        //
        // pnlItems
        //
        pnlItems.AutoScroll = true;
        pnlItems.BackColor = Color.FromArgb(27, 20, 22);
        pnlItems.Dock = DockStyle.Fill;
        pnlItems.Tag = "menu";
        pnlItems.Name = "pnlItems";
        pnlItems.TabIndex = 10;
        pnlItems.Controls.Add(lblSecPrincipal);
        pnlItems.Controls.Add(btnDashboard);
        pnlItems.Controls.Add(btnStatistiques);
        pnlItems.Controls.Add(lblSecGestion);
        pnlItems.Controls.Add(btnEtudiants);
        pnlItems.Controls.Add(btnInscriptions);
        pnlItems.Controls.Add(btnClasses);
        pnlItems.Controls.Add(btnPlanification);
        pnlItems.Controls.Add(btnAbsences);
        pnlItems.Controls.Add(lblSecRef);
        pnlItems.Controls.Add(btnEnseignants);
        pnlItems.Controls.Add(btnMatieres);
        pnlItems.Controls.Add(btnSalles);
        pnlItems.Controls.Add(btnStructure);
        pnlItems.Controls.Add(lblSecSysteme);
        pnlItems.Controls.Add(btnUtilisateurs);
        pnlItems.Controls.Add(btnParametres);
        //
        // lblSecPrincipal
        //
        lblSecPrincipal.AutoSize = false;
        lblSecPrincipal.Location = new Point(26, 8);
        lblSecPrincipal.Size = new Size(200, 18);
        lblSecPrincipal.Text = "PRINCIPAL";
        lblSecPrincipal.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSecPrincipal.ForeColor = Color.FromArgb(143, 130, 134);
        lblSecPrincipal.Name = "lblSecPrincipal";
        lblSecPrincipal.TabIndex = 11;
        //
        // btnDashboard
        //
        btnDashboard.BackColor = Color.FromArgb(27, 20, 22);
        btnDashboard.ForeColor = Color.FromArgb(214, 204, 207);
        btnDashboard.Cursor = Cursors.Hand;
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnDashboard.IconChar = (FontAwesome.Sharp.IconChar)0xf015;
        btnDashboard.IconColor = Color.FromArgb(214, 204, 207);
        btnDashboard.IconSize = 18;
        btnDashboard.Location = new Point(12, 28);
        btnDashboard.Size = new Size(234, 36);
        btnDashboard.Text = "Tableau de bord";
        btnDashboard.UseVisualStyleBackColor = false;
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnDashboard.Padding = new Padding(16, 0, 0, 0);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.TabIndex = 12;
        //
        // btnStatistiques
        //
        btnStatistiques.BackColor = Color.FromArgb(27, 20, 22);
        btnStatistiques.ForeColor = Color.FromArgb(214, 204, 207);
        btnStatistiques.Cursor = Cursors.Hand;
        btnStatistiques.FlatStyle = FlatStyle.Flat;
        btnStatistiques.FlatAppearance.BorderSize = 0;
        btnStatistiques.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnStatistiques.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnStatistiques.IconChar = (FontAwesome.Sharp.IconChar)0xf200;
        btnStatistiques.IconColor = Color.FromArgb(214, 204, 207);
        btnStatistiques.IconSize = 18;
        btnStatistiques.Location = new Point(12, 66);
        btnStatistiques.Size = new Size(234, 36);
        btnStatistiques.Text = "Statistiques";
        btnStatistiques.UseVisualStyleBackColor = false;
        btnStatistiques.ImageAlign = ContentAlignment.MiddleLeft;
        btnStatistiques.TextAlign = ContentAlignment.MiddleLeft;
        btnStatistiques.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStatistiques.Padding = new Padding(16, 0, 0, 0);
        btnStatistiques.Name = "btnStatistiques";
        btnStatistiques.TabIndex = 13;
        //
        // lblSecGestion
        //
        lblSecGestion.AutoSize = false;
        lblSecGestion.Location = new Point(26, 112);
        lblSecGestion.Size = new Size(200, 18);
        lblSecGestion.Text = "GESTION";
        lblSecGestion.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSecGestion.ForeColor = Color.FromArgb(143, 130, 134);
        lblSecGestion.Name = "lblSecGestion";
        lblSecGestion.TabIndex = 14;
        //
        // btnEtudiants
        //
        btnEtudiants.BackColor = Color.FromArgb(27, 20, 22);
        btnEtudiants.ForeColor = Color.FromArgb(214, 204, 207);
        btnEtudiants.Cursor = Cursors.Hand;
        btnEtudiants.FlatStyle = FlatStyle.Flat;
        btnEtudiants.FlatAppearance.BorderSize = 0;
        btnEtudiants.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnEtudiants.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnEtudiants.IconChar = (FontAwesome.Sharp.IconChar)0xf19d;
        btnEtudiants.IconColor = Color.FromArgb(214, 204, 207);
        btnEtudiants.IconSize = 18;
        btnEtudiants.Location = new Point(12, 132);
        btnEtudiants.Size = new Size(234, 36);
        btnEtudiants.Text = "Étudiants";
        btnEtudiants.UseVisualStyleBackColor = false;
        btnEtudiants.ImageAlign = ContentAlignment.MiddleLeft;
        btnEtudiants.TextAlign = ContentAlignment.MiddleLeft;
        btnEtudiants.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnEtudiants.Padding = new Padding(16, 0, 0, 0);
        btnEtudiants.Name = "btnEtudiants";
        btnEtudiants.TabIndex = 15;
        //
        // btnInscriptions
        //
        btnInscriptions.BackColor = Color.FromArgb(27, 20, 22);
        btnInscriptions.ForeColor = Color.FromArgb(214, 204, 207);
        btnInscriptions.Cursor = Cursors.Hand;
        btnInscriptions.FlatStyle = FlatStyle.Flat;
        btnInscriptions.FlatAppearance.BorderSize = 0;
        btnInscriptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnInscriptions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnInscriptions.IconChar = (FontAwesome.Sharp.IconChar)0xf46d;
        btnInscriptions.IconColor = Color.FromArgb(214, 204, 207);
        btnInscriptions.IconSize = 18;
        btnInscriptions.Location = new Point(12, 170);
        btnInscriptions.Size = new Size(234, 36);
        btnInscriptions.Text = "Inscriptions";
        btnInscriptions.UseVisualStyleBackColor = false;
        btnInscriptions.ImageAlign = ContentAlignment.MiddleLeft;
        btnInscriptions.TextAlign = ContentAlignment.MiddleLeft;
        btnInscriptions.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnInscriptions.Padding = new Padding(16, 0, 0, 0);
        btnInscriptions.Name = "btnInscriptions";
        btnInscriptions.TabIndex = 16;
        //
        // btnClasses
        //
        btnClasses.BackColor = Color.FromArgb(27, 20, 22);
        btnClasses.ForeColor = Color.FromArgb(214, 204, 207);
        btnClasses.Cursor = Cursors.Hand;
        btnClasses.FlatStyle = FlatStyle.Flat;
        btnClasses.FlatAppearance.BorderSize = 0;
        btnClasses.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnClasses.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnClasses.IconChar = (FontAwesome.Sharp.IconChar)0xf0c0;
        btnClasses.IconColor = Color.FromArgb(214, 204, 207);
        btnClasses.IconSize = 18;
        btnClasses.Location = new Point(12, 208);
        btnClasses.Size = new Size(234, 36);
        btnClasses.Text = "Classes et cours";
        btnClasses.UseVisualStyleBackColor = false;
        btnClasses.ImageAlign = ContentAlignment.MiddleLeft;
        btnClasses.TextAlign = ContentAlignment.MiddleLeft;
        btnClasses.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnClasses.Padding = new Padding(16, 0, 0, 0);
        btnClasses.Name = "btnClasses";
        btnClasses.TabIndex = 17;
        //
        // btnPlanification
        //
        btnPlanification.BackColor = Color.FromArgb(27, 20, 22);
        btnPlanification.ForeColor = Color.FromArgb(214, 204, 207);
        btnPlanification.Cursor = Cursors.Hand;
        btnPlanification.FlatStyle = FlatStyle.Flat;
        btnPlanification.FlatAppearance.BorderSize = 0;
        btnPlanification.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnPlanification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnPlanification.IconChar = (FontAwesome.Sharp.IconChar)0xf073;
        btnPlanification.IconColor = Color.FromArgb(214, 204, 207);
        btnPlanification.IconSize = 18;
        btnPlanification.Location = new Point(12, 246);
        btnPlanification.Size = new Size(234, 36);
        btnPlanification.Text = "Planification";
        btnPlanification.UseVisualStyleBackColor = false;
        btnPlanification.ImageAlign = ContentAlignment.MiddleLeft;
        btnPlanification.TextAlign = ContentAlignment.MiddleLeft;
        btnPlanification.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnPlanification.Padding = new Padding(16, 0, 0, 0);
        btnPlanification.Name = "btnPlanification";
        btnPlanification.TabIndex = 18;
        //
        // btnAbsences
        //
        btnAbsences.BackColor = Color.FromArgb(27, 20, 22);
        btnAbsences.ForeColor = Color.FromArgb(214, 204, 207);
        btnAbsences.Cursor = Cursors.Hand;
        btnAbsences.FlatStyle = FlatStyle.Flat;
        btnAbsences.FlatAppearance.BorderSize = 0;
        btnAbsences.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnAbsences.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnAbsences.IconChar = (FontAwesome.Sharp.IconChar)0xf235;
        btnAbsences.IconColor = Color.FromArgb(214, 204, 207);
        btnAbsences.IconSize = 18;
        btnAbsences.Location = new Point(12, 284);
        btnAbsences.Size = new Size(234, 36);
        btnAbsences.Text = "Absences";
        btnAbsences.UseVisualStyleBackColor = false;
        btnAbsences.ImageAlign = ContentAlignment.MiddleLeft;
        btnAbsences.TextAlign = ContentAlignment.MiddleLeft;
        btnAbsences.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnAbsences.Padding = new Padding(16, 0, 0, 0);
        btnAbsences.Name = "btnAbsences";
        btnAbsences.TabIndex = 19;
        //
        // lblSecRef
        //
        lblSecRef.AutoSize = false;
        lblSecRef.Location = new Point(26, 330);
        lblSecRef.Size = new Size(200, 18);
        lblSecRef.Text = "RÉFÉRENTIELS";
        lblSecRef.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSecRef.ForeColor = Color.FromArgb(143, 130, 134);
        lblSecRef.Name = "lblSecRef";
        lblSecRef.TabIndex = 20;
        //
        // btnEnseignants
        //
        btnEnseignants.BackColor = Color.FromArgb(27, 20, 22);
        btnEnseignants.ForeColor = Color.FromArgb(214, 204, 207);
        btnEnseignants.Cursor = Cursors.Hand;
        btnEnseignants.FlatStyle = FlatStyle.Flat;
        btnEnseignants.FlatAppearance.BorderSize = 0;
        btnEnseignants.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnEnseignants.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnEnseignants.IconChar = (FontAwesome.Sharp.IconChar)0xf51c;
        btnEnseignants.IconColor = Color.FromArgb(214, 204, 207);
        btnEnseignants.IconSize = 18;
        btnEnseignants.Location = new Point(12, 350);
        btnEnseignants.Size = new Size(234, 36);
        btnEnseignants.Text = "Enseignants";
        btnEnseignants.UseVisualStyleBackColor = false;
        btnEnseignants.ImageAlign = ContentAlignment.MiddleLeft;
        btnEnseignants.TextAlign = ContentAlignment.MiddleLeft;
        btnEnseignants.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnEnseignants.Padding = new Padding(16, 0, 0, 0);
        btnEnseignants.Name = "btnEnseignants";
        btnEnseignants.TabIndex = 21;
        //
        // btnMatieres
        //
        btnMatieres.BackColor = Color.FromArgb(27, 20, 22);
        btnMatieres.ForeColor = Color.FromArgb(214, 204, 207);
        btnMatieres.Cursor = Cursors.Hand;
        btnMatieres.FlatStyle = FlatStyle.Flat;
        btnMatieres.FlatAppearance.BorderSize = 0;
        btnMatieres.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnMatieres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnMatieres.IconChar = (FontAwesome.Sharp.IconChar)0xf02d;
        btnMatieres.IconColor = Color.FromArgb(214, 204, 207);
        btnMatieres.IconSize = 18;
        btnMatieres.Location = new Point(12, 388);
        btnMatieres.Size = new Size(234, 36);
        btnMatieres.Text = "Matières";
        btnMatieres.UseVisualStyleBackColor = false;
        btnMatieres.ImageAlign = ContentAlignment.MiddleLeft;
        btnMatieres.TextAlign = ContentAlignment.MiddleLeft;
        btnMatieres.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnMatieres.Padding = new Padding(16, 0, 0, 0);
        btnMatieres.Name = "btnMatieres";
        btnMatieres.TabIndex = 22;
        //
        // btnSalles
        //
        btnSalles.BackColor = Color.FromArgb(27, 20, 22);
        btnSalles.ForeColor = Color.FromArgb(214, 204, 207);
        btnSalles.Cursor = Cursors.Hand;
        btnSalles.FlatStyle = FlatStyle.Flat;
        btnSalles.FlatAppearance.BorderSize = 0;
        btnSalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnSalles.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnSalles.IconChar = (FontAwesome.Sharp.IconChar)0xf1ad;
        btnSalles.IconColor = Color.FromArgb(214, 204, 207);
        btnSalles.IconSize = 18;
        btnSalles.Location = new Point(12, 426);
        btnSalles.Size = new Size(234, 36);
        btnSalles.Text = "Salles";
        btnSalles.UseVisualStyleBackColor = false;
        btnSalles.ImageAlign = ContentAlignment.MiddleLeft;
        btnSalles.TextAlign = ContentAlignment.MiddleLeft;
        btnSalles.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSalles.Padding = new Padding(16, 0, 0, 0);
        btnSalles.Name = "btnSalles";
        btnSalles.TabIndex = 23;
        //
        // btnStructure
        //
        btnStructure.BackColor = Color.FromArgb(27, 20, 22);
        btnStructure.ForeColor = Color.FromArgb(214, 204, 207);
        btnStructure.Cursor = Cursors.Hand;
        btnStructure.FlatStyle = FlatStyle.Flat;
        btnStructure.FlatAppearance.BorderSize = 0;
        btnStructure.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnStructure.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnStructure.IconChar = (FontAwesome.Sharp.IconChar)0xf5fd;
        btnStructure.IconColor = Color.FromArgb(214, 204, 207);
        btnStructure.IconSize = 18;
        btnStructure.Location = new Point(12, 464);
        btnStructure.Size = new Size(234, 36);
        btnStructure.Text = "Structure académique";
        btnStructure.UseVisualStyleBackColor = false;
        btnStructure.ImageAlign = ContentAlignment.MiddleLeft;
        btnStructure.TextAlign = ContentAlignment.MiddleLeft;
        btnStructure.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStructure.Padding = new Padding(16, 0, 0, 0);
        btnStructure.Name = "btnStructure";
        btnStructure.TabIndex = 24;
        //
        // lblSecSysteme
        //
        lblSecSysteme.AutoSize = false;
        lblSecSysteme.Location = new Point(26, 510);
        lblSecSysteme.Size = new Size(200, 18);
        lblSecSysteme.Text = "SYSTÈME";
        lblSecSysteme.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
        lblSecSysteme.ForeColor = Color.FromArgb(143, 130, 134);
        lblSecSysteme.Name = "lblSecSysteme";
        lblSecSysteme.TabIndex = 25;
        //
        // btnUtilisateurs
        //
        btnUtilisateurs.BackColor = Color.FromArgb(27, 20, 22);
        btnUtilisateurs.ForeColor = Color.FromArgb(214, 204, 207);
        btnUtilisateurs.Cursor = Cursors.Hand;
        btnUtilisateurs.FlatStyle = FlatStyle.Flat;
        btnUtilisateurs.FlatAppearance.BorderSize = 0;
        btnUtilisateurs.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnUtilisateurs.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnUtilisateurs.IconChar = (FontAwesome.Sharp.IconChar)0xf2bd;
        btnUtilisateurs.IconColor = Color.FromArgb(214, 204, 207);
        btnUtilisateurs.IconSize = 18;
        btnUtilisateurs.Location = new Point(12, 530);
        btnUtilisateurs.Size = new Size(234, 36);
        btnUtilisateurs.Text = "Utilisateurs";
        btnUtilisateurs.UseVisualStyleBackColor = false;
        btnUtilisateurs.ImageAlign = ContentAlignment.MiddleLeft;
        btnUtilisateurs.TextAlign = ContentAlignment.MiddleLeft;
        btnUtilisateurs.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUtilisateurs.Padding = new Padding(16, 0, 0, 0);
        btnUtilisateurs.Name = "btnUtilisateurs";
        btnUtilisateurs.TabIndex = 26;
        //
        // btnParametres
        //
        btnParametres.BackColor = Color.FromArgb(27, 20, 22);
        btnParametres.ForeColor = Color.FromArgb(214, 204, 207);
        btnParametres.Cursor = Cursors.Hand;
        btnParametres.FlatStyle = FlatStyle.Flat;
        btnParametres.FlatAppearance.BorderSize = 0;
        btnParametres.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnParametres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnParametres.IconChar = (FontAwesome.Sharp.IconChar)0xf013;
        btnParametres.IconColor = Color.FromArgb(214, 204, 207);
        btnParametres.IconSize = 18;
        btnParametres.Location = new Point(12, 568);
        btnParametres.Size = new Size(234, 36);
        btnParametres.Text = "Paramètres";
        btnParametres.UseVisualStyleBackColor = false;
        btnParametres.ImageAlign = ContentAlignment.MiddleLeft;
        btnParametres.TextAlign = ContentAlignment.MiddleLeft;
        btnParametres.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnParametres.Padding = new Padding(16, 0, 0, 0);
        btnParametres.Name = "btnParametres";
        btnParametres.TabIndex = 27;
        //
        // pnlBas
        //
        pnlBas.BackColor = Color.FromArgb(27, 20, 22);
        pnlBas.Dock = DockStyle.Bottom;
        pnlBas.Size = new Size(270, 112);
        pnlBas.Tag = "menu";
        pnlBas.Name = "pnlBas";
        pnlBas.TabIndex = 28;
        pnlBas.Controls.Add(pnlAvatar);
        pnlBas.Controls.Add(lblUtilisateur);
        pnlBas.Controls.Add(lblRole);
        pnlBas.Controls.Add(btnDeconnexion);
        //
        // pnlAvatar
        //
        pnlAvatar.BackColor = Color.FromArgb(155, 27, 48);
        pnlAvatar.Rayon = 20;
        pnlAvatar.Location = new Point(20, 12);
        pnlAvatar.Size = new Size(40, 40);
        pnlAvatar.AfficherBordure = false;
        pnlAvatar.Name = "pnlAvatar";
        pnlAvatar.TabIndex = 29;
        pnlAvatar.Controls.Add(lblInitiales);
        //
        // lblInitiales
        //
        lblInitiales.AutoSize = false;
        lblInitiales.Dock = DockStyle.Fill;
        lblInitiales.Text = "?";
        lblInitiales.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblInitiales.ForeColor = Color.FromArgb(255, 255, 255);
        lblInitiales.BackColor = Color.Transparent;
        lblInitiales.TextAlign = ContentAlignment.MiddleCenter;
        lblInitiales.Name = "lblInitiales";
        lblInitiales.TabIndex = 30;
        //
        // lblUtilisateur
        //
        lblUtilisateur.AutoSize = false;
        lblUtilisateur.Location = new Point(72, 12);
        lblUtilisateur.Size = new Size(186, 22);
        lblUtilisateur.Text = "";
        lblUtilisateur.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblUtilisateur.ForeColor = Color.FromArgb(255, 255, 255);
        lblUtilisateur.Name = "lblUtilisateur";
        lblUtilisateur.TabIndex = 31;
        //
        // lblRole
        //
        lblRole.AutoSize = false;
        lblRole.Location = new Point(72, 34);
        lblRole.Size = new Size(186, 20);
        lblRole.Text = "";
        lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblRole.ForeColor = Color.FromArgb(168, 157, 161);
        lblRole.Name = "lblRole";
        lblRole.TabIndex = 32;
        //
        // btnDeconnexion
        //
        btnDeconnexion.BackColor = Color.FromArgb(27, 20, 22);
        btnDeconnexion.ForeColor = Color.FromArgb(214, 204, 207);
        btnDeconnexion.Cursor = Cursors.Hand;
        btnDeconnexion.FlatStyle = FlatStyle.Flat;
        btnDeconnexion.FlatAppearance.BorderSize = 0;
        btnDeconnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 36, 39);
        btnDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        btnDeconnexion.IconChar = (FontAwesome.Sharp.IconChar)0xf2f5;
        btnDeconnexion.IconColor = Color.FromArgb(214, 204, 207);
        btnDeconnexion.IconSize = 18;
        btnDeconnexion.Location = new Point(12, 62);
        btnDeconnexion.Size = new Size(234, 38);
        btnDeconnexion.Text = "Déconnexion";
        btnDeconnexion.UseVisualStyleBackColor = false;
        btnDeconnexion.ImageAlign = ContentAlignment.MiddleLeft;
        btnDeconnexion.TextAlign = ContentAlignment.MiddleLeft;
        btnDeconnexion.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnDeconnexion.Padding = new Padding(16, 0, 0, 0);
        btnDeconnexion.Name = "btnDeconnexion";
        btnDeconnexion.TabIndex = 33;
        //
        // pnlLogo
        //
        pnlLogo.BackColor = Color.FromArgb(27, 20, 22);
        pnlLogo.Dock = DockStyle.Top;
        pnlLogo.Size = new Size(270, 84);
        pnlLogo.Tag = "menu";
        pnlLogo.Name = "pnlLogo";
        pnlLogo.TabIndex = 34;
        pnlLogo.Controls.Add(picLogo);
        pnlLogo.Controls.Add(lblNomApp);
        //
        // picLogo
        //
        picLogo.Image = Properties.Resources.Logo_IIT_4x4;
        picLogo.Location = new Point(22, 18);
        picLogo.Size = new Size(42, 46);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabStop = false;
        picLogo.Name = "picLogo";
        picLogo.TabIndex = 35;
        //
        // lblNomApp
        //
        lblNomApp.AutoSize = false;
        lblNomApp.Location = new Point(76, 20);
        lblNomApp.Size = new Size(180, 44);
        lblNomApp.Text = "Gestion\r\nuniversitaire";
        lblNomApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
        lblNomApp.ForeColor = Color.FromArgb(255, 255, 255);
        lblNomApp.TextAlign = ContentAlignment.MiddleLeft;
        lblNomApp.Name = "lblNomApp";
        lblNomApp.TabIndex = 36;
        //
        // FrmMain
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        ClientSize = new Size(1280, 800);
        MinimumSize = new Size(1100, 680);
        StartPosition = FormStartPosition.CenterScreen;
        Tag = "fond";
        Text = "Gestion de l'université";
        Name = "FrmMain";
        Controls.Add(pnlContenu);
        Controls.Add(pnlHaut);
        Controls.Add(pnlMenu);
        btnTheme.Click += btnTheme_Click;
        btnDeconnexion.Click += btnDeconnexion_Click;
        Load += FrmMain_Load;
        pnlHaut.ResumeLayout(false);
        flpHaut.ResumeLayout(false);
        pnlAnnee.ResumeLayout(false);
        pnlMenu.ResumeLayout(false);
        pnlItems.ResumeLayout(false);
        pnlBas.ResumeLayout(false);
        pnlAvatar.ResumeLayout(false);
        pnlLogo.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel pnlContenu;
    private Panel pnlHaut;
    private FlowLayoutPanel flpHaut;
    private Label lblDate;
    private PanelArrondi pnlAnnee;
    private Label lblAnnee;
    private FontAwesome.Sharp.IconButton btnTheme;
    private Panel pnlLigne;
    private Label lblPage;
    private Panel pnlMenu;
    private Panel pnlItems;
    private Label lblSecPrincipal;
    private FontAwesome.Sharp.IconButton btnDashboard;
    private FontAwesome.Sharp.IconButton btnStatistiques;
    private Label lblSecGestion;
    private FontAwesome.Sharp.IconButton btnEtudiants;
    private FontAwesome.Sharp.IconButton btnInscriptions;
    private FontAwesome.Sharp.IconButton btnClasses;
    private FontAwesome.Sharp.IconButton btnPlanification;
    private FontAwesome.Sharp.IconButton btnAbsences;
    private Label lblSecRef;
    private FontAwesome.Sharp.IconButton btnEnseignants;
    private FontAwesome.Sharp.IconButton btnMatieres;
    private FontAwesome.Sharp.IconButton btnSalles;
    private FontAwesome.Sharp.IconButton btnStructure;
    private Label lblSecSysteme;
    private FontAwesome.Sharp.IconButton btnUtilisateurs;
    private FontAwesome.Sharp.IconButton btnParametres;
    private Panel pnlBas;
    private PanelArrondi pnlAvatar;
    private Label lblInitiales;
    private Label lblUtilisateur;
    private Label lblRole;
    private FontAwesome.Sharp.IconButton btnDeconnexion;
    private Panel pnlLogo;
    private PictureBox picLogo;
    private Label lblNomApp;
}
