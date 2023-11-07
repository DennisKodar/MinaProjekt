using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int veckanrdag = int.Parse(tbxNr.Text); //Skapar en variabel som bestäms av siffran i textrutan.
            switch (veckanrdag)                     //En switch jämförelse skapas för att kolla siffran i variabeln som skapades ovan.
            {
                case 1:                             //Gör en jämförelse vad siffran är, I detta fall så är det 1 så blir
                    tbxDag.Text = "Måndag";         //svaret Måndag, och så fortsätter det för andra veckodagar och nummer.
                    break;

                case 2:
                    tbxDag.Text = "Tisdag";
                    break;

                case 3:
                    tbxDag.Text = "Onsdag";
                    break;

                case 4:
                    tbxDag.Text = "Torsdag";
                    break;

                case 5:
                    tbxDag.Text = "Fredag";
                    break;

                case 6:
                    tbxDag.Text = "Lördag";
                    break;

                case 7:
                    tbxDag.Text = "Söndag";
                    break;

                default:                                //En default som används om ingen av ovan är passande för siffran.
                    tbxDag.Text = "Ej en giltig dag.";  //skriver då att det ej är en giltig dag.
                    break;
            }
        }

        private void tbxNr_TextChanged(object sender, EventArgs e)
        {
            tbxDag.Text = " ";          //Om siffran ändras i textrutan så rensas svarsrutan.
        }
    }
}
