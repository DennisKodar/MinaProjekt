using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBytPlats_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(tbxTal1.Text);

            int tal2 = int.Parse(tbxTal2.Text);

            byt( tal1, tal2);

            lblTal1.Text = tal1.ToString();
            lblTal2.Text = tal2.ToString();
        }
        void byt( int a, int b)                     //när man tar bort ref här och på rad 26 så märker man att det ändras bara i den temporära variabeln men skickas aldrig tillbaka dit man anropar.
        {
                int temp = a;

                a = b;

                b = temp;

        }
        private void tbxTal1_TextChanged(object sender, EventArgs e)
        {
            lblTal1.Text = "";
            lblTal2.Text = "";
        }
        private void tbxTal2_TextChanged(object sender, EventArgs e)
        {
            lblTal1.Text = "";
            lblTal2.Text = "";
        }
    }
}
