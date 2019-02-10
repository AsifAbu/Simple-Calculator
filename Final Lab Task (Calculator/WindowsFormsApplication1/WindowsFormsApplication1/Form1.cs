using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        double d;
        static double memory;
        static int c = 0;
        public Form1()
        {
            InitializeComponent();
            x();

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            button23.Enabled = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            textBox1.Text = null;
            if (c == 0)
            {
                label1.Text = (a + b).ToString();  //addition
            }
            else if (c == 1)
            {
                label1.Text = (a - b).ToString();  //subtruct
            }
            else if (c == 2)
            {
                label1.Text = (a * b).ToString(); //multiply
            }
            else if (c == 3)
            {
                label1.Text = (a / b).ToString(); //divide
            }
            else
                label1.Text = textBox1.Text;
            button23.Enabled = true;
            x();

        }
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if ((label1.Text).Equals("0"))
            {
                label1.Text = textBox1.Text ;
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 0;
            }
            else
            {
                d = double.Parse(label1.Text);
                label1.Text = ((double.Parse(textBox1.Text)) + (d)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 0;
            }
            button23.Enabled = true;
            x();

        }
        private void buttonSubtruct_Click(object sender, EventArgs e)
        {
            if ((label1.Text).Equals("0"))
            {
                label1.Text = (double.Parse(textBox1.Text)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 1;
            }
            else
            {
                d = double.Parse(label1.Text);
                label1.Text = ((double.Parse(textBox1.Text)) - (d)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 1;
            }
            button23.Enabled = true;
            x();

        }
        private void buttonMultplication_Click(object sender, EventArgs e)
        {
            if ((label1.Text).Equals("0"))
            {
                label1.Text = (double.Parse(textBox1.Text)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 2;
            }
            else
            {
                d = double.Parse(label1.Text);
                label1.Text = ((double.Parse(textBox1.Text)) * (d)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 2;
            }
            button23.Enabled = true;
            x();

        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            
            if ((label1.Text).Equals("0"))
            {
                label1.Text = (double.Parse(textBox1.Text)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 3;
            }
            else
            {
                d = double.Parse(label1.Text);
                label1.Text = ((double.Parse(textBox1.Text)) / (d)).ToString();
                a = double.Parse(textBox1.Text);
                textBox1.Text = null;
                c = 3;
            }
            button23.Enabled = true;
            x();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            button23.Enabled = true;
            y();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            label1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
            textBox1.Text = null;
            button23.Enabled = true;
        }
       
        private void buttonSqure_Click(object sender, EventArgs e)
        {
            double s = double.Parse(textBox1.Text);
            label1.Text = ( s * s).ToString();
            textBox1.Text = null;
            button23.Enabled = true;
        }

        private void buttonXDivide_Click(object sender, EventArgs e)
        {
            double s = double.Parse(textBox1.Text);
            label1.Text = (1 / s).ToString();
            textBox1.Text = null;
            button23.Enabled = true;
        }
        static int en = 0;
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (en == 0)
            {
                textBox1.Text += button23.Text;
                button23.Enabled = false;
                //en++;
            }
            else
                button23.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
            y();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
            y();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button19.Text;
            y();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
            y();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
            y();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
            y();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            y();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
            y();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            y();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += button22.Text;
            y();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0].Equals('-') | textBox1.Text.Equals(null))
            {
                if (textBox1.Text.Equals(null))
                {
                    if (label1.Text[0].Equals('-'))
                    {
                        label1.Text = label1.Text.TrimStart('-');
                    }
                    else
                        label1.Text = '-' + label1.Text;
                }
                else
                    textBox1.Text = textBox1.Text.TrimStart('-');
            }
            else
                textBox1.Text = '-'+ textBox1.Text;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);
            label1.Text = memory.ToString();
            textBox1.Text = null;
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            if (memory == 0)
            {
                memory = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            else
            {
                memory = memory + (double.Parse(textBox1.Text));
                textBox1.Text = null;
            }
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            if (memory == 0)
            {
                memory = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            else
            {
                memory = memory - (double.Parse(textBox1.Text));
                textBox1.Text = null;
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            label1.Text = memory.ToString();
            textBox1.Text = null;
        }

        private void buttonPersent_Click(object sender, EventArgs e)
        {
            double complete = double.Parse(textBox1.Text);
            label1.Text = (complete / 100).ToString();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(label1.Text);
        }
        private void x()
        {
            button8.Enabled = false;
            button12.Enabled = false;
            button16.Enabled = false;
            button20.Enabled = false;
            button24.Enabled = false;

        }
        private void y()
        {
            button8.Enabled = true;
            button12.Enabled = true;
            button16.Enabled = true;
            button20.Enabled = true;
            button24.Enabled = true;

        }

        
    }
}
