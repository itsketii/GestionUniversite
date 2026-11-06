using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

partial class UcEnConstruction
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblMessage = new Label();
        SuspendLayout();
        //
        // lblMessage
        //
        lblMessage.Dock = DockStyle.Fill;
        lblMessage.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        lblMessage.ForeColor = Color.FromArgb(107, 96, 99);
        lblMessage.Text = "Écran en construction";
        lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        lblMessage.Name = "lblMessage";
        lblMessage.TabIndex = 0;
        //
        // UcEnConstruction
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 243, 242);
        Size = new Size(1040, 760);
        Name = "UcEnConstruction";
        Controls.Add(lblMessage);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblMessage;
}
