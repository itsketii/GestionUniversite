using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmEnseignantDetail
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
        lblMatricule = new Label();
        txtMatricule = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblNom = new Label();
        txtNom = new TextBox();
        lblPrenoms = new Label();
        txtPrenoms = new TextBox();
        lblTelephone = new Label();
        txtTelephone = new TextBox();
        lblGrade = new Label();
        txtGrade = new TextBox();
        lblSpecialite = new Label();
        txtSpecialite = new TextBox();
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
        lblTitreFiche.Text = "Nouvel enseignant";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblMatricule
        //
        lblMatricule.AutoSize = false;
        lblMatricule.Location = new Point(28, 76);
        lblMatricule.Size = new Size(240, 20);
        lblMatricule.Text = "Matricule *";
        lblMatricule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblMatricule.ForeColor = Color.FromArgb(27, 20, 22);
        lblMatricule.Tag = "texte";
        lblMatricule.Name = "lblMatricule";
        lblMatricule.TabIndex = 1;
        //
        // txtMatricule
        //
        txtMatricule.BackColor = Color.FromArgb(255, 255, 255);
        txtMatricule.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtMatricule.Location = new Point(28, 98);
        txtMatricule.Size = new Size(240, 28);
        txtMatricule.Tag = "input";
        txtMatricule.Name = "txtMatricule";
        txtMatricule.TabIndex = 2;
        //
        // lblEmail
        //
        lblEmail.AutoSize = false;
        lblEmail.Location = new Point(292, 76);
        lblEmail.Size = new Size(240, 20);
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
        txtEmail.Location = new Point(292, 98);
        txtEmail.Size = new Size(240, 28);
        txtEmail.Tag = "input";
        txtEmail.Name = "txtEmail";
        txtEmail.TabIndex = 4;
        //
        // lblNom
        //
        lblNom.AutoSize = false;
        lblNom.Location = new Point(28, 138);
        lblNom.Size = new Size(240, 20);
        lblNom.Text = "Nom *";
        lblNom.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNom.ForeColor = Color.FromArgb(27, 20, 22);
        lblNom.Tag = "texte";
        lblNom.Name = "lblNom";
        lblNom.TabIndex = 5;
        //
        // txtNom
        //
        txtNom.BackColor = Color.FromArgb(255, 255, 255);
        txtNom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtNom.Location = new Point(28, 160);
        txtNom.Size = new Size(240, 28);
        txtNom.Tag = "input";
        txtNom.Name = "txtNom";
        txtNom.TabIndex = 6;
        //
        // lblPrenoms
        //
        lblPrenoms.AutoSize = false;
        lblPrenoms.Location = new Point(292, 138);
        lblPrenoms.Size = new Size(240, 20);
        lblPrenoms.Text = "Prénoms *";
        lblPrenoms.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblPrenoms.ForeColor = Color.FromArgb(27, 20, 22);
        lblPrenoms.Tag = "texte";
        lblPrenoms.Name = "lblPrenoms";
        lblPrenoms.TabIndex = 7;
        //
        // txtPrenoms
        //
        txtPrenoms.BackColor = Color.FromArgb(255, 255, 255);
        txtPrenoms.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtPrenoms.Location = new Point(292, 160);
        txtPrenoms.Size = new Size(240, 28);
        txtPrenoms.Tag = "input";
        txtPrenoms.Name = "txtPrenoms";
        txtPrenoms.TabIndex = 8;
        //
        // lblTelephone
        //
        lblTelephone.AutoSize = false;
        lblTelephone.Location = new Point(28, 200);
        lblTelephone.Size = new Size(240, 20);
        lblTelephone.Text = "Téléphone";
        lblTelephone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblTelephone.ForeColor = Color.FromArgb(27, 20, 22);
        lblTelephone.Tag = "texte";
        lblTelephone.Name = "lblTelephone";
        lblTelephone.TabIndex = 9;
        //
        // txtTelephone
        //
        txtTelephone.BackColor = Color.FromArgb(255, 255, 255);
        txtTelephone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtTelephone.Location = new Point(28, 222);
        txtTelephone.Size = new Size(240, 28);
        txtTelephone.Tag = "input";
        txtTelephone.Name = "txtTelephone";
        txtTelephone.TabIndex = 10;
        //
        // lblGrade
        //
        lblGrade.AutoSize = false;
        lblGrade.Location = new Point(292, 200);
        lblGrade.Size = new Size(240, 20);
        lblGrade.Text = "Grade";
        lblGrade.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblGrade.ForeColor = Color.FromArgb(27, 20, 22);
        lblGrade.Tag = "texte";
        lblGrade.Name = "lblGrade";
        lblGrade.TabIndex = 11;
        //
        // txtGrade
        //
        txtGrade.BackColor = Color.FromArgb(255, 255, 255);
        txtGrade.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtGrade.Location = new Point(292, 222);
        txtGrade.Size = new Size(240, 28);
        txtGrade.Tag = "input";
        txtGrade.Name = "txtGrade";
        txtGrade.TabIndex = 12;
        //
        // lblSpecialite
        //
        lblSpecialite.AutoSize = false;
        lblSpecialite.Location = new Point(28, 262);
        lblSpecialite.Size = new Size(504, 20);
        lblSpecialite.Text = "Spécialité";
        lblSpecialite.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblSpecialite.ForeColor = Color.FromArgb(27, 20, 22);
        lblSpecialite.Tag = "texte";
        lblSpecialite.Name = "lblSpecialite";
        lblSpecialite.TabIndex = 13;
        //
        // txtSpecialite
        //
        txtSpecialite.BackColor = Color.FromArgb(255, 255, 255);
        txtSpecialite.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtSpecialite.Location = new Point(28, 284);
        txtSpecialite.Size = new Size(504, 28);
        txtSpecialite.Tag = "input";
        txtSpecialite.Name = "txtSpecialite";
        txtSpecialite.TabIndex = 14;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(28, 324);
        lblErreur.Size = new Size(504, 44);
        lblErreur.Text = "";
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 15;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Location = new Point(28, 376);
        btnEnregistrer.Size = new Size(240, 44);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 16;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Location = new Point(292, 376);
        btnAnnuler.Size = new Size(240, 44);
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.TabIndex = 17;
        //
        // FrmEnseignantDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(560, 448);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Nouvel enseignant";
        Name = "FrmEnseignantDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblMatricule);
        Controls.Add(txtMatricule);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblNom);
        Controls.Add(txtNom);
        Controls.Add(lblPrenoms);
        Controls.Add(txtPrenoms);
        Controls.Add(lblTelephone);
        Controls.Add(txtTelephone);
        Controls.Add(lblGrade);
        Controls.Add(txtGrade);
        Controls.Add(lblSpecialite);
        Controls.Add(txtSpecialite);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblMatricule;
    private TextBox txtMatricule;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblNom;
    private TextBox txtNom;
    private Label lblPrenoms;
    private TextBox txtPrenoms;
    private Label lblTelephone;
    private TextBox txtTelephone;
    private Label lblGrade;
    private TextBox txtGrade;
    private Label lblSpecialite;
    private TextBox txtSpecialite;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
