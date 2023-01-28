using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                float n = float.Parse(textBox1.Text);
                n = (float)(n * 9.95);
                textBox7.Text = n.ToString();
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                float n = float.Parse(textBox2.Text);
                n = (float)(n * 19.95);
                textBox8.Text = n.ToString();
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                float n = float.Parse(textBox3.Text);
                n = (float)(n * 14.95);
                textBox9.Text = n.ToString();
            }
            else
            {
                textBox3.Text = "0";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            if (textBox7.Text != "")
            {
                total += float.Parse(textBox7.Text);
            }
            if (textBox8.Text != "")
            {
                total += float.Parse(textBox8.Text);
            }
            if (textBox9.Text != "")
            {
                total += float.Parse(textBox9.Text);
            }
            textBox11.Text = "$" + total.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            if (textBox7.Text != "")
            {
                total += float.Parse(textBox7.Text);
            }
            if (textBox8.Text != "")
            {
                total += float.Parse(textBox8.Text);
            }
            if (textBox9.Text != "")
            {
                total += float.Parse(textBox9.Text);
            }
            textBox11.Text = "$" + total.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            if (textBox7.Text != "")
            {
                total += float.Parse(textBox7.Text);
            }
            if (textBox8.Text != "")
            {
                total += float.Parse(textBox8.Text);
            }
            if (textBox9.Text != "")
            {
                total += float.Parse(textBox9.Text);
            }
            textBox11.Text = "$" + total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
