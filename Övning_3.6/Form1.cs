using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string förnamn = tbxFörnamn.Text;                                   //Gör input från textruta 1 till en string variabel.
            string efternamn = tbxEfternamn.Text;                               //Gör input från textruta 2 till en string variabel.
            char F1 = förnamn[0];                                               //Sparar första bokstaven i förnamnet i en char variabel.
            char E1 = efternamn[0];                                             //Sparar första bokstaven i efternamnet i en char variabel.
            string svar = förnamn + " har intitialerna " + F1 + "." + E1;       //Skriver en text och lägger ihop båda char variabler för att visa initialer.
            lblSvar.Text = svar;                                                //Skickar svaret till en label som visar texten ovan.
        }

    }
}
