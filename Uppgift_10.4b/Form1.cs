using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._4b
{
    public partial class Form1 : Form
    {
        bool rita = false;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
                int bredd = int.Parse(tbxAntal.Text);         
                ritaCirklar(g, bredd);
            }
        }
        void ritaCirklar(Graphics g, int bredd)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int y = 40; y <= bredd * 20; y += 20)
            {
                for (int x = 0; x <= bredd * 20; x += 20)       //här har jag gjort en loop innuti en loop för att jag ska göra på flera rader, antalet rader neråt beror på antalet jag skrivit in.
                { 
                    g.FillEllipse(brush, x + y, y, 20, 20);     //x adderas med y för att det ska vara en förskjutning varje gång den här körs på nytt.
                }

            }
        }


    }
}