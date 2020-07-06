using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        byte operaciq;

        public Form1()
        {
           

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Console.Beep();
            checkTextBox();
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Console.Beep();
            number1 = Convert.ToInt32(textBox1.Text);
            operaciq = 1;
            textBox1.Text = "";
            Console.WriteLine(13 / 5);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            number1 = Convert.ToInt32(textBox1.Text);
            operaciq = 2;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.Beep();
            number1 = Convert.ToInt32(textBox1.Text);
            operaciq = 3;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.Beep();
            number1 = Convert.ToInt32(textBox1.Text);
            operaciq = 4;
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.Beep();
            switch (operaciq)
            {
                case 1:
                    number2 = Convert.ToInt32(textBox1.Text);
                    number1 = number1 + number2;
                    string sbor = number1.ToString();
                    textBox1.Text = sbor;
                    break;

                case 2:
                    number2 = Convert.ToInt32(textBox1.Text);
                    number1 = number1 - number2;
                    string razlika = number1.ToString();
                    textBox1.Text = razlika;
                    break;

                case 3:
                    number2 = Convert.ToInt32(textBox1.Text);
                    number1 = number1 * number2;
                    string umnojenie = number1.ToString();
                    textBox1.Text = umnojenie;
                    break;

                case 4:
                    number2 = Convert.ToInt32(textBox1.Text);
                    if (number2 == 0) { textBox1.Text = "Не може да се дели на 0"; } 
                    number1 = number1 / number2;
                    string delenie = number1.ToString();
                    textBox1.Text = delenie;
                    break;
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void checkTextBox()
        {
            string helloW = "Hello World!";
            if (String.Compare(helloW, textBox1.Text)==0)
            {
                textBox1.Text = "";
            } // iztriva ot textBox ako v nego pishe Hello World!
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
