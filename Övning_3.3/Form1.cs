using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definierar inmatningarna från respektive textruta som en int.
            int TalA = int.Parse(tbxA.Text);
            int TalB = int.Parse(tbxB.Text);
            int TalC = int.Parse(tbxC.Text);
            //Sparar antalet som en int variabel för senare bruk.
            int antal = 3;


            //Gör en variabel för medel och summa som användes efter.
            double medel;
            double summa;
            //Medelvärdet blir då alla talen adderade ihop sen delade på antalet som definierades tidigare.
            medel = (TalA + TalB + TalC) / (double)antal;
            summa = TalA + TalB + TalC;

            //Visar resultatet i respektive label.
            lblSumma.Text = summa.ToString();
            lblMedel.Text = medel.ToString();
        }
    }
}
