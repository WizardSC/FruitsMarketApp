using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.Drawing;

[Designer(typeof(ParentControlDesigner))]
public partial class CustomPanel : UserControl
{
    // Các trường hiện tại
    Color _borderColor = Color.Blue;
    int _borderWidth = 5;
    int _borderRadius = 0;

    // Các thuộc tính hiện tại

    public int BorderWidth
    {
        get { return _borderWidth; }
        set
        {
            _borderWidth = value;
            Invalidate();
            PerformLayout();
        }
    }

    public int BorderRadius
    {
        get { return _borderRadius; }
        set
        {
            _borderRadius = value;
            Invalidate();
            PerformLayout();
        }
    }

    // Các phương thức hiện tại

    public CustomPanel() { }

    public override Rectangle DisplayRectangle
    {
        get
        {
            return new Rectangle(_borderWidth, _borderWidth, Bounds.Width - _borderWidth * 2, Bounds.Height - _borderWidth * 2);
        }
    }

    public Color BorderColor
    {
        get { return _borderColor; }
        set { _borderColor = value; Invalidate(); }
    }

    new public BorderStyle BorderStyle
    {
        get { return _borderWidth == 0 ? BorderStyle.None : BorderStyle.FixedSingle; }
        set { }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        if (this.BorderStyle == BorderStyle.FixedSingle)
        {
            using (Pen p = new Pen(_borderColor, _borderWidth))
            {
                Rectangle r = ClientRectangle;
                // Thay đổi vẽ để sử dụng GraphicsPath với BorderRadius
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddRectangle(r);
                    if (_borderRadius > 0)
                        path.AddArc(r.X, r.Y, _borderRadius * 2, _borderRadius * 2, 180, 90);
                    else
                        path.AddLine(r.X, r.Y, r.X, r.Y);

                    // Vẽ đường viền theo GraphicsPath
                    e.Graphics.DrawPath(p, path);
                }
            }
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        SetDisplayRectLocation(_borderWidth, _borderWidth);
    }
}
