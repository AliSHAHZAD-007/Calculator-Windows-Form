using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text = textBox2.Text + "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + ".";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = null;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text = textBox2.Text + "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text = textBox2.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text = textBox2.Text + "9";
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                String expression = textBox2.Text;
                textBox2.Text = Convert.ToString(new System.Data.DataTable().Compute(expression, null));

            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid expression");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + "/";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + "*";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + "+";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" && textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + "-";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
