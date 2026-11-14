using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace GestionUniversite.UInterface.Composants;

// Panneau aux coins arrondis (cartes, bannières)
public class PanelArrondi : Panel, IThemable
{
    private int _rayon = 16;
    private bool _bordure = true;

    public PanelArrondi()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    [DefaultValue(16)]
    public int Rayon
    {
        get => _rayon;
        set { _rayon = value; Arrondir(); Invalidate(); }
    }

    [DefaultValue(true)]
    public bool AfficherBordure
    {
        get => _bordure;
        set { _bordure = value; Invalidate(); }
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

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (!_bordure || Width < 4 || Height < 4) return;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = Dessin.RectArrondi(new RectangleF(0.5f, 0.5f, Width - 2, Height - 2), _rayon);
        using var pen = new Pen(Theme.Bordure, 1f);
        e.Graphics.DrawPath(pen, path);
    }

    public void AppliquerTheme() => Invalidate();
}
