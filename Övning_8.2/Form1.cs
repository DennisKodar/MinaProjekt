using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_8._2
{
    public partial class Form1 : Form
    {
        private string figur = "grön";                              //en sats som sätter så grön är värdet först
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            SolidBrush brushBlack = new SolidBrush(Color.Black);    //Skapar 3 brush som är av olika färger
            SolidBrush brushGreen = new SolidBrush(Color.Green);
            SolidBrush brushRed = new SolidBrush(Color.Red);
            g.FillRectangle(brushBlack, 50, 50, 120, 200);

            if (figur.Equals("grön"))
            {
                g.FillEllipse(brushGreen, 70, 150, 80, 80);         //den kollar så det är grönt och ritar en helfylld cirkel
            }
            else if (figur.Equals("röd"))                           //den kollar så det är röd och ritar en helfylld cirkel
            {
                g.FillEllipse(brushRed,70,70,80,80)
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)      //knappen byter om värdena så att cirkeln ritas om i rätt färg
        {
            if (figur.Equals("grön"))
            {
                figur = "röd";
            }
            else
            {
                figur = "grön";
            }
            Invalidate();
        }
    }
}
