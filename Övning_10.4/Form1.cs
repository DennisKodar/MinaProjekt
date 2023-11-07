using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._4
{
    public partial class Form1 : Form
    {
        bool rita = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRitaTriangel_Click(object sender, EventArgs e)
        {
            rita = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (rita)
            {
                Graphics g = e.Graphics;
                int höjd = int.Parse(tbxHöjd.Text);
                ritaTriangel(g, höjd);
            }
        }

        void ritaTriangel(Graphics g, int höjd)
        {
            SolidBrush brush = new SolidBrush(Color.Red);

            for (int rad = 1; rad <= höjd; rad++)
            {
                for (int kolumn = 1; kolumn <= rad; kolumn++)
                {
                    g.FillEllipse(brush, kolumn * -20 +100 + höjd * 20, 30 + rad * 20, 20, 20);     //Höjd används som en variabel för att dedikera vilken offset man får ju större triangeln blir.
                }
            }
        }

        private void tbxHöjd_TextChanged(object sender, EventArgs e)
        {
            rita = false;
            Invalidate();

        }
    }

}
