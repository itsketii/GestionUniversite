using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmClasseDetail
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
        lblFiliere = new Label();
        cboFiliere = new ComboBox();
        lblNiveau = new Label();
        cboNiveau = new ComboBox();
        lblAnnee = new Label();
        cboAnnee = new ComboBox();
        lblLibelle = new Label();
        txtLibelle = new TextBox();
        lblAide = new Label();
        lblErreur = new Label();
        btnEnregistrer = new BoutonArrondi();
        btnAnnuler = new BoutonArrondi();
        SuspendLayout();
        //
        // lblTitreFiche
        //
        lblTitreFiche.AutoSize = false;
        lblTitreFiche.Location = new Point(24, 18);
        lblTitreFiche.Size = new Size(432, 34);
        lblTitreFiche.Text = "Nouvelle classe";
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.TabIndex = 0;
        //
        // lblFiliere
        //
        lblFiliere.AutoSize = false;
        lblFiliere.Location = new Point(24, 66);
        lblFiliere.Size = new Size(432, 20);
        lblFiliere.Text = "Filière *";
        lblFiliere.ForeColor = Color.FromArgb(27, 20, 22);
        lblFiliere.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblFiliere.Name = "lblFiliere";
        lblFiliere.Tag = "texte";
        lblFiliere.TabIndex = 1;
        //
        // cboFiliere
        //
        cboFiliere.DropDownStyle = ComboBoxStyle.DropDownList;
        cboFiliere.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboFiliere.Location = new Point(24, 88);
        cboFiliere.Size = new Size(432, 28);
        cboFiliere.Name = "cboFiliere";
        cboFiliere.Tag = "input";
        cboFiliere.TabIndex = 2;
        //
        // lblNiveau
        //
        lblNiveau.AutoSize = false;
        lblNiveau.Location = new Point(24, 134);
        lblNiveau.Size = new Size(208, 20);
        lblNiveau.Text = "Niveau *";
        lblNiveau.ForeColor = Color.FromArgb(27, 20, 22);
        lblNiveau.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNiveau.Name = "lblNiveau";
        lblNiveau.Tag = "texte";
        lblNiveau.TabIndex = 3;
        //
        // cboNiveau
        //
        cboNiveau.DropDownStyle = ComboBoxStyle.DropDownList;
        cboNiveau.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboNiveau.Location = new Point(24, 156);
        cboNiveau.Size = new Size(208, 28);
        cboNiveau.Name = "cboNiveau";
        cboNiveau.Tag = "input";
        cboNiveau.TabIndex = 4;
        //
        // lblAnnee
        //
        lblAnnee.AutoSize = false;
        lblAnnee.Location = new Point(248, 134);
        lblAnnee.Size = new Size(208, 20);
        lblAnnee.Text = "Année académique *";
        lblAnnee.ForeColor = Color.FromArgb(27, 20, 22);
        lblAnnee.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblAnnee.Name = "lblAnnee";
        lblAnnee.Tag = "texte";
        lblAnnee.TabIndex = 5;
        //
        // cboAnnee
        //
        cboAnnee.DropDownStyle = ComboBoxStyle.DropDownList;
        cboAnnee.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboAnnee.Location = new Point(248, 156);
        cboAnnee.Size = new Size(208, 28);
        cboAnnee.Name = "cboAnnee";
        cboAnnee.Tag = "input";
        cboAnnee.TabIndex = 6;
        //
        // lblLibelle
        //
        lblLibelle.AutoSize = false;
        lblLibelle.Location = new Point(24, 202);
        lblLibelle.Size = new Size(432, 20);
        lblLibelle.Text = "Libellé";
        lblLibelle.ForeColor = Color.FromArgb(27, 20, 22);
        lblLibelle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblLibelle.Name = "lblLibelle";
        lblLibelle.Tag = "texte";
        lblLibelle.TabIndex = 7;
        //
        // txtLibelle
        //
        txtLibelle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtLibelle.Location = new Point(24, 224);
        txtLibelle.Size = new Size(432, 26);
        txtLibelle.Name = "txtLibelle";
        txtLibelle.Tag = "input";
        txtLibelle.TabIndex = 8;
        //
        // lblAide
        //
        lblAide.AutoSize = false;
        lblAide.Location = new Point(24, 254);
        lblAide.Size = new Size(432, 20);
        lblAide.Text = "Laissez vide pour générer le libellé automatiquement.";
        lblAide.ForeColor = Color.FromArgb(107, 96, 99);
        lblAide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblAide.Name = "lblAide";
        lblAide.Tag = "discret";
        lblAide.TabIndex = 9;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(24, 284);
        lblErreur.Size = new Size(432, 24);
        lblErreur.Text = "";
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 10;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Location = new Point(24, 316);
        btnEnregistrer.Size = new Size(208, 42);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 11;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Location = new Point(248, 316);
        btnAnnuler.Size = new Size(208, 42);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.TabIndex = 12;
        //
        // FrmClasseDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(480, 380);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nouvelle classe";
        Tag = "carte";
        Name = "FrmClasseDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblFiliere);
        Controls.Add(cboFiliere);
        Controls.Add(lblNiveau);
        Controls.Add(cboNiveau);
        Controls.Add(lblAnnee);
        Controls.Add(cboAnnee);
        Controls.Add(lblLibelle);
        Controls.Add(txtLibelle);
        Controls.Add(lblAide);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblFiliere;
    private ComboBox cboFiliere;
    private Label lblNiveau;
    private ComboBox cboNiveau;
    private Label lblAnnee;
    private ComboBox cboAnnee;
    private Label lblLibelle;
    private TextBox txtLibelle;
    private Label lblAide;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
