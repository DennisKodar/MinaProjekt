using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // Ändrar bakgrund till röd när knapp klickas på
        private void btnRöd(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
        //Ändrar bakgrund till blå när knapp klickas på
        private void btnBlå(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
