using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultat_Click(object sender, EventArgs e)
        {
            bool resultatvärde = ÄrEnSiffra(tbxTecken.Text[0]);     
            if (resultatvärde == true)                          
            {
                tbxResultat.Text = "Tecknet är en siffra";
            }
            else
            {
                tbxResultat.Text = "Tecknet är inte en siffra";
            }
        }
        bool ÄrEnSiffra(char tecken)
        {
            int teckenvärde = (int)tecken;
            if (teckenvärde >= 48 && teckenvärde <= 57)         //när man omvandlat tecken till en int så är det här spannet man har för att det ska vara siffror i unicode tabellen.
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

    }
}
