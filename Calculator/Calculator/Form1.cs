using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool enter_value = false;
        char iOPeration;
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Mminus_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" || enter_value == true)
                textBox_Result.Clear();
            enter_value = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                button_Equal.PerformClick();
                enter_value = true;
                operation = button.Text;
                textBox_Upper.Text = result + " " + operation;
            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox_Result.Text);
                enter_value = true;
                //textBox_Result.Text = "";
                textBox_Upper.Text = result + " " + operation;
                //textBox_Result.Text = "";
            }
        }

        private void button_CE(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button_C(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            textBox_Upper.Text = "";
            result = 0;
            operation = "";
            enter_value = false;
        }

        private void button_Click_Equal(object sender, EventArgs e)
        {
            textBox_Upper.Text = "";
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (result + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "–":
                    textBox_Result.Text = (result - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "×":
                    textBox_Result.Text = (result * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "÷":
                    textBox_Result.Text = (result / double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox_Result.Text);
            operation = "";
            enter_value = true;
        }


        private void button_Percentage(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0")
            {
                textBox_Result.Text = (double.Parse(textBox_Result.Text) / 100).ToString();
            }
            enter_value = true;
        }

        private void button_InversClick(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0")
            {
                textBox_Result.Text = (1 / double.Parse(textBox_Result.Text)).ToString();
            }
            enter_value = true;
        }

        private void button_ClickSquare(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0")
            {
                textBox_Result.Text = (Math.Pow(double.Parse(textBox_Result.Text), 2)).ToString();
            }
            enter_value = true;
        }

        private void button_RootClick(object sender, EventArgs e)
        {
            if (double.Parse(textBox_Result.Text) >= 0)
            {
                textBox_Result.Text = (Math.Pow(double.Parse(textBox_Result.Text), .5)).ToString();
            }
            enter_value = true;
        }

      
        
    }
}
