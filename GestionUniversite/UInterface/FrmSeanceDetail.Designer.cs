using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class FrmSeanceDetail
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
        lblClasse = new Label();
        cboClasse = new ComboBox();
        lblCours = new Label();
        cboCours = new ComboBox();
        lblDate = new Label();
        dtpDate = new DateTimePicker();
        lblType = new Label();
        cboType = new ComboBox();
        lblDebut = new Label();
        dtpDebut = new DateTimePicker();
        lblFin = new Label();
        dtpFin = new DateTimePicker();
        lblSalle = new Label();
        cboSalle = new ComboBox();
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
        lblTitreFiche.Text = "Planifier une séance";
        lblTitreFiche.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitreFiche.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitreFiche.Name = "lblTitreFiche";
        lblTitreFiche.Tag = "texte";
        lblTitreFiche.TabIndex = 0;
        //
        // lblClasse
        //
        lblClasse.AutoSize = false;
        lblClasse.Location = new Point(24, 66);
        lblClasse.Size = new Size(472, 20);
        lblClasse.Text = "Classe *";
        lblClasse.ForeColor = Color.FromArgb(27, 20, 22);
        lblClasse.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblClasse.Name = "lblClasse";
        lblClasse.Tag = "texte";
        lblClasse.TabIndex = 1;
        //
        // cboClasse
        //
        cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
        cboClasse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboClasse.Location = new Point(24, 88);
        cboClasse.Size = new Size(472, 28);
        cboClasse.Name = "cboClasse";
        cboClasse.Tag = "input";
        cboClasse.TabIndex = 2;
        //
        // lblCours
        //
        lblCours.AutoSize = false;
        lblCours.Location = new Point(24, 136);
        lblCours.Size = new Size(472, 20);
        lblCours.Text = "Cours (matière - enseignant) *";
        lblCours.ForeColor = Color.FromArgb(27, 20, 22);
        lblCours.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblCours.Name = "lblCours";
        lblCours.Tag = "texte";
        lblCours.TabIndex = 3;
        //
        // cboCours
        //
        cboCours.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCours.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboCours.Location = new Point(24, 158);
        cboCours.Size = new Size(472, 28);
        cboCours.Name = "cboCours";
        cboCours.Tag = "input";
        cboCours.TabIndex = 4;
        //
        // lblDate
        //
        lblDate.AutoSize = false;
        lblDate.Location = new Point(24, 206);
        lblDate.Size = new Size(224, 20);
        lblDate.Text = "Date *";
        lblDate.ForeColor = Color.FromArgb(27, 20, 22);
        lblDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblDate.Name = "lblDate";
        lblDate.Tag = "texte";
        lblDate.TabIndex = 5;
        //
        // dtpDate
        //
        dtpDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpDate.Format = DateTimePickerFormat.Short;
        dtpDate.Location = new Point(24, 228);
        dtpDate.Size = new Size(224, 26);
        dtpDate.Name = "dtpDate";
        dtpDate.Tag = "input";
        dtpDate.TabIndex = 6;
        //
        // lblType
        //
        lblType.AutoSize = false;
        lblType.Location = new Point(272, 206);
        lblType.Size = new Size(224, 20);
        lblType.Text = "Type *";
        lblType.ForeColor = Color.FromArgb(27, 20, 22);
        lblType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblType.Name = "lblType";
        lblType.Tag = "texte";
        lblType.TabIndex = 7;
        //
        // cboType
        //
        cboType.DropDownStyle = ComboBoxStyle.DropDownList;
        cboType.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboType.Items.AddRange(new object[] { "CM", "TD", "TP" });
        cboType.Location = new Point(272, 228);
        cboType.Size = new Size(224, 28);
        cboType.Name = "cboType";
        cboType.Tag = "input";
        cboType.TabIndex = 8;
        //
        // lblDebut
        //
        lblDebut.AutoSize = false;
        lblDebut.Location = new Point(24, 276);
        lblDebut.Size = new Size(224, 20);
        lblDebut.Text = "Début *";
        lblDebut.ForeColor = Color.FromArgb(27, 20, 22);
        lblDebut.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblDebut.Name = "lblDebut";
        lblDebut.Tag = "texte";
        lblDebut.TabIndex = 9;
        //
        // dtpDebut
        //
        dtpDebut.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpDebut.Format = DateTimePickerFormat.Time;
        dtpDebut.Location = new Point(24, 298);
        dtpDebut.ShowUpDown = true;
        dtpDebut.Size = new Size(224, 26);
        dtpDebut.Name = "dtpDebut";
        dtpDebut.Tag = "input";
        dtpDebut.TabIndex = 10;
        //
        // lblFin
        //
        lblFin.AutoSize = false;
        lblFin.Location = new Point(272, 276);
        lblFin.Size = new Size(224, 20);
        lblFin.Text = "Fin *";
        lblFin.ForeColor = Color.FromArgb(27, 20, 22);
        lblFin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblFin.Name = "lblFin";
        lblFin.Tag = "texte";
        lblFin.TabIndex = 11;
        //
        // dtpFin
        //
        dtpFin.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        dtpFin.Format = DateTimePickerFormat.Time;
        dtpFin.Location = new Point(272, 298);
        dtpFin.ShowUpDown = true;
        dtpFin.Size = new Size(224, 26);
        dtpFin.Name = "dtpFin";
        dtpFin.Tag = "input";
        dtpFin.TabIndex = 12;
        //
        // lblSalle
        //
        lblSalle.AutoSize = false;
        lblSalle.Location = new Point(24, 346);
        lblSalle.Size = new Size(472, 20);
        lblSalle.Text = "Salle *";
        lblSalle.ForeColor = Color.FromArgb(27, 20, 22);
        lblSalle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblSalle.Name = "lblSalle";
        lblSalle.Tag = "texte";
        lblSalle.TabIndex = 13;
        //
        // cboSalle
        //
        cboSalle.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSalle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboSalle.Location = new Point(24, 368);
        cboSalle.Size = new Size(472, 28);
        cboSalle.Name = "cboSalle";
        cboSalle.Tag = "input";
        cboSalle.TabIndex = 14;
        //
        // lblErreur
        //
        lblErreur.AutoSize = false;
        lblErreur.Location = new Point(24, 408);
        lblErreur.Size = new Size(472, 44);
        lblErreur.Text = "";
        lblErreur.ForeColor = Color.FromArgb(179, 38, 30);
        lblErreur.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblErreur.Name = "lblErreur";
        lblErreur.TabIndex = 15;
        //
        // btnEnregistrer
        //
        btnEnregistrer.BackColor = Color.FromArgb(155, 27, 48);
        btnEnregistrer.ForeColor = Color.FromArgb(255, 255, 255);
        btnEnregistrer.Location = new Point(24, 460);
        btnEnregistrer.Size = new Size(224, 42);
        btnEnregistrer.Text = "Enregistrer";
        btnEnregistrer.UseVisualStyleBackColor = false;
        btnEnregistrer.Name = "btnEnregistrer";
        btnEnregistrer.TabIndex = 16;
        //
        // btnAnnuler
        //
        btnAnnuler.BackColor = Color.FromArgb(239, 232, 234);
        btnAnnuler.ForeColor = Color.FromArgb(27, 20, 22);
        btnAnnuler.Location = new Point(272, 460);
        btnAnnuler.Size = new Size(224, 42);
        btnAnnuler.Text = "Annuler";
        btnAnnuler.UseVisualStyleBackColor = false;
        btnAnnuler.Name = "btnAnnuler";
        btnAnnuler.Tag = "secondaire";
        btnAnnuler.TabIndex = 17;
        //
        // FrmSeanceDetail
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(255, 255, 255);
        ClientSize = new Size(520, 526);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Planifier une séance";
        Tag = "carte";
        Name = "FrmSeanceDetail";
        Controls.Add(lblTitreFiche);
        Controls.Add(lblClasse);
        Controls.Add(cboClasse);
        Controls.Add(lblCours);
        Controls.Add(cboCours);
        Controls.Add(lblDate);
        Controls.Add(dtpDate);
        Controls.Add(lblType);
        Controls.Add(cboType);
        Controls.Add(lblDebut);
        Controls.Add(dtpDebut);
        Controls.Add(lblFin);
        Controls.Add(dtpFin);
        Controls.Add(lblSalle);
        Controls.Add(cboSalle);
        Controls.Add(lblErreur);
        Controls.Add(btnEnregistrer);
        Controls.Add(btnAnnuler);
        cboClasse.SelectedIndexChanged += cboClasse_SelectedIndexChanged;
        btnEnregistrer.Click += btnEnregistrer_Click;
        btnAnnuler.Click += btnAnnuler_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitreFiche;
    private Label lblClasse;
    private ComboBox cboClasse;
    private Label lblCours;
    private ComboBox cboCours;
    private Label lblDate;
    private DateTimePicker dtpDate;
    private Label lblType;
    private ComboBox cboType;
    private Label lblDebut;
    private DateTimePicker dtpDebut;
    private Label lblFin;
    private DateTimePicker dtpFin;
    private Label lblSalle;
    private ComboBox cboSalle;
    private Label lblErreur;
    private BoutonArrondi btnEnregistrer;
    private BoutonArrondi btnAnnuler;
}
