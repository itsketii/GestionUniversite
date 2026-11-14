using System.Drawing.Drawing2D;

namespace GestionUniversite.UInterface.Composants;

public static class Dessin
{
    public static GraphicsPath RectArrondi(RectangleF r, float rayon)
    {
        float d = Math.Max(1f, Math.Min(rayon * 2f, Math.Min(r.Width, r.Height)));
        var p = new GraphicsPath();
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }

    public static Color Melanger(Color a, Color b, float t) => Color.FromArgb(
        (int)(a.R + (b.R - a.R) * t),
        (int)(a.G + (b.G - a.G) * t),
        (int)(a.B + (b.B - a.B) * t));

    public static StringFormat Format(StringAlignment h, StringAlignment v) => new StringFormat
    {
        Alignment = h,
        LineAlignment = v,
        Trimming = StringTrimming.EllipsisCharacter,
        FormatFlags = StringFormatFlags.NoWrap
    };
}
