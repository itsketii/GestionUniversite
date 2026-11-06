namespace GestionUniversite.UInterface;

public partial class UcEnConstruction : UserControl
{
    public UcEnConstruction()
    {
        InitializeComponent();
    }

    public UcEnConstruction(string titre) : this()
    {
        lblMessage.Text = titre + " : écran en construction";
    }
}
