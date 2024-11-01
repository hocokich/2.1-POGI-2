using lb4.button.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb4.button
{
    public partial class Form1 : Form
    {
        int n;
        int n1;
        public Form1()
        {
            InitializeComponent();
            n = 0;
            n1 = 0;
        }

        private void hoverButton1_KeyDown(object sender, MouseEventArgs e)
        {
            if (n == 0)
            {
                hoverButton1.bitmap = new Bitmap(Resources.dil);
                n++;
                return;
            }
            if (n == 1)
            {
                hoverButton1.bitmap = new Bitmap(Resources.banana);
                n++;
                return;
            }
            if (n == 2)
            {
                hoverButton1.bitmap = new Bitmap(Resources.keyesblood);
                n++;
                return;
            }
            if (n == 3)
            {
                hoverButton1.bitmap = new Bitmap(Resources.pon_monkey);
                n = 0;
                return;
            }
        }

        private void hoverButtonB1_KeyDown(object sender, MouseEventArgs e)
        {
            if (n1 == 0)
            {
                hoverButtonB1.bitmap = new Bitmap(Resources.dil);
                n1++;
                return;
            }
            if (n1 == 1)
            {
                hoverButtonB1.bitmap = new Bitmap(Resources.banana);
                n1++;
                return;
            }
            if (n1 == 2)
            {
                hoverButtonB1.bitmap = new Bitmap(Resources.keyesblood);
                n1++;
                return;
            }
            if (n1 == 3)
            {
                hoverButtonB1.bitmap = new Bitmap(Resources.pon_monkey);
                n1 = 0;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
