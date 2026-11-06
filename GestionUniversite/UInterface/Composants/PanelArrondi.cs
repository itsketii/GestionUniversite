using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace GestionUniversite.UInterface.Composants;

// Panneau aux coins arrondis (cartes, bannières)
public class PanelArrondi : Panel
{
    private int _rayon = 16;

    [DefaultValue(16)]
    public int Rayon
    {
        get => _rayon;
        set { _rayon = value; Arrondir(); }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Arrondir();
    }

    private void Arrondir()
    {
        if (Width <= 0 || Height <= 0) return;
        int d = Math.Max(1, Math.Min(_rayon * 2, Math.Min(Width, Height)));
        using var path = new GraphicsPath();
        path.AddArc(0, 0, d, d, 180, 90);
        path.AddArc(Width - d, 0, d, d, 270, 90);
        path.AddArc(Width - d, Height - d, d, d, 0, 90);
        path.AddArc(0, Height - d, d, d, 90, 90);
        path.CloseFigure();
        Region = new Region(path);
    }
}
