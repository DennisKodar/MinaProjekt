using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._4
{
    public partial class Form1 : Form
    {
        bool rita = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRita_Click(object sender, EventArgs e)
        {
            rita = true;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (rita)
            {
                Graphics g = e.Graphics;
                int bredd = int.Parse(tbxAntal.Text);           //fångar upp antalet från det anavändaren skrivit in
                ritaCirklar(g, bredd);
            }
        }
        void ritaCirklar(Graphics g, int bredd)
        {
            SolidBrush brush = new SolidBrush(Color.Red);           //metoden som anropas på rad 32, den ritar upp rätt mängd med en förinställd storlek på de fyllda cirklarna.
            for (int antal = 0; antal < bredd; ++antal)
            {
                g.FillEllipse(brush, antal * 20 + 30, 50, 20, 20);
            }
        }

        
    }
}
