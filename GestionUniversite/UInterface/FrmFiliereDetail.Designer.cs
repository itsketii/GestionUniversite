using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmFiliereDetail
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
        lblCodeFiliere = new Label();
        txtCodeFiliere = new TextBox();
        lblLibelle = new Label();
        txtLibelle = new TextBox();
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
        lblTitreFiche.Text = "Nouvelle filière";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblCodeFiliere
        //
        lblCodeFiliere.AutoSize = false;
        lblCodeFiliere.Location = new Point(28, 76);
        lblCodeFiliere.Size = new Size(240, 20);
        lblCodeFiliere.Text = "Code *";
        lblCodeFiliere.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCodeFiliere.ForeColor = Color.FromArgb(27, 20, 22);
        lblCodeFiliere.Tag = "texte";
        lblCodeFiliere.Name = "lblCodeFiliere";
        lblCodeFiliere.TabIndex = 1;
        //
        // txtCodeFiliere
        //
        txtCodeFiliere.BackColor = Color.FromArgb(255, 255, 255);
        txtCodeFiliere.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtCodeFiliere.Location = new Point(28, 98);
        txtCodeFiliere.Size = new Size(240, 28);
        txtCodeFiliere.Tag = "input";
        txtCodeFiliere.Name = "txtCodeFiliere";
        txtCodeFiliere.TabIndex = 2;
        //
        // lblLibelle
        //
        lblLibelle.AutoSize = false;
        lblLibelle.Location = new Point(28, 138);
        lblLibelle.Size = new Size(504, 20);
        lblLibelle.Text = "Libellé *";
        lblLibelle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblLibelle.ForeColor = Color.FromArgb(27, 20, 22);
        lblLibelle.Tag = "texte";
        lblLibelle.Name = "lblLibelle";
        lblLibelle.TabIndex = 3;
        //
        // txtLibelle
        //
        txtLibelle.BackColor = Color.FromArgb(255, 255, 255);
        txtLibelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtLibelle.Location = new Point(28, 160);
        txtLibelle.Size = new Size(504, 28);
        txtLibelle.Tag = "input";
        txtLibelle.Name = "txtLibelle";
        txtLibelle.TabIndex = 4;
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
        lblErreur.TabIndex = 5;
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
        btnEnregistrer.TabIndex = 6;
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
        btnAnnuler.TabIndex = 7;
        //
        // FrmFiliereDetail
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
        Text = "Nouvelle filière";
        Name = "FrmFiliereDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblCodeFiliere);
        Controls.Add(txtCodeFiliere);
        Controls.Add(lblLibelle);
        Controls.Add(txtLibelle);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblCodeFiliere;
    private TextBox txtCodeFiliere;
    private Label lblLibelle;
    private TextBox txtLibelle;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
