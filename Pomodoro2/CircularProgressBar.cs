using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


public class CircularProgressBar : Control
{
    public int Value { get; set; } = 0;
    public int MaxValue { get; set; } = 100;

    public Color ProgressColor { get; set; } = Color.FromArgb(56,132,255);
    public Color BackCircleColor { get; set; } = Color.FromArgb(230, 230, 230);
    public int Minimum { get; internal set; }
    public int Maximum { get; internal set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;
        int size = Math.Min(Width, Height);
        Rectangle rect = new Rectangle(5, 5, size - 10, size - 10);

        using (Pen backPen = new Pen(BackCircleColor, 15)) 
            e.Graphics.DrawArc(backPen,rect,0,360);

        float angle = 360f * Value / MaxValue;
        using (Pen progressPen=new Pen(ProgressColor, 15))
        {
            progressPen.EndCap=LineCap.Round;
            progressPen.StartCap=LineCap.Round;
            e.Graphics.DrawArc(progressPen, rect, -90, angle);
        }

        string text = $"{(int)(Value * 100 / MaxValue)}%";
        var format = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
        e.Graphics.DrawString(text, new Font("Segoe UI", 18, FontStyle.Bold),
            new SolidBrush(Color.FromArgb(40, 40, 40)), ClientRectangle, format);
    }
    }
