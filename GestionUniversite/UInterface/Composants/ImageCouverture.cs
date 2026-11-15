using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace GestionUniversite.UInterface.Composants;

// Panneau avec une image « cover » (recadrée) et un voile bordeaux dégradé pour le texte
public class ImageCouverture : Panel
{
    private Image _image;
    private int _rayon = 20;

    public ImageCouverture()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    [DefaultValue(null)]
    public Image Image
    {
        get => _image;
        set { _image = value; Invalidate(); }
    }

    [DefaultValue(20)]
    public int Rayon
    {
        get => _rayon;
        set { _rayon = value; Arrondir(); Invalidate(); }
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

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        var g = e.Graphics;
        var voile = Color.FromArgb(155, 27, 48);
        g.Clear(voile);
        if (Width < 2 || Height < 2) return;
        if (_image != null)
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            float s = Math.Max((float)Width / _image.Width, (float)Height / _image.Height);
            float w = _image.Width * s, h = _image.Height * s;
            g.DrawImage(_image, (Width - w) / 2f, (Height - h) / 2f, w, h);
        }
        using var pinceau = new LinearGradientBrush(new Rectangle(0, 0, Width, Height),
            Color.FromArgb(240, 94, 15, 30), Color.FromArgb(30, 155, 27, 48), LinearGradientMode.Horizontal);
        g.FillRectangle(pinceau, 0, 0, Width, Height);
    }
}
