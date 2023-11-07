using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            btnKör.Text = "OK";                         //Ändrar knappens text till OK
            double ålder = double.Parse(tbxÅlder.Text); //Gör en double från åldern som skrivs i textrutan.
            if (ålder < 15 || ålder > 65)               //Kontrollerar om åldern är mindre än 15 eller högre än 65.
            {
                tbxSvar.Text = "Resan kostar 20kr";     //Skriver ut att resan kostar 20kr om man är under 15 eller över 65.
            }
            else
            {
                tbxSvar.Text = "Resan kostar 30kr";     //om man inte är under 15 eller 65 så skriver den att resan kostar 30kr.
            }            
        }
    }
}
