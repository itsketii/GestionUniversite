using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmLogin
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlDroite = new Panel();
        pictureBox2 = new PictureBox();
        boutonArrondi1 = new BoutonArrondi();
        lblTitre = new Label();
        lblSousTitre = new Label();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblMotDePasse = new Label();
        txtMotDePasse = new TextBox();
        lblErreur = new Label();
        btnConnexion = new BoutonArrondi();
        pnlGauche = new Panel();
        pictureBox3 = new PictureBox();
        picCampus = new PictureBox();
        lblSlogan = new Label();
        lblImage = new Label();
        pnlDroite.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        pnlGauche.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCampus).BeginInit();
        picCampus.SuspendLayout();
        SuspendLayout();
        // 
        // pnlDroite
        // 
        pnlDroite.BackColor = Color.FromArgb(255, 255, 255);
        pnlDroite.Controls.Add(pictureBox2);
        pnlDroite.Controls.Add(boutonArrondi1);
        pnlDroite.Controls.Add(lblTitre);
        pnlDroite.Controls.Add(lblSousTitre);
        pnlDroite.Controls.Add(lblEmail);
        pnlDroite.Controls.Add(txtEmail);
        pnlDroite.Controls.Add(lblMotDePasse);
        pnlDroite.Controls.Add(txtMotDePasse);
        pnlDroite.Controls.Add(lblErreur);
        pnlDroite.Controls.Add(btnConnexion);
        pnlDroite.Dock = DockStyle.Fill;
        pnlDroite.Location = new Point(686, 0);
        pnlDroite.Margin = new Padding(4, 5, 4, 5);
        pnlDroite.Name = "pnlDroite";
        pnlDroite.Size = new Size(743, 1033);
        pnlDroite.TabIndex = 0;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.Logo_IIT;
        pictureBox2.Location = new Point(122, 124);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(505, 150);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 12;
        pictureBox2.TabStop = false;
        // 
        // boutonArrondi1
        // 
        boutonArrondi1.BackColor = Color.FromArgb(155, 27, 48);
        boutonArrondi1.FlatStyle = FlatStyle.Flat;
        boutonArrondi1.Font = new Font("Segoe UI Semibold", 10F);
        boutonArrondi1.ForeColor = Color.FromArgb(255, 255, 255);
        boutonArrondi1.Location = new Point(114, 876);
        boutonArrondi1.Margin = new Padding(4, 5, 4, 5);
        boutonArrondi1.Name = "boutonArrondi1";
        boutonArrondi1.Size = new Size(514, 77);
        boutonArrondi1.TabIndex = 10;
        boutonArrondi1.Text = "Quitter";
        boutonArrondi1.UseVisualStyleBackColor = false;
        boutonArrondi1.Click += boutonArrondi1_Click;
        // 
        // lblTitre
        // 
        lblTitre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre.Location = new Point(114, 307);
        lblTitre.Margin = new Padding(4, 0, 4, 0);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(514, 73);
        lblTitre.TabIndex = 2;
        lblTitre.Text = "Connexion";
        // 
        // lblSousTitre
        // 
        lblSousTitre.Font = new Font("Segoe UI", 10F);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Location = new Point(114, 387);
        lblSousTitre.Margin = new Padding(4, 0, 4, 0);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.Size = new Size(514, 40);
        lblSousTitre.TabIndex = 3;
        lblSousTitre.Text = "Accédez à la gestion de l’université.";
        // 
        // lblEmail
        // 
        lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblEmail.ForeColor = Color.FromArgb(27, 20, 22);
        lblEmail.Location = new Point(114, 473);
        lblEmail.Margin = new Padding(4, 0, 4, 0);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(514, 37);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Adresse e-mail";
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 11F);
        txtEmail.Location = new Point(114, 513);
        txtEmail.Margin = new Padding(4, 5, 4, 5);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "nom@iit.ci";
        txtEmail.Size = new Size(513, 37);
        txtEmail.TabIndex = 5;
        txtEmail.Text = "admin@iit.ci";
        // 
        // lblMotDePasse
        // 
        lblMotDePasse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblMotDePasse.ForeColor = Color.FromArgb(27, 20, 22);
        lblMotDePasse.Location = new Point(114, 597);
        lblMotDePasse.Margin = new Padding(4, 0, 4, 0);
        lblMotDePasse.Name = "lblMotDePasse";
        lblMotDePasse.Size = new Size(514, 37);
        lblMotDePasse.TabIndex = 6;
        lblMotDePasse.Text = "Mot de passe";
        // 
        // txtMotDePasse
        // 
        txtMotDePasse.Font = new Font("Segoe UI", 11F);
        txtMotDePasse.Location = new Point(114, 637);
        txtMotDePasse.Margin = new Padding(4, 5, 4, 5);
        txtMotDePasse.Name = "txtMotDePasse";
        txtMotDePasse.Size = new Size(513, 37);
        txtMotDePasse.TabIndex = 7;
        txtMotDePasse.Text = "Admin@2026";
        txtMotDePasse.UseSystemPasswordChar = true;
        // 
        // lblErreur
        // 
        lblErreur.Font = new Font("Segoe UI", 9.5F);
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Location = new Point(114, 707);
        lblErreur.Margin = new Padding(4, 0, 4, 0);
        lblErreur.Name = "lblErreur";
        lblErreur.Size = new Size(514, 60);
        lblErreur.TabIndex = 8;
        // 
        // btnConnexion
        // 
        btnConnexion.BackColor = Color.FromArgb(155, 27, 48);
        btnConnexion.FlatStyle = FlatStyle.Flat;
        btnConnexion.Font = new Font("Segoe UI Semibold", 10F);
        btnConnexion.ForeColor = Color.FromArgb(255, 255, 255);
        btnConnexion.Location = new Point(114, 780);
        btnConnexion.Margin = new Padding(4, 5, 4, 5);
        btnConnexion.Name = "btnConnexion";
        btnConnexion.Size = new Size(514, 77);
        btnConnexion.TabIndex = 9;
        btnConnexion.Text = "Se connecter";
        btnConnexion.UseVisualStyleBackColor = false;
        btnConnexion.Click += btnConnexion_Click;
        // 
        // pnlGauche
        // 
        pnlGauche.BackColor = Color.FromArgb(155, 27, 48);
        pnlGauche.Controls.Add(pictureBox3);
        pnlGauche.Controls.Add(picCampus);
        pnlGauche.Dock = DockStyle.Left;
        pnlGauche.Location = new Point(0, 0);
        pnlGauche.Margin = new Padding(4, 5, 4, 5);
        pnlGauche.Name = "pnlGauche";
        pnlGauche.Size = new Size(686, 1033);
        pnlGauche.TabIndex = 10;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.IIT_School;
        pictureBox3.Location = new Point(69, 173);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(557, 367);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 13;
        pictureBox3.TabStop = false;
        // 
        // picCampus
        // 
        picCampus.BackColor = Color.FromArgb(155, 27, 48);
        picCampus.Controls.Add(lblSlogan);
        picCampus.Controls.Add(lblImage);
        picCampus.Dock = DockStyle.Fill;
        picCampus.Location = new Point(0, 0);
        picCampus.Margin = new Padding(4, 5, 4, 5);
        picCampus.Name = "picCampus";
        picCampus.Size = new Size(686, 1033);
        picCampus.SizeMode = PictureBoxSizeMode.Zoom;
        picCampus.TabIndex = 11;
        picCampus.TabStop = false;
        picCampus.Click += picCampus_Click;
        // 
        // lblSlogan
        // 
        lblSlogan.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblSlogan.ForeColor = Color.FromArgb(255, 255, 255);
        lblSlogan.Location = new Point(69, 633);
        lblSlogan.Margin = new Padding(4, 0, 4, 0);
        lblSlogan.Name = "lblSlogan";
        lblSlogan.Size = new Size(557, 183);
        lblSlogan.TabIndex = 12;
        lblSlogan.Text = "Votre université, en un seul espace.";
        // 
        // lblImage
        // 
        lblImage.Font = new Font("Segoe UI", 10F);
        lblImage.ForeColor = Color.FromArgb(246, 213, 219);
        lblImage.Location = new Point(69, 900);
        lblImage.Margin = new Padding(4, 0, 4, 0);
        lblImage.Name = "lblImage";
        lblImage.Size = new Size(429, 40);
        lblImage.TabIndex = 13;
        lblImage.Text = "[Image campus IIT]";
        // 
        // FrmLogin
        // 
        AcceptButton = btnConnexion;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1429, 1033);
        Controls.Add(pnlDroite);
        Controls.Add(pnlGauche);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 5, 4, 5);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Connexion - Gestion de l'université";
        pnlDroite.ResumeLayout(false);
        pnlDroite.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        pnlGauche.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCampus).EndInit();
        picCampus.ResumeLayout(false);
        ResumeLayout(false);
    }

    private Panel pnlDroite;
    private Label lblTitre;
    private Label lblSousTitre;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblMotDePasse;
    private TextBox txtMotDePasse;
    private Label lblErreur;
    private BoutonArrondi btnConnexion;
    private Panel pnlGauche;
    private PictureBox picCampus;
    private Label lblSlogan;
    private Label lblImage;
    private BoutonArrondi boutonArrondi1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
}
