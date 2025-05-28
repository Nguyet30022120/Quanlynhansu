using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
	public int BorderRadius { get; set; } = 20; // Độ bo góc

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		Graphics g = e.Graphics;
		g.SmoothingMode = SmoothingMode.AntiAlias;

		Rectangle bounds = this.ClientRectangle;
		int radius = BorderRadius;

		using (GraphicsPath path = GetRoundedRectPath(bounds, radius))
		{
			this.Region = new Region(path); // Áp dụng khung tròn
			using (Pen pen = new Pen(Color.Gray, 1)) // Viền nếu muốn
			{
				g.DrawPath(pen, path);
			}
		}
	}

	private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
	{
		GraphicsPath path = new GraphicsPath();
		float r = radius;
		path.StartFigure();
		path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
		path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90);
		path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
		path.AddArc(rect.Left, rect.Bottom - r, r, r, 90, 90);
		path.CloseFigure();
		return path;
	}
}
