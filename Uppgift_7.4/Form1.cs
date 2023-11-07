using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKörSwitch_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxTal1.Text);           
            char räknesätt = char.Parse(tbxRäknesätt.Text);     //hämtar ett räknesätt för att det sedan ska användas i switch case sats.
            double tal2 = double.Parse(tbxTal2.Text);           

            switch (räknesätt)                                  
            {
                case '+':                                       //användarens inmatning av räknesätt.
                    double resultatplus = tal1 + tal2;          //Då tar det och skapar en resultat variabel och sen räknar den ut med talen som finns.
                    tbxSvar.Text = resultatplus.ToString();
                    break;
                case '-':
                    double resultatmin = tal1 - tal2;
                    tbxSvar.Text = resultatmin.ToString();
                    break;
                case '/':
                    double resultatdiv = tal1 / tal2;
                    tbxSvar.Text = resultatdiv.ToString();
                    break;
                case '*':
                    double resultatmul = tal1 * tal2;
                    tbxSvar.Text = resultatmul.ToString();
                    break;
                default:
                    tbxSvar.Text = "felinmatning";
                    break;
            }
        }

        private void btnKörIf_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(tbxTal1.Text);
            char räknesätt = char.Parse(tbxRäknesätt.Text);     //hämtar ett räknesätt för att det sedan ska användas i if och else if satsen.
            double tal2 = double.Parse(tbxTal2.Text);
            if (tbxRäknesätt.Text == "+")                       //kollar användares val av räknesätt.
            {
                double resultat = tal1 + tal2;                  //räknar ut i en lokal resultat variable som sen skrivs som svar.

                tbxSvar.Text = resultat.ToString();
            }
            else if (tbxRäknesätt.Text == "-")
            {
                double resultat = tal1 - tal2;

                tbxSvar.Text = resultat.ToString();
            }
            else if (tbxRäknesätt.Text == "/")
            {
                double resultat = tal1 / tal2;

                tbxSvar.Text = resultat.ToString();
            }
            else if (tbxRäknesätt.Text == "*")
            {
                double resultat = tal1 * tal2;

                tbxSvar.Text = resultat.ToString();
            }
            else
            {
                tbxSvar.Text = "Ogiltigt räknesätt";
            }
        }
    }
}
