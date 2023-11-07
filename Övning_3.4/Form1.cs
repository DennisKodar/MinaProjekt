using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            //Definierar Engelska och svenska som en string, det som skrivs i respektive textruta lagras i variablen.
            string Engelska = tbxEngelska.Text;
            string Svenska = tbxSvenska.Text;

            //Skriver ut vad det engelska ordet betyder på svenska. 
            lblSvar.Text = Engelska + " betyder " + Svenska + " på svenska";

        }

    }
}
