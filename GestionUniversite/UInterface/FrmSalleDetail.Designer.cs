using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmSalleDetail
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
        lblCodeSalle = new Label();
        txtCodeSalle = new TextBox();
        lblCapacite = new Label();
        numCapacite = new NumericUpDown();
        lblTypeSalle = new Label();
        cboTypeSalle = new ComboBox();
        lblBatiment = new Label();
        txtBatiment = new TextBox();
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
        lblTitreFiche.Text = "Nouvelle salle";
        lblTitreFiche.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.TabIndex = 0;
        //
        // lblCodeSalle
        //
        lblCodeSalle.AutoSize = false;
        lblCodeSalle.Location = new Point(28, 76);
        lblCodeSalle.Size = new Size(240, 20);
        lblCodeSalle.Text = "Code *";
        lblCodeSalle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCodeSalle.ForeColor = Color.FromArgb(27, 20, 22);
        lblCodeSalle.Tag = "texte";
        lblCodeSalle.Name = "lblCodeSalle";
        lblCodeSalle.TabIndex = 1;
        //
        // txtCodeSalle
        //
        txtCodeSalle.BackColor = Color.FromArgb(255, 255, 255);
        txtCodeSalle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtCodeSalle.Location = new Point(28, 98);
        txtCodeSalle.Size = new Size(240, 28);
        txtCodeSalle.Tag = "input";
        txtCodeSalle.Name = "txtCodeSalle";
        txtCodeSalle.TabIndex = 2;
        //
        // lblCapacite
        //
        lblCapacite.AutoSize = false;
        lblCapacite.Location = new Point(292, 76);
        lblCapacite.Size = new Size(240, 20);
        lblCapacite.Text = "Capacité (places) *";
        lblCapacite.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCapacite.ForeColor = Color.FromArgb(27, 20, 22);
        lblCapacite.Tag = "texte";
        lblCapacite.Name = "lblCapacite";
        lblCapacite.TabIndex = 3;
        //
        // numCapacite
        //
        numCapacite.BackColor = Color.FromArgb(255, 255, 255);
        numCapacite.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        numCapacite.Location = new Point(292, 98);
        numCapacite.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numCapacite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numCapacite.Size = new Size(240, 27);
        numCapacite.Tag = "input";
        numCapacite.Value = new decimal(new int[] { 40, 0, 0, 0 });
        numCapacite.Name = "numCapacite";
        numCapacite.TabIndex = 4;
        //
        // lblTypeSalle
        //
        lblTypeSalle.AutoSize = false;
        lblTypeSalle.Location = new Point(28, 138);
        lblTypeSalle.Size = new Size(240, 20);
        lblTypeSalle.Text = "Type de salle *";
        lblTypeSalle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblTypeSalle.ForeColor = Color.FromArgb(27, 20, 22);
        lblTypeSalle.Tag = "texte";
        lblTypeSalle.Name = "lblTypeSalle";
        lblTypeSalle.TabIndex = 5;
        //
        // cboTypeSalle
        //
        cboTypeSalle.BackColor = Color.FromArgb(255, 255, 255);
        cboTypeSalle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTypeSalle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboTypeSalle.Location = new Point(28, 160);
        cboTypeSalle.Size = new Size(240, 28);
        cboTypeSalle.Tag = "input";
        cboTypeSalle.Items.AddRange(new object[] { "Amphi", "Salle de cours", "Laboratoire", "Salle informatique" });
        cboTypeSalle.Name = "cboTypeSalle";
        cboTypeSalle.TabIndex = 6;
        //
        // lblBatiment
        //
        lblBatiment.AutoSize = false;
        lblBatiment.Location = new Point(292, 138);
        lblBatiment.Size = new Size(240, 20);
        lblBatiment.Text = "Bâtiment";
        lblBatiment.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblBatiment.ForeColor = Color.FromArgb(27, 20, 22);
        lblBatiment.Tag = "texte";
        lblBatiment.Name = "lblBatiment";
        lblBatiment.TabIndex = 7;
        //
        // txtBatiment
        //
        txtBatiment.BackColor = Color.FromArgb(255, 255, 255);
        txtBatiment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtBatiment.Location = new Point(292, 160);
        txtBatiment.Size = new Size(240, 28);
        txtBatiment.Tag = "input";
        txtBatiment.Name = "txtBatiment";
        txtBatiment.TabIndex = 8;
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
        lblErreur.TabIndex = 9;
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
        btnEnregistrer.TabIndex = 10;
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
        btnAnnuler.TabIndex = 11;
        //
        // FrmSalleDetail
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
        Text = "Nouvelle salle";
        Name = "FrmSalleDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblCodeSalle);
        Controls.Add(txtCodeSalle);
        Controls.Add(lblCapacite);
        Controls.Add(numCapacite);
        Controls.Add(lblTypeSalle);
        Controls.Add(cboTypeSalle);
        Controls.Add(lblBatiment);
        Controls.Add(txtBatiment);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblCodeSalle;
    private TextBox txtCodeSalle;
    private Label lblCapacite;
    private NumericUpDown numCapacite;
    private Label lblTypeSalle;
    private ComboBox cboTypeSalle;
    private Label lblBatiment;
    private TextBox txtBatiment;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
