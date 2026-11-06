namespace GestionUniversite.UInterface.Composants;

// DataGridView au style moderne : les colonnes se définissent dans le designer
public class GrilleModerne : DataGridView
{
    public GrilleModerne()
    {
        DoubleBuffered = true;
        BackgroundColor = Color.White;
        BorderStyle = BorderStyle.None;
        CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        GridColor = Theme.Bordure;
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
        ColumnHeadersHeight = 44;
        RowTemplate.Height = 42;

        var entete = Color.FromArgb(250, 247, 247);
        ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = entete,
            ForeColor = Theme.TexteDiscret,
            SelectionBackColor = entete,
            SelectionForeColor = Theme.TexteDiscret,
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point),
            Padding = new Padding(8, 0, 0, 0)
        };
        DefaultCellStyle = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            ForeColor = Theme.Texte,
            SelectionBackColor = Theme.PrimaireClair,
            SelectionForeColor = Theme.Texte,
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
            Padding = new Padding(8, 0, 0, 0)
        };
    }
}
