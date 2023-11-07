namespace Övning_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mitt första program",
                "Meddelande",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }
    }
}