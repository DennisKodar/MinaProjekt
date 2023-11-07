using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Visar ruta med titel "övning" och presenterar en Ja eller Nej fråga.
            MessageBox.Show("Är det roligt att programmera",
                "Övning",
                MessageBoxButtons.YesNo);
        }
    }
}
