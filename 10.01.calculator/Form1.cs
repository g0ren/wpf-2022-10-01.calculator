using System;
using System.Data;
namespace _10._01.calculator
{
    public partial class Form1 : Form
    {
        private const string EMPTY = "";
        private const string ZERO = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox2.Text = ZERO;
            }
            if (!(textBox1.Text == ZERO))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text;
            textBox1.Text += "-";
            textBox2.Text = ZERO;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(ZERO))
                textBox2.Text = EMPTY;
            
            textBox2.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            
            textBox2.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            
            textBox2.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            
            textBox2.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            
            textBox2.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            
            textBox2.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            textBox2.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            textBox2.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ZERO)
                textBox2.Text = EMPTY;
            textBox2.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!(textBox2.Text == ZERO))
            {
                textBox2.Text += "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!(textBox2.Text.Contains(".")))
            {
                textBox2.Text += ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text;
            textBox1.Text += "/";
            textBox2.Text = ZERO;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text;
            textBox1.Text += "*";
            textBox2.Text = ZERO;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox2.Text;
            textBox1.Text += "+";
            textBox2.Text = ZERO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ZERO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = ZERO;
            textBox1.Text = EMPTY;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // calculating result!
            textBox1.Text += textBox2.Text;
            textBox2.Text = new DataTable().Compute(textBox1.Text, null).ToString();
            textBox1.Text = EMPTY;
        }
    }
}