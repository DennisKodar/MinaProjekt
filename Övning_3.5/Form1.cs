using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definierar det som skrivs i textruta 1 som en string för namn
            string Namn = tbxNamn.Text;
            //Definierar det årtal som skrivs i textruta 2 som en int och lägger till 50.
            int Född = int.Parse(tbxFödd.Text) + 50;
            
            //Skriver ut variabeln Född i string och string namn med lite extra ord inlagda i label.
            lblInfo.Text = Född.ToString() + " fyller " + Namn + " 50 år"; 
        }
    }
}
