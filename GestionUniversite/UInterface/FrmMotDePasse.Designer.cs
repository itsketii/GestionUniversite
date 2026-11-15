using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmMotDePasse
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
        lblAncien = new Label();
        txtAncien = new TextBox();
        lblNouveau = new Label();
        txtNouveau = new TextBox();
        lblConfirmer = new Label();
        txtConfirmer = new TextBox();
        lblErreur = new Label();
        btnEnregistrer = new BoutonArrondi();
        btnAnnuler = new BoutonArrondi();
        SuspendLayout();
        //
        // lblTitreFiche
        //
        lblTitreFiche.AutoSize = false;
        lblTitreFiche.Location = new Point(28, 20);
        lblTitreFiche.Size = new Size(464, 36);
        lblTitreFiche.Text = "Changer mon mot de passe";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblAncien
        //
        lblAncien.AutoSize = false;
        lblAncien.Location = new Point(28, 76);
        lblAncien.Size = new Size(464, 20);
        lblAncien.Text = "Mot de passe actuel *";
        lblAncien.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblAncien.ForeColor = Color.FromArgb(27, 20, 22);
        lblAncien.Tag = "texte";
        lblAncien.Name = "lblAncien";
        lblAncien.TabIndex = 1;
        //
        // txtAncien
        //
        txtAncien.BackColor = Color.FromArgb(255, 255, 255);
        txtAncien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtAncien.Location = new Point(28, 98);
        txtAncien.Size = new Size(464, 28);
        txtAncien.Tag = "input";
        txtAncien.UseSystemPasswordChar = true;
        txtAncien.Name = "txtAncien";
        txtAncien.TabIndex = 2;
        //
        // lblNouveau
        //
        lblNouveau.AutoSize = false;
        lblNouveau.Location = new Point(28, 138);
        lblNouveau.Size = new Size(464, 20);
        lblNouveau.Text = "Nouveau mot de passe (8 caractères minimum) *";
        lblNouveau.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblNouveau.ForeColor = Color.FromArgb(27, 20, 22);
        lblNouveau.Tag = "texte";
        lblNouveau.Name = "lblNouveau";
        lblNouveau.TabIndex = 3;
        //
        // txtNouveau
        //
        txtNouveau.BackColor = Color.FromArgb(255, 255, 255);
        txtNouveau.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtNouveau.Location = new Point(28, 160);
        txtNouveau.Size = new Size(464, 28);
        txtNouveau.Tag = "input";
        txtNouveau.UseSystemPasswordChar = true;
        txtNouveau.Name = "txtNouveau";
        txtNouveau.TabIndex = 4;
        //
        // lblConfirmer
        //
        lblConfirmer.AutoSize = false;
        lblConfirmer.Location = new Point(28, 200);
        lblConfirmer.Size = new Size(464, 20);
        lblConfirmer.Text = "Confirmer le nouveau mot de passe *";
        lblConfirmer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblConfirmer.ForeColor = Color.FromArgb(27, 20, 22);
        lblConfirmer.Tag = "texte";
        lblConfirmer.Name = "lblConfirmer";
        lblConfirmer.TabIndex = 5;
        //
        // txtConfirmer
        //
        txtConfirmer.BackColor = Color.FromArgb(255, 255, 255);
        txtConfirmer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtConfirmer.Location = new Point(28, 222);
        txtConfirmer.Size = new Size(464, 28);
        txtConfirmer.Tag = "input";
        txtConfirmer.UseSystemPasswordChar = true;
        txtConfirmer.Name = "txtConfirmer";
        txtConfirmer.TabIndex = 6;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(28, 262);
        lblErreur.Size = new Size(464, 44);
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
        btnEnregistrer.Location = new Point(28, 314);
        btnEnregistrer.Size = new Size(220, 44);
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 8;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Location = new Point(272, 314);
        btnAnnuler.Size = new Size(220, 44);
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.TabIndex = 9;
        //
        // FrmMotDePasse
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(520, 386);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Tag = "carte";
        Text = "Changer mon mot de passe";
        Name = "FrmMotDePasse";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblAncien);
        Controls.Add(txtAncien);
        Controls.Add(lblNouveau);
        Controls.Add(txtNouveau);
        Controls.Add(lblConfirmer);
        Controls.Add(txtConfirmer);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblAncien;
    private TextBox txtAncien;
    private Label lblNouveau;
    private TextBox txtNouveau;
    private Label lblConfirmer;
    private TextBox txtConfirmer;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
