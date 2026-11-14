using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmCoursDetail
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
        lblMatiere = new Label();
        cboMatiere = new ComboBox();
        lblEnseignant = new Label();
        cboEnseignant = new ComboBox();
        lblVolume = new Label();
        numVolume = new NumericUpDown();
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
        lblTitreFiche.Text = "Ajouter un cours";
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.TabIndex = 0;
        //
        // lblMatiere
        //
        lblMatiere.AutoSize = false;
        lblMatiere.Location = new Point(24, 66);
        lblMatiere.Size = new Size(432, 20);
        lblMatiere.Text = "Matière *";
        lblMatiere.ForeColor = Color.FromArgb(27, 20, 22);
        lblMatiere.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblMatiere.Name = "lblMatiere";
        lblMatiere.Tag = "texte";
        lblMatiere.TabIndex = 1;
        //
        // cboMatiere
        //
        cboMatiere.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMatiere.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboMatiere.Location = new Point(24, 88);
        cboMatiere.Size = new Size(432, 28);
        cboMatiere.Name = "cboMatiere";
        cboMatiere.Tag = "input";
        cboMatiere.TabIndex = 2;
        //
        // lblEnseignant
        //
        lblEnseignant.AutoSize = false;
        lblEnseignant.Location = new Point(24, 134);
        lblEnseignant.Size = new Size(432, 20);
        lblEnseignant.Text = "Enseignant *";
        lblEnseignant.ForeColor = Color.FromArgb(27, 20, 22);
        lblEnseignant.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblEnseignant.Name = "lblEnseignant";
        lblEnseignant.Tag = "texte";
        lblEnseignant.TabIndex = 3;
        //
        // cboEnseignant
        //
        cboEnseignant.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEnseignant.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboEnseignant.Location = new Point(24, 156);
        cboEnseignant.Size = new Size(432, 28);
        cboEnseignant.Name = "cboEnseignant";
        cboEnseignant.Tag = "input";
        cboEnseignant.TabIndex = 4;
        //
        // lblVolume
        //
        lblVolume.AutoSize = false;
        lblVolume.Location = new Point(24, 202);
        lblVolume.Size = new Size(300, 20);
        lblVolume.Text = "Volume horaire (heures)";
        lblVolume.ForeColor = Color.FromArgb(27, 20, 22);
        lblVolume.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblVolume.Name = "lblVolume";
        lblVolume.Tag = "texte";
        lblVolume.TabIndex = 5;
        //
        // numVolume
        //
        numVolume.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        numVolume.Location = new Point(24, 224);
        numVolume.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        numVolume.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numVolume.Size = new Size(160, 26);
        numVolume.Value = new decimal(new int[] { 30, 0, 0, 0 });
        numVolume.Name = "numVolume";
        numVolume.Tag = "input";
        numVolume.TabIndex = 6;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(24, 262);
        lblErreur.Size = new Size(432, 24);
        lblErreur.Text = "";
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 7;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Location = new Point(24, 294);
        btnEnregistrer.Size = new Size(208, 42);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 8;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Location = new Point(248, 294);
        btnAnnuler.Size = new Size(208, 42);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.TabIndex = 9;
        //
        // FrmCoursDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(480, 360);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Ajouter un cours";
        Tag = "carte";
        Name = "FrmCoursDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblMatiere);
        Controls.Add(cboMatiere);
        Controls.Add(lblEnseignant);
        Controls.Add(cboEnseignant);
        Controls.Add(lblVolume);
        Controls.Add(numVolume);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblMatiere;
    private ComboBox cboMatiere;
    private Label lblEnseignant;
    private ComboBox cboEnseignant;
    private Label lblVolume;
    private NumericUpDown numVolume;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
