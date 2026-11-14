using FontAwesome.Sharp;
using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

// Palette de l'application (couleurs de l'école) en mode clair ou sombre
public static class Theme
{
    public static bool Sombre { get; private set; }

    private static Color C(string hex) => ColorTranslator.FromHtml(hex);

    public static Color Primaire => C("#9B1B30");
    public static Color PrimaireFonce => C("#5E0F1E");
    public static Color PrimaireClair => Sombre ? C("#4A1A24") : C("#F6E3E7");
    public static Color RougeLogo => C("#E92127");
    public static Color MenuFond => Sombre ? C("#0E0B0C") : C("#1B1416");
    public static Color MenuSurvol => C("#2E2427");
    public static Color MenuTexte => C("#D6CCCF");
    public static Color Fond => Sombre ? C("#141113") : C("#F6F3F2");
    public static Color Carte => Sombre ? C("#1F1A1C") : Color.White;
    public static Color Champ => Sombre ? C("#2A2325") : Color.White;
    public static Color Texte => Sombre ? C("#F3EDEE") : C("#1B1416");
    public static Color TexteDiscret => Sombre ? C("#A89DA1") : C("#6B6063");
    public static Color Bordure => Sombre ? C("#352D30") : C("#EFE8EA");
    public static Color EnteteGrille => Sombre ? C("#262022") : C("#FAF7F7");
    public static Color Secondaire => Sombre ? C("#352D30") : C("#EFE8EA");

    public static Color[] Palette => Sombre
        ? new[] { C("#D4344A"), C("#F26B74"), C("#E8A3AA"), C("#9B1B30"), C("#A89DA1"), C("#6B6063") }
        : new[] { C("#9B1B30"), C("#E92127"), C("#D98A93"), C("#5E0F1E"), C("#8A7F83"), C("#C9BEC1") };

    public static void Charger() => Sombre = Parametres.Mode == "sombre";

    public static void Definir(bool sombre)
    {
        Sombre = sombre;
        Parametres.Mode = sombre ? "sombre" : "clair";
        Parametres.Enregistrer();
    }

    public static void Basculer() => Definir(!Sombre);

    // Applique les couleurs selon le rôle indiqué dans la propriété Tag de chaque contrôle
    public static void Appliquer(Control c)
    {
        switch (c.Tag as string)
        {
            case "fond": c.BackColor = Fond; break;
            case "carte": c.BackColor = Carte; break;
            case "texte": c.ForeColor = Texte; break;
            case "discret": c.ForeColor = TexteDiscret; break;
            case "input": c.BackColor = Champ; c.ForeColor = Texte; break;
            case "menu": c.BackColor = MenuFond; break;
            case "bordure": c.BackColor = Bordure; break;
            case "pastille": c.BackColor = PrimaireClair; break;
            case "accent": c.ForeColor = Sombre ? C("#E8A3AA") : C("#7A1426"); break;
            case "secondaire": c.BackColor = Secondaire; c.ForeColor = Texte; break;
            case "icone":
                c.BackColor = Carte;
                c.ForeColor = Texte;
                if (c is IconButton bouton) bouton.IconColor = Texte;
                break;
        }
        if (c is IThemable themable) themable.AppliquerTheme();
        foreach (Control enfant in c.Controls) Appliquer(enfant);
        c.Invalidate();
    }

    // Image d'un contrôle toujours en mode clair (pour l'impression)
    public static Bitmap Capturer(Control c)
    {
        bool avant = Sombre;
        Sombre = false;
        Appliquer(c);
        c.Refresh();
        var image = new Bitmap(c.Width, c.Height);
        c.DrawToBitmap(image, new Rectangle(Point.Empty, c.Size));
        Sombre = avant;
        Appliquer(c);
        return image;
    }
}
