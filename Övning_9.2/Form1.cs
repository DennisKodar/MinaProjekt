using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {
            long ruta = 1;
            decimal betala = 1;                 //använder en decimal för att visa exakta värdet som jag får utan att det loopar om eller visar fel.
            long maxrutor = 64;                 //antalet rutor på ett bräde.
            while (ruta < maxrutor)
            {
                ++ruta;
                betala *= 2;        
                tbxUtdata.AppendText("Ruta " + ruta + ":\t" + betala + "\r\n"); //skriver ut det med tab escape sequence men också sen så det blir en ny rad.

            }
        }
    }
}
