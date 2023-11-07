using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(tbxKod.Text);   //Gör en int variabel som defineras av det som skrivs i textrutan.
            char symbol = (char)kod;            //Gör en char variabel där koden konverteras till en karaktär.
            string svar = symbol.ToString();    //Omvandlar char variabeln till en string med hjälp av ToString.
            lblTecken.Text = svar;              //Visar ut string variabeln svar i label'n, svaret blir då ett tecken.
        }
    }
}
