using lb4.button.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb4.button
{
    internal class HoverButtonB : HoverButton
    {
        int heightWhtRectangle;

        public HoverButtonB() : base()
        {
            heightWhtRectangle = 20;

            ForeColor = Color.Black;
            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
            Text = "Бибизяны в круге";
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // отрисовка картинки в точке (0,0)
            pe.Graphics.DrawImage(bitmap, 0, 0, Size.Width, Size.Height);

            Brush brush = new SolidBrush(Color.FromArgb(125, 255, 255, 255));

            int x = (Width / 2) - 65;
            int y = (Height / 2) - 125;

            pe.Graphics.FillRectangle(brush, x, y, 130, heightWhtRectangle);
            pe.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black), new Point(x, y));
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            heightWhtRectangle = 35;

            Text = "Бибизяны в круге\nКликни на кнопку";
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            heightWhtRectangle = 20;

            Text = "Бибизяны в круге";
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }
    }
}
