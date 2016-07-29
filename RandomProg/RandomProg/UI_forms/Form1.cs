using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomProg.UI_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TopMost = true;
            ShowInTaskbar = true;
            Location = new Point(-450, 60); // app start position
            FormBorderStyle = FormBorderStyle.None; // This form should not have a border or else Windows will clip it.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Try me motherfucker!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
