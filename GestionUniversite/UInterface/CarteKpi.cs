using System.ComponentModel;
using FontAwesome.Sharp;
using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

// Carte de chiffre clé : pastille d'icône, valeur et titre
public partial class CarteKpi : UserControl, IThemable
{
    private Color _teinte = Color.FromArgb(155, 27, 48);

    public CarteKpi()
    {
        InitializeComponent();
        AppliquerTheme();
    }

    [DefaultValue("0")]
    public string Valeur
    {
        get => lblValeur.Text;
        set => lblValeur.Text = value;
    }

    [DefaultValue("Titre")]
    public string Titre
    {
        get => lblTitre.Text;
        set => lblTitre.Text = value;
    }

    [DefaultValue(0xf19d)]
    public int Icone
    {
        get => (int)icone.IconChar;
        set => icone.IconChar = (IconChar)value;
    }

    public Color Teinte
    {
        get => _teinte;
        set { _teinte = value; AppliquerTheme(); }
    }

    private bool ShouldSerializeTeinte() => _teinte != Color.FromArgb(155, 27, 48);
    private void ResetTeinte() => Teinte = Color.FromArgb(155, 27, 48);

    public void AppliquerTheme()
    {
        pnlPastille.BackColor = Dessin.Melanger(_teinte, Theme.Carte, Theme.Sombre ? 0.72f : 0.85f);
        icone.IconColor = Theme.Sombre ? Dessin.Melanger(_teinte, Color.White, 0.35f) : _teinte;
    }
}
