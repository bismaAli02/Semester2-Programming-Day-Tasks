using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator_App.BL;

namespace Calculator_App.GUI
{
    public partial class CalculatorForm : Form
    {

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "0";
            CalculatorClass.Operand1 = "";
            CalculatorClass.Operand2 = "";
            CalculatorClass.Op = ' ';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string R = textBox1.Text;
                textBox1.Text = "";
                for (int i = 0; i < R.Length - 1; i++)
                {
                    textBox1.Text = textBox1.Text + R[i];
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {

            }
            else if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '/';
                    CalculatorClass.Operand1 = textBox1.Text;
                    label1.Text = textBox1.Text + "/";
                    textBox1.Text = "";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Operand2 = textBox1.Text;
                    float R = CalculatorClass.PerformOperation();
                    CalculatorClass.Operand1 = R.ToString();
                    CalculatorClass.Op = '/';
                    label1.Text = R.ToString() + CalculatorClass.Op;
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '/';
                    label1.Text = CalculatorClass.Operand1 + CalculatorClass.Op;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {

            }
            else if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '*';
                    CalculatorClass.Operand1 = textBox1.Text;
                    label1.Text = textBox1.Text + "*";
                    textBox1.Text = "";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Operand2 = textBox1.Text;
                    float R = CalculatorClass.PerformOperation();
                    CalculatorClass.Operand1 = R.ToString();
                    CalculatorClass.Op = '*';
                    label1.Text = R.ToString() + CalculatorClass.Op;
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '*';
                    label1.Text = CalculatorClass.Operand1 + CalculatorClass.Op;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {

            }
            else if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Op = '-';
                    CalculatorClass.Operand1 = textBox1.Text;
                    label1.Text = textBox1.Text + "-";
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = "-";

                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Operand2 = textBox1.Text;
                    float R = CalculatorClass.PerformOperation();
                    CalculatorClass.Operand1 = R.ToString();
                    CalculatorClass.Op = '-';
                    label1.Text = R.ToString() + CalculatorClass.Op;
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '-';
                    label1.Text = CalculatorClass.Operand1 + CalculatorClass.Op;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "-")
            {
                textBox1.Text = "";
            }
            else if (CalculatorClass.Op == ' ')
            {
                if (textBox1.Text != "")
                {

                    CalculatorClass.Op = '+';
                    CalculatorClass.Operand1 = textBox1.Text;
                    label1.Text = textBox1.Text + "+";
                    textBox1.Text = "";
                }
            }
            else
            {
                if (textBox1.Text != "")
                {
                    CalculatorClass.Operand2 = textBox1.Text;
                    float R = CalculatorClass.PerformOperation();
                    CalculatorClass.Operand1 = R.ToString();
                    CalculatorClass.Op = '+';
                    label1.Text = R.ToString() + CalculatorClass.Op;
                    textBox1.Text = "";
                }
                else
                {
                    CalculatorClass.Op = '+';
                    label1.Text = CalculatorClass.Operand1 + CalculatorClass.Op;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (CalculatorClass.Op != ' ')
                {
                    CalculatorClass.Operand2 = textBox1.Text;
                    label1.Text = CalculatorClass.PerformOperation().ToString();
                    CalculatorClass.Operand1 = label1.Text;
                    textBox1.Text = CalculatorClass.Operand1;
                    CalculatorClass.Op = ' ';
                }
            }
        }
    }
}
