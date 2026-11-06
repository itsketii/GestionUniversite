using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblTitre = new Label();
        lblSousTitre = new Label();
        pnlBanniere = new PanelArrondi();
        pictureBox1 = new PictureBox();
        lblBonjour = new Label();
        lblAccroche = new Label();
        btnNouvelleInscription = new BoutonArrondi();
        picBanniere = new PictureBox();
        pnlKpi1 = new PanelArrondi();
        lblKpi1Valeur = new Label();
        lblKpi1Titre = new Label();
        pnlKpi2 = new PanelArrondi();
        lblKpi2Valeur = new Label();
        lblKpi2Titre = new Label();
        pnlKpi3 = new PanelArrondi();
        lblKpi3Valeur = new Label();
        lblKpi3Titre = new Label();
        pnlKpi4 = new PanelArrondi();
        lblKpi4Valeur = new Label();
        lblKpi4Titre = new Label();
        pnlSeances = new PanelArrondi();
        lblSeancesTitre = new Label();
        dgvSeances = new GrilleModerne();
        pnlEffectifs = new PanelArrondi();
        lblEffectifsTitre = new Label();
        dgvEffectifs = new GrilleModerne();
        pnlBanniere.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picBanniere).BeginInit();
        pnlKpi1.SuspendLayout();
        pnlKpi2.SuspendLayout();
        pnlKpi3.SuspendLayout();
        pnlKpi4.SuspendLayout();
        pnlSeances.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvSeances).BeginInit();
        pnlEffectifs.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEffectifs).BeginInit();
        SuspendLayout();
        // 
        // lblTitre
        // 
        lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblTitre.Location = new Point(46, 43);
        lblTitre.Margin = new Padding(4, 0, 4, 0);
        lblTitre.Name = "lblTitre";
        lblTitre.Size = new Size(714, 67);
        lblTitre.TabIndex = 0;
        lblTitre.Text = "Tableau de bord";
        // 
        // lblSousTitre
        // 
        lblSousTitre.Font = new Font("Segoe UI", 10F);
        lblSousTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblSousTitre.Location = new Point(49, 110);
        lblSousTitre.Margin = new Padding(4, 0, 4, 0);
        lblSousTitre.Name = "lblSousTitre";
        lblSousTitre.Size = new Size(714, 40);
        lblSousTitre.TabIndex = 1;
        lblSousTitre.Text = "Année académique en cours";
        // 
        // pnlBanniere
        // 
        pnlBanniere.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlBanniere.BackColor = Color.FromArgb(155, 27, 48);
        pnlBanniere.Controls.Add(pictureBox1);
        pnlBanniere.Controls.Add(lblBonjour);
        pnlBanniere.Controls.Add(lblAccroche);
        pnlBanniere.Controls.Add(btnNouvelleInscription);
        pnlBanniere.Controls.Add(picBanniere);
        pnlBanniere.Location = new Point(46, 173);
        pnlBanniere.Margin = new Padding(4, 5, 4, 5);
        pnlBanniere.Name = "pnlBanniere";
        pnlBanniere.Rayon = 20;
        pnlBanniere.Size = new Size(1394, 250);
        pnlBanniere.TabIndex = 2;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.IIT_Paysage;
        pictureBox1.Location = new Point(943, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(684, 250);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // lblBonjour
        // 
        lblBonjour.Font = new Font("Segoe UI", 10.5F);
        lblBonjour.ForeColor = Color.FromArgb(255, 255, 255);
        lblBonjour.Location = new Point(40, 37);
        lblBonjour.Margin = new Padding(4, 0, 4, 0);
        lblBonjour.Name = "lblBonjour";
        lblBonjour.Size = new Size(743, 40);
        lblBonjour.TabIndex = 3;
        lblBonjour.Text = "Bonjour,";
        // 
        // lblAccroche
        // 
        lblAccroche.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblAccroche.ForeColor = Color.FromArgb(255, 255, 255);
        lblAccroche.Location = new Point(40, 77);
        lblAccroche.Margin = new Padding(4, 0, 4, 0);
        lblAccroche.Name = "lblAccroche";
        lblAccroche.Size = new Size(854, 93);
        lblAccroche.TabIndex = 4;
        lblAccroche.Text = "Inscriptions, séances et absences en un seul espace.";
        // 
        // btnNouvelleInscription
        // 
        btnNouvelleInscription.BackColor = Color.FromArgb(255, 255, 255);
        btnNouvelleInscription.FlatStyle = FlatStyle.Flat;
        btnNouvelleInscription.Font = new Font("Segoe UI Semibold", 10F);
        btnNouvelleInscription.ForeColor = Color.FromArgb(122, 20, 38);
        btnNouvelleInscription.Location = new Point(40, 177);
        btnNouvelleInscription.Margin = new Padding(4, 5, 4, 5);
        btnNouvelleInscription.Name = "btnNouvelleInscription";
        btnNouvelleInscription.Size = new Size(286, 60);
        btnNouvelleInscription.TabIndex = 5;
        btnNouvelleInscription.Text = "Nouvelle inscription";
        btnNouvelleInscription.UseVisualStyleBackColor = false;
        // 
        // picBanniere
        // 
        picBanniere.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        picBanniere.BackColor = Color.FromArgb(122, 20, 38);
        picBanniere.Location = new Point(943, 0);
        picBanniere.Margin = new Padding(4, 5, 4, 5);
        picBanniere.Name = "picBanniere";
        picBanniere.Size = new Size(451, 250);
        picBanniere.SizeMode = PictureBoxSizeMode.Zoom;
        picBanniere.TabIndex = 6;
        picBanniere.TabStop = false;
        // 
        // pnlKpi1
        // 
        pnlKpi1.BackColor = Color.FromArgb(255, 255, 255);
        pnlKpi1.Controls.Add(lblKpi1Valeur);
        pnlKpi1.Controls.Add(lblKpi1Titre);
        pnlKpi1.Location = new Point(46, 463);
        pnlKpi1.Margin = new Padding(4, 5, 4, 5);
        pnlKpi1.Name = "pnlKpi1";
        pnlKpi1.Size = new Size(331, 153);
        pnlKpi1.TabIndex = 8;
        // 
        // lblKpi1Valeur
        // 
        lblKpi1Valeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblKpi1Valeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblKpi1Valeur.Location = new Point(29, 20);
        lblKpi1Valeur.Margin = new Padding(4, 0, 4, 0);
        lblKpi1Valeur.Name = "lblKpi1Valeur";
        lblKpi1Valeur.Size = new Size(271, 70);
        lblKpi1Valeur.TabIndex = 9;
        lblKpi1Valeur.Text = "0";
        // 
        // lblKpi1Titre
        // 
        lblKpi1Titre.Font = new Font("Segoe UI", 9.5F);
        lblKpi1Titre.ForeColor = Color.FromArgb(107, 96, 99);
        lblKpi1Titre.Location = new Point(29, 97);
        lblKpi1Titre.Margin = new Padding(4, 0, 4, 0);
        lblKpi1Titre.Name = "lblKpi1Titre";
        lblKpi1Titre.Size = new Size(286, 37);
        lblKpi1Titre.TabIndex = 10;
        lblKpi1Titre.Text = "Étudiants inscrits";
        // 
        // pnlKpi2
        // 
        pnlKpi2.BackColor = Color.FromArgb(255, 255, 255);
        pnlKpi2.Controls.Add(lblKpi2Valeur);
        pnlKpi2.Controls.Add(lblKpi2Titre);
        pnlKpi2.Location = new Point(400, 463);
        pnlKpi2.Margin = new Padding(4, 5, 4, 5);
        pnlKpi2.Name = "pnlKpi2";
        pnlKpi2.Size = new Size(331, 153);
        pnlKpi2.TabIndex = 11;
        // 
        // lblKpi2Valeur
        // 
        lblKpi2Valeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblKpi2Valeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblKpi2Valeur.Location = new Point(29, 20);
        lblKpi2Valeur.Margin = new Padding(4, 0, 4, 0);
        lblKpi2Valeur.Name = "lblKpi2Valeur";
        lblKpi2Valeur.Size = new Size(271, 70);
        lblKpi2Valeur.TabIndex = 12;
        lblKpi2Valeur.Text = "0";
        // 
        // lblKpi2Titre
        // 
        lblKpi2Titre.Font = new Font("Segoe UI", 9.5F);
        lblKpi2Titre.ForeColor = Color.FromArgb(107, 96, 99);
        lblKpi2Titre.Location = new Point(29, 97);
        lblKpi2Titre.Margin = new Padding(4, 0, 4, 0);
        lblKpi2Titre.Name = "lblKpi2Titre";
        lblKpi2Titre.Size = new Size(286, 37);
        lblKpi2Titre.TabIndex = 13;
        lblKpi2Titre.Text = "Classes ouvertes";
        // 
        // pnlKpi3
        // 
        pnlKpi3.BackColor = Color.FromArgb(255, 255, 255);
        pnlKpi3.Controls.Add(lblKpi3Valeur);
        pnlKpi3.Controls.Add(lblKpi3Titre);
        pnlKpi3.Location = new Point(754, 463);
        pnlKpi3.Margin = new Padding(4, 5, 4, 5);
        pnlKpi3.Name = "pnlKpi3";
        pnlKpi3.Size = new Size(331, 153);
        pnlKpi3.TabIndex = 14;
        // 
        // lblKpi3Valeur
        // 
        lblKpi3Valeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblKpi3Valeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblKpi3Valeur.Location = new Point(29, 20);
        lblKpi3Valeur.Margin = new Padding(4, 0, 4, 0);
        lblKpi3Valeur.Name = "lblKpi3Valeur";
        lblKpi3Valeur.Size = new Size(271, 70);
        lblKpi3Valeur.TabIndex = 15;
        lblKpi3Valeur.Text = "0";
        // 
        // lblKpi3Titre
        // 
        lblKpi3Titre.Font = new Font("Segoe UI", 9.5F);
        lblKpi3Titre.ForeColor = Color.FromArgb(107, 96, 99);
        lblKpi3Titre.Location = new Point(29, 97);
        lblKpi3Titre.Margin = new Padding(4, 0, 4, 0);
        lblKpi3Titre.Name = "lblKpi3Titre";
        lblKpi3Titre.Size = new Size(286, 37);
        lblKpi3Titre.TabIndex = 16;
        lblKpi3Titre.Text = "Séances (7 prochains jours)";
        // 
        // pnlKpi4
        // 
        pnlKpi4.BackColor = Color.FromArgb(255, 255, 255);
        pnlKpi4.Controls.Add(lblKpi4Valeur);
        pnlKpi4.Controls.Add(lblKpi4Titre);
        pnlKpi4.Location = new Point(1109, 463);
        pnlKpi4.Margin = new Padding(4, 5, 4, 5);
        pnlKpi4.Name = "pnlKpi4";
        pnlKpi4.Size = new Size(331, 153);
        pnlKpi4.TabIndex = 17;
        // 
        // lblKpi4Valeur
        // 
        lblKpi4Valeur.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblKpi4Valeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblKpi4Valeur.Location = new Point(29, 20);
        lblKpi4Valeur.Margin = new Padding(4, 0, 4, 0);
        lblKpi4Valeur.Name = "lblKpi4Valeur";
        lblKpi4Valeur.Size = new Size(271, 70);
        lblKpi4Valeur.TabIndex = 18;
        lblKpi4Valeur.Text = "0";
        // 
        // lblKpi4Titre
        // 
        lblKpi4Titre.Font = new Font("Segoe UI", 9.5F);
        lblKpi4Titre.ForeColor = Color.FromArgb(107, 96, 99);
        lblKpi4Titre.Location = new Point(29, 97);
        lblKpi4Titre.Margin = new Padding(4, 0, 4, 0);
        lblKpi4Titre.Name = "lblKpi4Titre";
        lblKpi4Titre.Size = new Size(286, 37);
        lblKpi4Titre.TabIndex = 19;
        lblKpi4Titre.Text = "Absences non justifiées";
        // 
        // pnlSeances
        // 
        pnlSeances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pnlSeances.BackColor = Color.FromArgb(255, 255, 255);
        pnlSeances.Controls.Add(lblSeancesTitre);
        pnlSeances.Controls.Add(dgvSeances);
        pnlSeances.Location = new Point(46, 657);
        pnlSeances.Margin = new Padding(4, 5, 4, 5);
        pnlSeances.Name = "pnlSeances";
        pnlSeances.Size = new Size(857, 567);
        pnlSeances.TabIndex = 20;
        // 
        // lblSeancesTitre
        // 
        lblSeancesTitre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        lblSeancesTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblSeancesTitre.Location = new Point(29, 27);
        lblSeancesTitre.Margin = new Padding(4, 0, 4, 0);
        lblSeancesTitre.Name = "lblSeancesTitre";
        lblSeancesTitre.Size = new Size(429, 43);
        lblSeancesTitre.TabIndex = 21;
        lblSeancesTitre.Text = "Prochaines séances";
        // 
        // dgvSeances
        // 
        dgvSeances.AllowUserToAddRows = false;
        dgvSeances.AllowUserToDeleteRows = false;
        dgvSeances.AllowUserToResizeRows = false;
        dgvSeances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvSeances.BackgroundColor = Color.White;
        dgvSeances.BorderStyle = BorderStyle.None;
        dgvSeances.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvSeances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 247, 247);
        dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 96, 99);
        dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(250, 247, 247);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 96, 99);
        dgvSeances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvSeances.ColumnHeadersHeight = 44;
        dgvSeances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(27, 20, 22);
        dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 227, 231);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(27, 20, 22);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvSeances.DefaultCellStyle = dataGridViewCellStyle2;
        dgvSeances.EnableHeadersVisualStyles = false;
        dgvSeances.GridColor = Color.FromArgb(239, 232, 234);
        dgvSeances.Location = new Point(17, 87);
        dgvSeances.Margin = new Padding(4, 5, 4, 5);
        dgvSeances.MultiSelect = false;
        dgvSeances.Name = "dgvSeances";
        dgvSeances.ReadOnly = true;
        dgvSeances.RowHeadersVisible = false;
        dgvSeances.RowHeadersWidth = 62;
        dgvSeances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSeances.Size = new Size(823, 460);
        dgvSeances.TabIndex = 22;
        // 
        // pnlEffectifs
        // 
        pnlEffectifs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        pnlEffectifs.BackColor = Color.FromArgb(255, 255, 255);
        pnlEffectifs.Controls.Add(lblEffectifsTitre);
        pnlEffectifs.Controls.Add(dgvEffectifs);
        pnlEffectifs.Location = new Point(926, 657);
        pnlEffectifs.Margin = new Padding(4, 5, 4, 5);
        pnlEffectifs.Name = "pnlEffectifs";
        pnlEffectifs.Size = new Size(514, 567);
        pnlEffectifs.TabIndex = 23;
        // 
        // lblEffectifsTitre
        // 
        lblEffectifsTitre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        lblEffectifsTitre.ForeColor = Color.FromArgb(27, 20, 22);
        lblEffectifsTitre.Location = new Point(29, 27);
        lblEffectifsTitre.Margin = new Padding(4, 0, 4, 0);
        lblEffectifsTitre.Name = "lblEffectifsTitre";
        lblEffectifsTitre.Size = new Size(429, 43);
        lblEffectifsTitre.TabIndex = 24;
        lblEffectifsTitre.Text = "Effectif par classe";
        // 
        // dgvEffectifs
        // 
        dgvEffectifs.AllowUserToAddRows = false;
        dgvEffectifs.AllowUserToDeleteRows = false;
        dgvEffectifs.AllowUserToResizeRows = false;
        dgvEffectifs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEffectifs.BackgroundColor = Color.White;
        dgvEffectifs.BorderStyle = BorderStyle.None;
        dgvEffectifs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvEffectifs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 247, 247);
        dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(107, 96, 99);
        dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(250, 247, 247);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(107, 96, 99);
        dgvEffectifs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvEffectifs.ColumnHeadersHeight = 44;
        dgvEffectifs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(27, 20, 22);
        dataGridViewCellStyle4.Padding = new Padding(8, 0, 0, 0);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(246, 227, 231);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(27, 20, 22);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        dgvEffectifs.DefaultCellStyle = dataGridViewCellStyle4;
        dgvEffectifs.EnableHeadersVisualStyles = false;
        dgvEffectifs.GridColor = Color.FromArgb(239, 232, 234);
        dgvEffectifs.Location = new Point(17, 87);
        dgvEffectifs.Margin = new Padding(4, 5, 4, 5);
        dgvEffectifs.MultiSelect = false;
        dgvEffectifs.Name = "dgvEffectifs";
        dgvEffectifs.ReadOnly = true;
        dgvEffectifs.RowHeadersVisible = false;
        dgvEffectifs.RowHeadersWidth = 62;
        dgvEffectifs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEffectifs.Size = new Size(480, 460);
        dgvEffectifs.TabIndex = 25;
        // 
        // UcDashboard
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Controls.Add(lblTitre);
        Controls.Add(lblSousTitre);
        Controls.Add(pnlBanniere);
        Controls.Add(pnlKpi1);
        Controls.Add(pnlKpi2);
        Controls.Add(pnlKpi3);
        Controls.Add(pnlKpi4);
        Controls.Add(pnlSeances);
        Controls.Add(pnlEffectifs);
        Margin = new Padding(4, 5, 4, 5);
        Name = "UcDashboard";
        Size = new Size(1486, 1267);
        Load += UcDashboard_Load;
        pnlBanniere.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)picBanniere).EndInit();
        pnlKpi1.ResumeLayout(false);
        pnlKpi2.ResumeLayout(false);
        pnlKpi3.ResumeLayout(false);
        pnlKpi4.ResumeLayout(false);
        pnlSeances.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvSeances).EndInit();
        pnlEffectifs.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEffectifs).EndInit();
        ResumeLayout(false);
    }

    private Label lblTitre;
    private Label lblSousTitre;
    private PanelArrondi pnlBanniere;
    private Label lblBonjour;
    private Label lblAccroche;
    private BoutonArrondi btnNouvelleInscription;
    private PictureBox picBanniere;
    private PanelArrondi pnlKpi1;
    private Label lblKpi1Valeur;
    private Label lblKpi1Titre;
    private PanelArrondi pnlKpi2;
    private Label lblKpi2Valeur;
    private Label lblKpi2Titre;
    private PanelArrondi pnlKpi3;
    private Label lblKpi3Valeur;
    private Label lblKpi3Titre;
    private PanelArrondi pnlKpi4;
    private Label lblKpi4Valeur;
    private Label lblKpi4Titre;
    private PanelArrondi pnlSeances;
    private Label lblSeancesTitre;
    private GrilleModerne dgvSeances;
    private PanelArrondi pnlEffectifs;
    private Label lblEffectifsTitre;
    private GrilleModerne dgvEffectifs;
    private DataGridViewTextBoxColumn colJour;
    private DataGridViewTextBoxColumn colHeure;
    private DataGridViewTextBoxColumn colMatiere;
    private DataGridViewTextBoxColumn colClasse;
    private DataGridViewTextBoxColumn colSalle;
    private DataGridViewTextBoxColumn colType;
    private DataGridViewTextBoxColumn colClasseNom;
    private DataGridViewTextBoxColumn colEffectif;
    private PictureBox pictureBox1;
}
