using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            char versal = tbxVersal.Text[0];    //Sparar första tecknet i textrutan som en char variabel (ska vara stor bokstav).
            int kod = versal + 32;              //Omvandlar char till en int variabel och går upp 32 steg i unicode tabellen.

            char svar = (char)kod;              //Gör "kod" variabeln till en char variabel som definierar "svar".
            string svarRätt = svar.ToString();  //Skapar en string variabel som är definierad av "svar" som konverteras till string.
            lblSvar.Text = svarRätt;            //Visar den lilla bokstaven i label under textrutan.




        }
    }
}
