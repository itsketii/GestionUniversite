using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmUtilisateurDetail
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitreFiche = new Label();
        lblNomComplet = new Label();
        txtNomComplet = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblRole = new Label();
        cboRole = new ComboBox();
        lblMotDePasse = new Label();
        txtMotDePasse = new TextBox();
        chkActif = new CheckBox();
        lblErreur = new Label();
        btnEnregistrer = new BoutonArrondi();
        btnAnnuler = new BoutonArrondi();
        SuspendLayout();
        //
        // lblTitreFiche
        //
        lblTitreFiche.AutoSize = false;
        lblTitreFiche.Location = new Point(28, 20);
        lblTitreFiche.Size = new Size(504, 36);
        lblTitreFiche.Text = "Nouvel utilisateur";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblNomComplet
        //
        lblNomComplet.AutoSize = false;
        lblNomComplet.Location = new Point(28, 76);
        lblNomComplet.Size = new Size(504, 20);
        lblNomComplet.Text = "Nom complet *";
        lblNomComplet.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNomComplet.ForeColor = Color.FromArgb(27, 20, 22);
        lblNomComplet.Tag = "texte";
        lblNomComplet.Name = "lblNomComplet";
        lblNomComplet.TabIndex = 1;
        //
        // txtNomComplet
        //
        txtNomComplet.BackColor = Color.FromArgb(255, 255, 255);
        txtNomComplet.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtNomComplet.Location = new Point(28, 98);
        txtNomComplet.Size = new Size(504, 28);
        txtNomComplet.Tag = "input";
        txtNomComplet.Name = "txtNomComplet";
        txtNomComplet.TabIndex = 2;
        //
        // lblEmail
        //
        lblEmail.AutoSize = false;
        lblEmail.Location = new Point(28, 138);
        lblEmail.Size = new Size(504, 20);
        lblEmail.Text = "E-mail *";
        lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblEmail.ForeColor = Color.FromArgb(27, 20, 22);
        lblEmail.Tag = "texte";
        lblEmail.Name = "lblEmail";
        lblEmail.TabIndex = 3;
        //
        // txtEmail
        //
        txtEmail.BackColor = Color.FromArgb(255, 255, 255);
        txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtEmail.Location = new Point(28, 160);
        txtEmail.Size = new Size(504, 28);
        txtEmail.Tag = "input";
        txtEmail.Name = "txtEmail";
        txtEmail.TabIndex = 4;
        //
        // lblRole
        //
        lblRole.AutoSize = false;
        lblRole.Location = new Point(28, 200);
        lblRole.Size = new Size(240, 20);
        lblRole.Text = "Rôle *";
        lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblRole.ForeColor = Color.FromArgb(27, 20, 22);
        lblRole.Tag = "texte";
        lblRole.Name = "lblRole";
        lblRole.TabIndex = 5;
        //
        // cboRole
        //
        cboRole.BackColor = Color.FromArgb(255, 255, 255);
        cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRole.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboRole.Location = new Point(28, 222);
        cboRole.Size = new Size(240, 28);
        cboRole.Tag = "input";
        cboRole.Items.AddRange(new object[] { "Administrateur", "Scolarité", "Enseignant" });
        cboRole.Name = "cboRole";
        cboRole.TabIndex = 6;
        //
        // lblMotDePasse
        //
        lblMotDePasse.AutoSize = false;
        lblMotDePasse.Location = new Point(292, 200);
        lblMotDePasse.Size = new Size(240, 20);
        lblMotDePasse.Text = "Mot de passe";
        lblMotDePasse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblMotDePasse.ForeColor = Color.FromArgb(27, 20, 22);
        lblMotDePasse.Tag = "texte";
        lblMotDePasse.Name = "lblMotDePasse";
        lblMotDePasse.TabIndex = 7;
        //
        // txtMotDePasse
        //
        txtMotDePasse.BackColor = Color.FromArgb(255, 255, 255);
        txtMotDePasse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtMotDePasse.Location = new Point(292, 222);
        txtMotDePasse.Size = new Size(240, 28);
        txtMotDePasse.Tag = "input";
        txtMotDePasse.UseSystemPasswordChar = true;
        txtMotDePasse.Name = "txtMotDePasse";
        txtMotDePasse.TabIndex = 8;
        //
        // chkActif
        //
        chkActif.AutoSize = true;
        chkActif.BackColor = Color.Transparent;
        chkActif.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        chkActif.ForeColor = Color.FromArgb(27, 20, 22);
        chkActif.Location = new Point(28, 266);
        chkActif.Text = "Compte actif";
        chkActif.Tag = "texte";
        chkActif.Name = "chkActif";
        chkActif.TabIndex = 9;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(28, 302);
        lblErreur.Size = new Size(504, 44);
        lblErreur.Text = "";
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 10;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Location = new Point(28, 354);
        btnEnregistrer.Size = new Size(240, 44);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 11;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Location = new Point(292, 354);
        btnAnnuler.Size = new Size(240, 44);
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.TabIndex = 12;
        //
        // FrmUtilisateurDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(560, 426);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Nouvel utilisateur";
        Name = "FrmUtilisateurDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblNomComplet);
        Controls.Add(txtNomComplet);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblRole);
        Controls.Add(cboRole);
        Controls.Add(lblMotDePasse);
        Controls.Add(txtMotDePasse);
        Controls.Add(chkActif);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblNomComplet;
    private TextBox txtNomComplet;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblRole;
    private ComboBox cboRole;
    private Label lblMotDePasse;
    private TextBox txtMotDePasse;
    private CheckBox chkActif;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
