using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(tbxTal.Text);     // Ett double värde som defineras av talet i textrutan. String konverteras med hjälp av parse metoden.
            double heltal = tal / 1000 + 0.5;           //Gör en ny double variabel där man delar på 1000 för att vå en decimal, sen lägger man till 0.5.
            int heltalsvar = (int)heltal *1000;         //Omvandlar double till en int för att sen gångra det med 1000, då blir det ett heltal utan decimal.

            lblSvar.Text = heltalsvar.ToString();       //Visar svaret i en label, inten konverteras med ToString metoden.
            

        }
    }
}
