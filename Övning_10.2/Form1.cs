using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double volymCylinder(double radie, double höjd)
        {
            double uträkning = Math.PI * radie * radie * höjd;  //uträkning  för en cylinders volym görs här och den anropas på rad 28.
            return uträkning;
        }
        private void btnMinst_Click(object sender, EventArgs e)
        {
            double radie = double.Parse(tbxRadie.Text);
            double höjd = double.Parse(tbxHöjd.Text);
            double resultat = volymCylinder(radie, höjd);
            lblMinst.Text = resultat.ToString();
        }
    }
}
