using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._6
{
    public partial class Form1 : Form
    {
        double radie;
        double höjd;
        public Form1()
        {
            InitializeComponent();
        }
        double volymCylinder(double radie, double höjd)
        {
            double uträkning = Math.PI * radie * radie * höjd;  
            return uträkning;
        }
        void höjdRadie(out double radie, out double höjd)
        {
            radie = double.Parse(tbxRadie.Text);                //en hel metod som tar in radien i variablerna som definieras i början på rad 15 och 16, och det anropas på rad 33
            höjd = double.Parse(tbxHöjd.Text);
        }
        private void btnMinst_Click(object sender, EventArgs e)
        {
            höjdRadie(out radie, out höjd);
            double resultat = volymCylinder(radie, höjd);
            lblMinst.Text = resultat.ToString();
        }
    }
}
