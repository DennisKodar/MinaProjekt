using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int size = 10;
            int maxsize = size * 10;
            Graphics g = e.Graphics;
            Color blå = Color.FromArgb(52, 67, 235);
            Pen cirkel = new Pen(blå);


            do
            {

                g.DrawEllipse(cirkel, ((Width + size) / 2) - size, ((Height + size) / 2) - size, size, size);
                size = size + 5;
            }
            while (size <= maxsize);

        }

      
    }
}
