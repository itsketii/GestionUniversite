using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmEtudiantDetail
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
        lblNaissance = new Label();
        dtpNaissance = new DateTimePicker();
        lblNom = new Label();
        txtNom = new TextBox();
        lblPrenoms = new Label();
        txtPrenoms = new TextBox();
        lblLieu = new Label();
        txtLieu = new TextBox();
        lblSexe = new Label();
        cboSexe = new ComboBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblTelephone = new Label();
        txtTelephone = new TextBox();
        lblAdresse = new Label();
        txtAdresse = new TextBox();
        lblErreur = new Label();
        btnEnregistrer = new BoutonArrondi();
        btnAnnuler = new BoutonArrondi();
        SuspendLayout();
        //
        // lblTitreFiche
        //
        lblTitreFiche.AutoSize = false;
        lblTitreFiche.Location = new Point(24, 18);
        lblTitreFiche.Size = new Size(472, 34);
        lblTitreFiche.Text = "Fiche étudiant";
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.TabIndex = 0;
        //
        // lblMatricule
        //
        lblMatricule.AutoSize = false;
        lblMatricule.Location = new Point(24, 70);
        lblMatricule.Size = new Size(224, 20);
        lblMatricule.Text = "Matricule *";
        lblMatricule.ForeColor = Color.FromArgb(27, 20, 22);
        lblMatricule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblMatricule.Name = "lblMatricule";
        lblMatricule.Tag = "texte";
        lblMatricule.TabIndex = 1;
        //
        // txtMatricule
        //
        txtMatricule.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtMatricule.Location = new Point(24, 92);
        txtMatricule.Size = new Size(224, 26);
        txtMatricule.Name = "txtMatricule";
        txtMatricule.Tag = "input";
        txtMatricule.TabIndex = 2;
        //
        // lblNaissance
        //
        lblNaissance.AutoSize = false;
        lblNaissance.Location = new Point(272, 70);
        lblNaissance.Size = new Size(224, 20);
        lblNaissance.Text = "Date de naissance *";
        lblNaissance.ForeColor = Color.FromArgb(27, 20, 22);
        lblNaissance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNaissance.Name = "lblNaissance";
        lblNaissance.Tag = "texte";
        lblNaissance.TabIndex = 3;
        //
        // dtpNaissance
        //
        dtpNaissance.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpNaissance.Format = DateTimePickerFormat.Short;
        dtpNaissance.Location = new Point(272, 92);
        dtpNaissance.Size = new Size(224, 26);
        dtpNaissance.Name = "dtpNaissance";
        dtpNaissance.Tag = "input";
        dtpNaissance.TabIndex = 4;
        //
        // lblNom
        //
        lblNom.AutoSize = false;
        lblNom.Location = new Point(24, 130);
        lblNom.Size = new Size(224, 20);
        lblNom.Text = "Nom *";
        lblNom.ForeColor = Color.FromArgb(27, 20, 22);
        lblNom.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNom.Name = "lblNom";
        lblNom.Tag = "texte";
        lblNom.TabIndex = 5;
        //
        // txtNom
        //
        txtNom.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtNom.Location = new Point(24, 152);
        txtNom.Size = new Size(224, 26);
        txtNom.Name = "txtNom";
        txtNom.Tag = "input";
        txtNom.TabIndex = 6;
        //
        // lblPrenoms
        //
        lblPrenoms.AutoSize = false;
        lblPrenoms.Location = new Point(272, 130);
        lblPrenoms.Size = new Size(224, 20);
        lblPrenoms.Text = "Prénoms *";
        lblPrenoms.ForeColor = Color.FromArgb(27, 20, 22);
        lblPrenoms.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblPrenoms.Name = "lblPrenoms";
        lblPrenoms.Tag = "texte";
        lblPrenoms.TabIndex = 7;
        //
        // txtPrenoms
        //
        txtPrenoms.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtPrenoms.Location = new Point(272, 152);
        txtPrenoms.Size = new Size(224, 26);
        txtPrenoms.Name = "txtPrenoms";
        txtPrenoms.Tag = "input";
        txtPrenoms.TabIndex = 8;
        //
        // lblLieu
        //
        lblLieu.AutoSize = false;
        lblLieu.Location = new Point(24, 190);
        lblLieu.Size = new Size(224, 20);
        lblLieu.Text = "Lieu de naissance";
        lblLieu.ForeColor = Color.FromArgb(27, 20, 22);
        lblLieu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblLieu.Name = "lblLieu";
        lblLieu.Tag = "texte";
        lblLieu.TabIndex = 9;
        //
        // txtLieu
        //
        txtLieu.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtLieu.Location = new Point(24, 212);
        txtLieu.Size = new Size(224, 26);
        txtLieu.Name = "txtLieu";
        txtLieu.Tag = "input";
        txtLieu.TabIndex = 10;
        //
        // lblSexe
        //
        lblSexe.AutoSize = false;
        lblSexe.Location = new Point(272, 190);
        lblSexe.Size = new Size(224, 20);
        lblSexe.Text = "Sexe *";
        lblSexe.ForeColor = Color.FromArgb(27, 20, 22);
        lblSexe.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblSexe.Name = "lblSexe";
        lblSexe.Tag = "texte";
        lblSexe.TabIndex = 11;
        //
        // cboSexe
        //
        cboSexe.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSexe.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboSexe.Items.AddRange(new object[] { "M", "F" });
        cboSexe.Location = new Point(272, 212);
        cboSexe.Size = new Size(224, 28);
        cboSexe.Name = "cboSexe";
        cboSexe.Tag = "input";
        cboSexe.TabIndex = 12;
        //
        // lblEmail
        //
        lblEmail.AutoSize = false;
        lblEmail.Location = new Point(24, 250);
        lblEmail.Size = new Size(224, 20);
        lblEmail.Text = "E-mail *";
        lblEmail.ForeColor = Color.FromArgb(27, 20, 22);
        lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblEmail.Name = "lblEmail";
        lblEmail.Tag = "texte";
        lblEmail.TabIndex = 13;
        //
        // txtEmail
        //
        txtEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtEmail.Location = new Point(24, 272);
        txtEmail.Size = new Size(224, 26);
        txtEmail.Name = "txtEmail";
        txtEmail.Tag = "input";
        txtEmail.TabIndex = 14;
        //
        // lblTelephone
        //
        lblTelephone.AutoSize = false;
        lblTelephone.Location = new Point(272, 250);
        lblTelephone.Size = new Size(224, 20);
        lblTelephone.Text = "Téléphone";
        lblTelephone.ForeColor = Color.FromArgb(27, 20, 22);
        lblTelephone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblTelephone.Name = "lblTelephone";
        lblTelephone.Tag = "texte";
        lblTelephone.TabIndex = 15;
        //
        // txtTelephone
        //
        txtTelephone.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtTelephone.Location = new Point(272, 272);
        txtTelephone.Size = new Size(224, 26);
        txtTelephone.Name = "txtTelephone";
        txtTelephone.Tag = "input";
        txtTelephone.TabIndex = 16;
        //
        // lblAdresse
        //
        lblAdresse.AutoSize = false;
        lblAdresse.Location = new Point(24, 310);
        lblAdresse.Size = new Size(472, 20);
        lblAdresse.Text = "Adresse";
        lblAdresse.ForeColor = Color.FromArgb(27, 20, 22);
        lblAdresse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblAdresse.Name = "lblAdresse";
        lblAdresse.Tag = "texte";
        lblAdresse.TabIndex = 17;
        //
        // txtAdresse
        //
        txtAdresse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtAdresse.Location = new Point(24, 332);
        txtAdresse.Size = new Size(472, 26);
        txtAdresse.Name = "txtAdresse";
        txtAdresse.Tag = "input";
        txtAdresse.TabIndex = 18;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(24, 372);
        lblErreur.Size = new Size(472, 24);
        lblErreur.Text = "";
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 19;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Location = new Point(24, 404);
        btnEnregistrer.Size = new Size(224, 42);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 20;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Location = new Point(272, 404);
        btnAnnuler.Size = new Size(224, 42);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.TabIndex = 21;
        //
        // FrmEtudiantDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(520, 470);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Étudiant";
        Tag = "carte";
        Name = "FrmEtudiantDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblMatricule);
        Controls.Add(txtMatricule);
        Controls.Add(lblNaissance);
        Controls.Add(dtpNaissance);
        Controls.Add(lblNom);
        Controls.Add(txtNom);
        Controls.Add(lblPrenoms);
        Controls.Add(txtPrenoms);
        Controls.Add(lblLieu);
        Controls.Add(txtLieu);
        Controls.Add(lblSexe);
        Controls.Add(cboSexe);
        Controls.Add(lblEmail);
        Controls.Add(txtEmail);
        Controls.Add(lblTelephone);
        Controls.Add(txtTelephone);
        Controls.Add(lblAdresse);
        Controls.Add(txtAdresse);
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
    private Label lblNaissance;
    private DateTimePicker dtpNaissance;
    private Label lblNom;
    private TextBox txtNom;
    private Label lblPrenoms;
    private TextBox txtPrenoms;
    private Label lblLieu;
    private TextBox txtLieu;
    private Label lblSexe;
    private ComboBox cboSexe;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblTelephone;
    private TextBox txtTelephone;
    private Label lblAdresse;
    private TextBox txtAdresse;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
