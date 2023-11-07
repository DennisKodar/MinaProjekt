using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double radieuträkning(double radie)             //En metod som används för att räkna ut arean av en cylinder, den anropas på rad 27 där rad variabeln blir kopierad till metoden.
        {
            double area = (Math.PI * radie * radie);
            return area;
        }
        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double rad = double.Parse(tbxRadie.Text);
            double are = radieuträkning(rad);
            tbxArea.Text = are.ToString();
        }
    }
}
