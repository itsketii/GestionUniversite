using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmInscriptionDetail
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
        lblEtudiant = new Label();
        cboEtudiant = new ComboBox();
        lblClasse = new Label();
        cboClasse = new ComboBox();
        lblFrais = new Label();
        numFrais = new NumericUpDown();
        chkValider = new CheckBox();
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
        lblTitreFiche.Text = "Nouvelle inscription";
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.TabIndex = 0;
        //
        // lblEtudiant
        //
        lblEtudiant.AutoSize = false;
        lblEtudiant.Location = new Point(24, 66);
        lblEtudiant.Size = new Size(432, 20);
        lblEtudiant.Text = "Étudiant *";
        lblEtudiant.ForeColor = Color.FromArgb(27, 20, 22);
        lblEtudiant.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblEtudiant.Name = "lblEtudiant";
        lblEtudiant.Tag = "texte";
        lblEtudiant.TabIndex = 1;
        //
        // cboEtudiant
        //
        cboEtudiant.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEtudiant.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboEtudiant.Location = new Point(24, 88);
        cboEtudiant.Size = new Size(432, 28);
        cboEtudiant.Name = "cboEtudiant";
        cboEtudiant.Tag = "input";
        cboEtudiant.TabIndex = 2;
        //
        // lblClasse
        //
        lblClasse.AutoSize = false;
        lblClasse.Location = new Point(24, 136);
        lblClasse.Size = new Size(432, 20);
        lblClasse.Text = "Classe (année active) *";
        lblClasse.ForeColor = Color.FromArgb(27, 20, 22);
        lblClasse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblClasse.Name = "lblClasse";
        lblClasse.Tag = "texte";
        lblClasse.TabIndex = 3;
        //
        // cboClasse
        //
        cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
        cboClasse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboClasse.Location = new Point(24, 158);
        cboClasse.Size = new Size(432, 28);
        cboClasse.Name = "cboClasse";
        cboClasse.Tag = "input";
        cboClasse.TabIndex = 4;
        //
        // lblFrais
        //
        lblFrais.AutoSize = false;
        lblFrais.Location = new Point(24, 206);
        lblFrais.Size = new Size(300, 20);
        lblFrais.Text = "Frais d’inscription (FCFA)";
        lblFrais.ForeColor = Color.FromArgb(27, 20, 22);
        lblFrais.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblFrais.Name = "lblFrais";
        lblFrais.Tag = "texte";
        lblFrais.TabIndex = 5;
        //
        // numFrais
        //
        numFrais.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        numFrais.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
        numFrais.Location = new Point(24, 228);
        numFrais.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        numFrais.Size = new Size(200, 26);
        numFrais.ThousandsSeparator = true;
        numFrais.Name = "numFrais";
        numFrais.Tag = "input";
        numFrais.TabIndex = 6;
        //
        // chkValider
        //
        chkValider.AutoSize = true;
        chkValider.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        chkValider.Location = new Point(24, 276);
        chkValider.Text = "Valider immédiatement";
        chkValider.Name = "chkValider";
        chkValider.Tag = "texte";
        chkValider.TabIndex = 7;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(24, 310);
        lblErreur.Size = new Size(432, 24);
        lblErreur.Text = "";
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 8;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Location = new Point(24, 344);
        btnEnregistrer.Size = new Size(208, 42);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 9;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Location = new Point(248, 344);
        btnAnnuler.Size = new Size(208, 42);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.TabIndex = 10;
        //
        // FrmInscriptionDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(480, 410);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nouvelle inscription";
        Tag = "carte";
        Name = "FrmInscriptionDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblEtudiant);
        Controls.Add(cboEtudiant);
        Controls.Add(lblClasse);
        Controls.Add(cboClasse);
        Controls.Add(lblFrais);
        Controls.Add(numFrais);
        Controls.Add(chkValider);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblEtudiant;
    private ComboBox cboEtudiant;
    private Label lblClasse;
    private ComboBox cboClasse;
    private Label lblFrais;
    private NumericUpDown numFrais;
    private CheckBox chkValider;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
