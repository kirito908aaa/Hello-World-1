using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = textBoxC.Text;

            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            textBoxF.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBoxF.Text);
            double c = (f - 32) * 5 / 9;
            //show input to textbox
            textBoxC.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}
