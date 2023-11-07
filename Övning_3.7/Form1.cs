using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string tecken = tbxTecken.Text;                                     //Sparar inmatningen i textrutan som en string variabel. 
            char symbol = tecken[0];                                            //Gör en char variabel som är första tecknet i textrutan.
            int kod = (int)symbol;                                              //Omvandlar char variabeln til en int.
            string svar = symbol.ToString() + " har koden " + kod.ToString();   //Gör en string som visar symbolen och nämner vilken unicode den har.
            lblSvar.Text = svar;                                                //Svaret visas i en label under textrutan.

        }
    }
}
