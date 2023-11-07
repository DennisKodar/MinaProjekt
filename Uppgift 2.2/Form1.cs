using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //flyttar label 10 enheter åt vänster
        private void btnVänster(object sender, EventArgs e)
        {
            lblFlytta.Left = lblFlytta.Left - 10;
        }
        //flyttar label 10 enheter åt höger
        private void btnHöger(object sender, EventArgs e)
        {
            lblFlytta.Left = lblFlytta.Left + 10;
        }

    }
}
