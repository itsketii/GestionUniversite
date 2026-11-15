namespace GestionUniversite.UInterface.Composants;

// DataGridView au style moderne : les colonnes se définissent dans le designer
public class GrilleModerne : DataGridView, IThemable
{
    private static readonly Font PoliceEntete = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
    private static readonly Font PoliceCellule = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);

    private bool _echelle;

    public GrilleModerne()
    {
        DoubleBuffered = true;
        BorderStyle = BorderStyle.None;
        CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        RowHeadersVisible = false;
        AllowUserToAddRows = false;
        AllowUserToDeleteRows = false;
        AllowUserToResizeRows = false;
        ReadOnly = true;
        MultiSelect = false;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        EnableHeadersVisualStyles = false;
        ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        ColumnHeadersHeight = 46;
        RowTemplate.Height = 44;
        AppliquerTheme();
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        if (_echelle || Outils.EstDesigner) return;
        _echelle = true;
        float f = DeviceDpi / 96f;
        if (f <= 1.01f) return;
        ColumnHeadersHeight = (int)(ColumnHeadersHeight * f);
        RowTemplate.Height = (int)(RowTemplate.Height * f);
        foreach (DataGridViewColumn c in Columns)
            if (c.AutoSizeMode == DataGridViewAutoSizeColumnMode.None) c.Width = (int)(c.Width * f);
    }

    public void AppliquerTheme()
    {
        BackgroundColor = Theme.Carte;
        GridColor = Theme.Bordure;
        ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Theme.EnteteGrille,
            ForeColor = Theme.TexteDiscret,
            SelectionBackColor = Theme.EnteteGrille,
            SelectionForeColor = Theme.TexteDiscret,
            Font = PoliceEntete,
            Padding = new Padding(10, 0, 0, 0)
        };
        DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Theme.Carte,
            ForeColor = Theme.Texte,
            SelectionBackColor = Theme.PrimaireClair,
            SelectionForeColor = Theme.Texte,
            Font = PoliceCellule,
            Padding = new Padding(10, 0, 0, 0)
        };
        Invalidate();
    }
}
