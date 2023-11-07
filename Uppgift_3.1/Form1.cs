using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double bas = double.Parse(tbxBas.Text);     //Gör en variabel som har värdet som sätts i textruta 1.
            double höjd = double.Parse(tbxHöjd.Text);   //Gör en variabel som har värdet som sätts i textruta 2.
            double svar = bas * höjd / 2;               //Tar båda värdena och gör en triangel area uträkning.
            string area = svar.ToString();              //Konverterar svaret av uträkningen till en string.
            lblSvar.Text = area;                        //Visar svaret i en label som finns under textrutorna.

        }
    }
}
