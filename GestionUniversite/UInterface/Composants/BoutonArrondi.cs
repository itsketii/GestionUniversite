using System.ComponentModel;

namespace GestionUniversite.UInterface.Composants;

// Bouton plat aux coins arrondis, aux couleurs de l'école
public class BoutonArrondi : Button
{
    private int _rayon = 10;

    public BoutonArrondi()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Cursor = Cursors.Hand;
        BackColor = Color.FromArgb(155, 27, 48);
        ForeColor = Color.White;
        Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
    }

    [DefaultValue(10)]
    public int Rayon
    {
        get => _rayon;
        set { _rayon = value; Arrondir(); }
    }

    protected override void OnBackColorChanged(EventArgs e)
    {
        base.OnBackColorChanged(e);
        FlatAppearance.MouseOverBackColor = ControlPaint.Light(BackColor, 0.12f);
        FlatAppearance.MouseDownBackColor = ControlPaint.Dark(BackColor, 0.05f);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Arrondir();
    }

    private void Arrondir()
    {
        if (Width <= 0 || Height <= 0) return;
        using var path = Dessin.RectArrondi(new RectangleF(0, 0, Width, Height), _rayon);
        Region = new Region(path);
    }
}
