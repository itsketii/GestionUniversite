using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class CarteKpi
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlCarte = new PanelArrondi();
        pnlPastille = new PanelArrondi();
        icone = new FontAwesome.Sharp.IconPictureBox();
        lblValeur = new Label();
        lblTitre = new Label();
        pnlCarte.SuspendLayout();
        pnlPastille.SuspendLayout();
        SuspendLayout();
        //
        // pnlCarte
        //
        pnlCarte.BackColor = Color.FromArgb(255, 255, 255);
        pnlCarte.Rayon = 16;
        pnlCarte.Dock = DockStyle.Fill;
        pnlCarte.Tag = "carte";
        pnlCarte.Name = "pnlCarte";
        pnlCarte.TabIndex = 0;
        pnlCarte.Controls.Add(pnlPastille);
        pnlCarte.Controls.Add(lblValeur);
        pnlCarte.Controls.Add(lblTitre);
        //
        // pnlPastille
        //
        pnlPastille.BackColor = Color.FromArgb(246, 227, 231);
        pnlPastille.Rayon = 20;
        pnlPastille.Location = new Point(14, 14);
        pnlPastille.Size = new Size(40, 40);
        pnlPastille.AfficherBordure = false;
        pnlPastille.Name = "pnlPastille";
        pnlPastille.TabIndex = 1;
        pnlPastille.Controls.Add(icone);
        //
        // icone
        //
        icone.BackColor = Color.Transparent;
        icone.ForeColor = Color.FromArgb(155, 27, 48);
        icone.IconChar = (FontAwesome.Sharp.IconChar)0xf19d;
        icone.IconColor = Color.FromArgb(155, 27, 48);
        icone.IconSize = 22;
        icone.Location = new Point(9, 9);
        icone.Size = new Size(22, 22);
        icone.TabStop = false;
        icone.Name = "icone";
        icone.TabIndex = 2;
        //
        // lblValeur
        //
        lblValeur.AutoSize = false;
        lblValeur.Dock = DockStyle.Fill;
        lblValeur.Text = "0";
        lblValeur.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
        lblValeur.ForeColor = Color.FromArgb(27, 20, 22);
        lblValeur.Tag = "texte";
        lblValeur.TextAlign = ContentAlignment.MiddleLeft;
        lblValeur.Padding = new Padding(66, 0, 4, 0);
        lblValeur.Name = "lblValeur";
        lblValeur.TabIndex = 3;
        //
        // lblTitre
        //
        lblTitre.AutoSize = false;
        lblTitre.Dock = DockStyle.Bottom;
        lblTitre.Text = "Titre";
        lblTitre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblTitre.ForeColor = Color.FromArgb(107, 96, 99);
        lblTitre.Tag = "discret";
        lblTitre.TextAlign = ContentAlignment.TopLeft;
        lblTitre.Padding = new Padding(16, 0, 4, 0);
        lblTitre.Size = new Size(100, 34);
        lblTitre.Name = "lblTitre";
        lblTitre.TabIndex = 4;
        //
        // CarteKpi
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Size = new Size(200, 100);
        Name = "CarteKpi";
        Controls.Add(pnlCarte);
        pnlCarte.ResumeLayout(false);
        pnlPastille.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private PanelArrondi pnlCarte;
    private PanelArrondi pnlPastille;
    private FontAwesome.Sharp.IconPictureBox icone;
    private Label lblValeur;
    private Label lblTitre;
}
