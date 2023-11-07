using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random kast = new Random();                     //Gör ett nytt "slumpat" kast
            int resultat = kast.Next(1, 7);                 //Resultatet ska vara mellan 1 till 7 och här skapas kastet.

            if (resultat == int.Parse(tbxPrickar.Text))     //Här kontrollerar den ifall antalet prickar från "slumpen" är samma som du gissade på.
            {
                MessageBox.Show("Grattis!",                 //Visar en textruta med medelandet "Grattis!" ifall det är rätt.
                "Meddelande",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            lblSvar.Text = resultat.ToString();             //Skriver ut vilket "slumpvärde" det vart innan i en label.
        }
    }
}
