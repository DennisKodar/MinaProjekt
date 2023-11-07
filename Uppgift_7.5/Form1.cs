using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRätta_Click(object sender, EventArgs e)
        {
            string svar1;
            string svar2;
            string svar3;

            if (tbxSvar1.Text == "x")
            {
                svar1 = "1. Rätt";      //spara svaret som rätt
            }
            else
            {
                svar1 = "1. Fel";       //om inte det är rätt blir det sparat som fel
            }

            if (tbxSvar2.Text == "x")
            {
                svar2 = "2. Rätt";
            }
            else
            {
                svar2 = "2. Fel";
            }
            if (tbxSvar3.Text == "1")
            {
                svar3 = "3. Rätt";
            }
            else
            {
                svar3 = "3. Fel";
            }

            tbxResultat.Text = svar1 + " " + svar2 + " " + svar3; 
        }
    }
}
