using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Övning_3._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlytta_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbxX.Text);
            int y = int.Parse(tbxY.Text);
            Point Position = new Point(x, y);
            btnFlytta.Location = Position;
        }
    }
}
