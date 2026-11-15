using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmMatiereDetail
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
        lblCodeMatiere = new Label();
        txtCodeMatiere = new TextBox();
        lblCredits = new Label();
        numCredits = new NumericUpDown();
        lblIntitule = new Label();
        txtIntitule = new TextBox();
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
        lblTitreFiche.Text = "Nouvelle matière";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblCodeMatiere
        //
        lblCodeMatiere.AutoSize = false;
        lblCodeMatiere.Location = new Point(28, 76);
        lblCodeMatiere.Size = new Size(240, 20);
        lblCodeMatiere.Text = "Code *";
        lblCodeMatiere.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCodeMatiere.ForeColor = Color.FromArgb(27, 20, 22);
        lblCodeMatiere.Tag = "texte";
        lblCodeMatiere.Name = "lblCodeMatiere";
        lblCodeMatiere.TabIndex = 1;
        //
        // txtCodeMatiere
        //
        txtCodeMatiere.BackColor = Color.FromArgb(255, 255, 255);
        txtCodeMatiere.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtCodeMatiere.Location = new Point(28, 98);
        txtCodeMatiere.Size = new Size(240, 28);
        txtCodeMatiere.Tag = "input";
        txtCodeMatiere.Name = "txtCodeMatiere";
        txtCodeMatiere.TabIndex = 2;
        //
        // lblCredits
        //
        lblCredits.AutoSize = false;
        lblCredits.Location = new Point(292, 76);
        lblCredits.Size = new Size(240, 20);
        lblCredits.Text = "Crédits *";
        lblCredits.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCredits.ForeColor = Color.FromArgb(27, 20, 22);
        lblCredits.Tag = "texte";
        lblCredits.Name = "lblCredits";
        lblCredits.TabIndex = 3;
        //
        // numCredits
        //
        numCredits.BackColor = Color.FromArgb(255, 255, 255);
        numCredits.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        numCredits.Location = new Point(292, 98);
        numCredits.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        numCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCredits.Size = new Size(240, 27);
        numCredits.Tag = "input";
        numCredits.Value = new decimal(new int[] { 4, 0, 0, 0 });
        numCredits.Name = "numCredits";
        numCredits.TabIndex = 4;
        //
        // lblIntitule
        //
        lblIntitule.AutoSize = false;
        lblIntitule.Location = new Point(28, 138);
        lblIntitule.Size = new Size(504, 20);
        lblIntitule.Text = "Intitulé *";
        lblIntitule.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblIntitule.ForeColor = Color.FromArgb(27, 20, 22);
        lblIntitule.Tag = "texte";
        lblIntitule.Name = "lblIntitule";
        lblIntitule.TabIndex = 5;
        //
        // txtIntitule
        //
        txtIntitule.BackColor = Color.FromArgb(255, 255, 255);
        txtIntitule.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtIntitule.Location = new Point(28, 160);
        txtIntitule.Size = new Size(504, 28);
        txtIntitule.Tag = "input";
        txtIntitule.Name = "txtIntitule";
        txtIntitule.TabIndex = 6;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(28, 200);
        lblErreur.Size = new Size(504, 44);
        lblErreur.Text = "";
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 7;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Location = new Point(28, 252);
        btnEnregistrer.Size = new Size(240, 44);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 8;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Location = new Point(292, 252);
        btnAnnuler.Size = new Size(240, 44);
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.TabIndex = 9;
        //
        // FrmMatiereDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(560, 324);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Nouvelle matière";
        Name = "FrmMatiereDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblCodeMatiere);
        Controls.Add(txtCodeMatiere);
        Controls.Add(lblCredits);
        Controls.Add(numCredits);
        Controls.Add(lblIntitule);
        Controls.Add(txtIntitule);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblCodeMatiere;
    private TextBox txtCodeMatiere;
    private Label lblCredits;
    private NumericUpDown numCredits;
    private Label lblIntitule;
    private TextBox txtIntitule;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
