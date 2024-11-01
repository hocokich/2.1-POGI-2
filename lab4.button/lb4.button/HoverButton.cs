using lb4.button.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace lb4.button
{
    public class HoverButton : Button
    {
        public Bitmap bitmap;
        //высота фона текста
        int heightWhtRectangle;
        public HoverButton() : base()
        {
            heightWhtRectangle = 40;
            // получение картинки из ресурсов
            bitmap = new Bitmap(Resources.banana);

            ForeColor = Color.Black;
            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
            Text = "Бибизяны в квадрате";
            TextAlign = ContentAlignment.MiddleCenter;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // отрисовка картинки в точке (0,0)
            pe.Graphics.DrawImage(bitmap, 0, 0, Size.Width, Size.Height);

            Brush brush = new SolidBrush(Color.FromArgb(125, 255, 255, 255));

            pe.Graphics.FillRectangle(brush, 0, 0, 315, heightWhtRectangle);
            pe.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black), ClientRectangle); 
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            heightWhtRectangle = 70;

            Text = "Бибизяны в квадрате\nКликни на кнопку";
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            heightWhtRectangle = 40;
            
            Text = "Бибизяны в квадрате";
        }
        protected override void OnResize(EventArgs e)
        {
            /*base.OnResize(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);*/
        }

    }
}
