using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientLabel : Label
{
    public Color StartColor { get; set; } = Color.DarkBlue;
    public Color EndColor { get; set; } = Color.LightSkyBlue;

    protected override void OnPaint(PaintEventArgs e)
    {
        // 背景を自分で描画するので親に描かせない
        using (LinearGradientBrush brush =
            new LinearGradientBrush(
                this.ClientRectangle,
                StartColor,
                EndColor,
                LinearGradientMode.Vertical))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        // 文字描画
        TextRenderer.DrawText(
            e.Graphics,
            this.Text,
            this.Font,
            this.ClientRectangle,
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        // ベースの描画は呼ばない
    }
}
