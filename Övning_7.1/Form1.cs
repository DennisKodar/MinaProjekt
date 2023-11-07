using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double liter = double.Parse(tbxBensin.Text);        //En double som tar in decimalvärden (eller heltal) från textrutan.
            if (liter > 9.9)                                    
            {
                lblTanka.Text = "Lugnt att köra vidare";        //Om mängden i tanken är mer än 9.9 liter så skriver den att det är lugt att köra vidare.
            }
            else
            {
                double literTanka = 50 - liter;                 //Double värde som tar bort mängden man skrev in från 50 vilket är tankens volym i liter.
                double tankaKostar = literTanka * 14.50;        //Double värde som definerar kostnaden av att tanka genom att gångra med priset som bensinen kostar.
                lblTanka.Text = "Tanka " + literTanka + "liter. " + "Det kostar " + tankaKostar + " kr."; // Skriver i label hur mycket man behöver tanka och hur mycket det kostar att tanka.
            }
        }
    }
}
