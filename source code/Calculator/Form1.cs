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

namespace Calculator {
    public partial class Form1 : Form {
        double value = 0;
        string operation = "";
        Boolean operation_pressed = false;
        public Form1()
        {
         SplashScreen   sp = new SplashScreen();
            sp.ShowDialog();
            InitializeComponent();
            
        }

        
        public void startSplash()
        {
            Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            answerTextBox.Text = "0";
            value = 0;

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // deletes text one by one from the answer text box
            if (answerTextBox.Text.Length > 0)
            {
                answerTextBox.Text = answerTextBox.Text.Remove(answerTextBox.Text.Length - 1, 1);
                if (answerTextBox.Text.Length == 0)
                {
                    answerTextBox.Text = "0";
                    value = 0;
                }
            }
        }
        

        private void buttonPercent_Click(object sender, EventArgs e)
        {

            double results = double.Parse(answerTextBox.Text);
            answerTextBox.Text = Convert.ToString((results / 100));
           
        }
        
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(answerTextBox.Text);
            operation_pressed = true;
            equation.Text = value+" " +operation;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((answerTextBox.Text == "0") || operation_pressed)
            {
                answerTextBox.Clear();
            }
            operation_pressed = false;

            Button b = (Button)sender;
            answerTextBox.Text = answerTextBox.Text + b.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            equation.Text="";
            switch (operation) {
                case "+":
                    answerTextBox.Text = (value + Double.Parse(answerTextBox.Text)).ToString();
                    break;

                case "-":
                    answerTextBox.Text = (value - Double.Parse(answerTextBox.Text)).ToString();
                    break;

                case "*":
                    answerTextBox.Text = (value * Double.Parse(answerTextBox.Text)).ToString();
                    break;

                case "/":
                    answerTextBox.Text = (value / Double.Parse(answerTextBox.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (answerTextBox.Text.Contains(buttonDot.Text)) {
                return;
            }
            answerTextBox.Text += buttonDot.Text;
        }

        private void randomArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random_Numbers random_Numbers = new Random_Numbers();
            random_Numbers.ShowDialog();
        }

        private void randomArrayBubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumbersBubbleSort bubbleSort = new RandomNumbersBubbleSort();
            bubbleSort.ShowDialog();
        }

        private void massCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mass_Calculator mass_Calculator = new Mass_Calculator();
            mass_Calculator.ShowDialog();
        }
    }
}
