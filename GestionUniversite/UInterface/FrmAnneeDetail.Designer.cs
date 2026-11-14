using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmAnneeDetail
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
        lblLibelle = new Label();
        txtLibelle = new TextBox();
        lblDateDebut = new Label();
        dtpDateDebut = new DateTimePicker();
        lblDateFin = new Label();
        dtpDateFin = new DateTimePicker();
        chkEstActive = new CheckBox();
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
        lblTitreFiche.Text = "Nouvelle année académique";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblLibelle
        //
        lblLibelle.AutoSize = false;
        lblLibelle.Location = new Point(28, 76);
        lblLibelle.Size = new Size(504, 20);
        lblLibelle.Text = "Libellé (ex. 2026-2027) *";
        lblLibelle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblLibelle.ForeColor = Color.FromArgb(27, 20, 22);
        lblLibelle.Tag = "texte";
        lblLibelle.Name = "lblLibelle";
        lblLibelle.TabIndex = 1;
        //
        // txtLibelle
        //
        txtLibelle.BackColor = Color.FromArgb(255, 255, 255);
        txtLibelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtLibelle.Location = new Point(28, 98);
        txtLibelle.Size = new Size(504, 28);
        txtLibelle.Tag = "input";
        txtLibelle.Name = "txtLibelle";
        txtLibelle.TabIndex = 2;
        //
        // lblDateDebut
        //
        lblDateDebut.AutoSize = false;
        lblDateDebut.Location = new Point(28, 138);
        lblDateDebut.Size = new Size(240, 20);
        lblDateDebut.Text = "Début *";
        lblDateDebut.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblDateDebut.ForeColor = Color.FromArgb(27, 20, 22);
        lblDateDebut.Tag = "texte";
        lblDateDebut.Name = "lblDateDebut";
        lblDateDebut.TabIndex = 3;
        //
        // dtpDateDebut
        //
        dtpDateDebut.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpDateDebut.Format = DateTimePickerFormat.Short;
        dtpDateDebut.Location = new Point(28, 160);
        dtpDateDebut.Size = new Size(240, 27);
        dtpDateDebut.Name = "dtpDateDebut";
        dtpDateDebut.TabIndex = 4;
        //
        // lblDateFin
        //
        lblDateFin.AutoSize = false;
        lblDateFin.Location = new Point(292, 138);
        lblDateFin.Size = new Size(240, 20);
        lblDateFin.Text = "Fin *";
        lblDateFin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblDateFin.ForeColor = Color.FromArgb(27, 20, 22);
        lblDateFin.Tag = "texte";
        lblDateFin.Name = "lblDateFin";
        lblDateFin.TabIndex = 5;
        //
        // dtpDateFin
        //
        dtpDateFin.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpDateFin.Format = DateTimePickerFormat.Short;
        dtpDateFin.Location = new Point(292, 160);
        dtpDateFin.Size = new Size(240, 27);
        dtpDateFin.Name = "dtpDateFin";
        dtpDateFin.TabIndex = 6;
        //
        // chkEstActive
        //
        chkEstActive.AutoSize = true;
        chkEstActive.BackColor = Color.Transparent;
        chkEstActive.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        chkEstActive.ForeColor = Color.FromArgb(27, 20, 22);
        chkEstActive.Location = new Point(28, 204);
        chkEstActive.Text = "Année académique active (une seule à la fois)";
        chkEstActive.Tag = "texte";
        chkEstActive.Name = "chkEstActive";
        chkEstActive.TabIndex = 7;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(28, 240);
        lblErreur.Size = new Size(504, 44);
        lblErreur.Text = "";
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 8;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Location = new Point(28, 292);
        btnEnregistrer.Size = new Size(240, 44);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 9;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Location = new Point(292, 292);
        btnAnnuler.Size = new Size(240, 44);
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.TabIndex = 10;
        //
        // FrmAnneeDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(560, 364);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Nouvelle année académique";
        Name = "FrmAnneeDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblLibelle);
        Controls.Add(txtLibelle);
        Controls.Add(lblDateDebut);
        Controls.Add(dtpDateDebut);
        Controls.Add(lblDateFin);
        Controls.Add(dtpDateFin);
        Controls.Add(chkEstActive);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblLibelle;
    private TextBox txtLibelle;
    private Label lblDateDebut;
    private DateTimePicker dtpDateDebut;
    private Label lblDateFin;
    private DateTimePicker dtpDateFin;
    private CheckBox chkEstActive;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
