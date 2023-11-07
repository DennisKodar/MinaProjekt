using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string Namn1 = tbxNamn1.Text;           //En string variabel som definieras av textruta 1's inmatning.
            string Namn2 = tbxNamn2.Text;           //En string variabel som definieras av textruta 2's inmatning.

            if (Namn1.CompareTo(Namn2) <= 0)        //En if sats där man jämför om namn 1 har högre bokstavsvärde än namn 2.
            {
                tbxSvar.Text = Namn1 + " " + Namn2; //Om Namn 1 har högre värde i alfabetet så skrivs det ut i efternamn och sen förnamn.
            }
            else 
            {
                tbxSvar.Text = Namn2 + " " + Namn1; //Om Namn 1 inte har högre värde alfabetiskt så skrivs Förnamn sen Efternamn.
            }
        }
    }
}
