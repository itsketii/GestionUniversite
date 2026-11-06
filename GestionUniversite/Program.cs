namespace GestionUniversite;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using (var login = new UInterface.FrmLogin())
        {
            if (login.ShowDialog() != DialogResult.OK) return;
        }

        Application.Run(new UInterface.FrmMain());
    }
}
