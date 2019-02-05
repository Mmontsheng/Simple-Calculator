using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {


    public partial class Mass_Calculator : Form {
        public Mass_Calculator()
        {
            InitializeComponent();
        }

        private void Mass_Calculator_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void convertAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate_textBox(sender as TextBox, e);
        }

        private void convertAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate_textBox(sender as TextBox, e);
        }

        private void validate_textBox(TextBox _text, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.')
            {
                // check if it's in the beginning of text not accept
                if (_text.Text.Length == 0)
                    e.Handled = true;
                // check if it's in the beginning of text not accept
                if (_text.SelectionStart == 0)
                    e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(_text.Text, ref sepratorChar))
                    e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (_text.SelectionStart != _text.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = _text.Text.Substring(_text.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(_text.Text, ref sepratorChar))
                {
                    int sepratorPosition = _text.Text.IndexOf(sepratorChar);
                    string afterSepratorString = _text.Text.Substring(sepratorPosition + 1);
                    if (_text.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            return false;
        }

        private void radioKg1_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "Kg";
            if (convertAnswer2.Text.Length>0) {
                if (radioKg2.Checked)
                {
                    convertAnswer1.Text = convertAnswer2.Text;
                }

                if (radioPound2.Checked)
                {
                    double answer = (Double.Parse(convertAnswer2.Text))/ 2.205;
                    //
                    convertAnswer1.Text = answer.ToString("0.0000");
                }

                if (radioGram2.Checked)
                {
                    double answer = (Double.Parse(convertAnswer2.Text)) / 1000;
                    //
                    convertAnswer1.Text = answer.ToString("0.0000");
                }
            }
          
        }

        private void radioPound1_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "lb";
            if (radioKg2.Checked)
            {
                double answer = 2.205 * (Double.Parse(convertAnswer2.Text));
                //
                convertAnswer1.Text = answer.ToString();
            }
            if (radioPound2.Checked)
            {
                convertAnswer1.Text = convertAnswer2.Text;
            }

            if (radioGram2.Checked)
            {
                double answer = (Double.Parse(convertAnswer2.Text)) / 453.592;
                //
                convertAnswer1.Text = answer.ToString("0.0000");
            }
        }

        private void radioGram1_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "g";
            if (radioKg2.Checked)
            {
                double answer = 1000 * (Double.Parse(convertAnswer2.Text));
                //
                convertAnswer1.Text = answer.ToString();
            }

            if (radioPound2.Checked)
            {
                double answer = 453.592 * (Double.Parse(convertAnswer2.Text));
                //
                convertAnswer1.Text = answer.ToString();
            }
            if (radioGram2.Checked)
            {
                convertAnswer1.Text = convertAnswer2.Text;
            }

        }

        private void radioTon1_CheckedChanged(object sender, EventArgs e)
        {
            unit1.Text = "t";
            if (radioKg2.Checked)
            {
                double answer = (Double.Parse(convertAnswer2.Text))/ 1000;
                //
                convertAnswer1.Text = answer.ToString("0.0000");
            }
            if (radioPound2.Checked)
            {
                double answer = (Double.Parse(convertAnswer2.Text)) / 2204.623;
                //
                convertAnswer1.Text = answer.ToString("0.0000");
            }

            if (radioGram2.Checked)
            {
                double answer =  (Double.Parse(convertAnswer2.Text))*1000000;
                //
                convertAnswer1.Text = answer.ToString();
            }
        }

        private void radioKg2_CheckedChanged(object sender, EventArgs e)
        {
            unit2.Text = "Kg";
            if (convertAnswer1.Text.Length > 0)
            {
                if (radioKg1.Checked)
                {
                    double answer = 1 * (Double.Parse(convertAnswer1.Text));
                    //
                    convertAnswer2.Text = answer.ToString();
                }

                if (radioPound1.Checked) {
                    double answer = (Double.Parse(convertAnswer1.Text))/ 2.205;
                    //
                    convertAnswer2.Text = answer.ToString("0.00000");
                }

                if (radioGram1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) / 1000;
                    //
                    convertAnswer2.Text = answer.ToString("0.00000");
                }

                if (radioTon1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) * 1000;
                    //
                    convertAnswer2.Text = answer.ToString("0.00");
                }
            }
        }

        private void radioPound2_CheckedChanged(object sender, EventArgs e)
        {
            unit2.Text = "lb";
            if (convertAnswer1.Text.Length > 0)
            {
                if (radioKg1.Checked)
                {
                    double answer = 2.205 * (Double.Parse(convertAnswer1.Text));
                    //
                    convertAnswer2.Text = answer.ToString();
                }
                if (radioPound1.Checked)
                {
                    convertAnswer2.Text = convertAnswer1.Text;
                }
                if (radioGram1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) / 453.592;
                    //
                    convertAnswer2.Text = answer.ToString("0.00000");
                }
                if (radioTon1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) * 2204.623;
                    //
                    convertAnswer2.Text = answer.ToString("0.0000");
                }

            }

        }

        private void radioGram2_CheckedChanged(object sender, EventArgs e)
        {
            unit2.Text = "g";
            if (convertAnswer1.Text.Length > 0)
            {
                if (radioKg1.Checked)
                {
                    double answer = 1000 * (Double.Parse(convertAnswer1.Text));
                    //
                    convertAnswer2.Text = answer.ToString();
                }
                if (radioPound1.Checked)
                {
                    double answer = 453.592 * (Double.Parse(convertAnswer1.Text));
                    //
                    convertAnswer2.Text = answer.ToString();
                }

                if (radioGram1.Checked)
                {
                    convertAnswer2.Text = convertAnswer1.Text;
                }

                if (radioTon1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) * 1000000;
                    //
                    convertAnswer2.Text = answer.ToString("0.0");
                }
            }

        }

        private void radioTon2_CheckedChanged(object sender, EventArgs e)
        {
            unit2.Text = "t";
            if (convertAnswer1.Text.Length > 0)
            {
                if (radioKg1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)/1000);
                    //
                    convertAnswer2.Text = answer.ToString();
                }
                if (radioPound1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text) / 2204.623);
                    //
                    convertAnswer2.Text = answer.ToString("0.00000000");
                }

                if (radioGram1.Checked)
                {
                    double answer = (Double.Parse(convertAnswer1.Text)) /1000000;
                    //
                    convertAnswer2.Text = answer.ToString("0.00000000");
                }
                if (radioTon1.Checked)
                {
                    convertAnswer2.Text = convertAnswer1.Text;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if there is text in both boxes
            if (convertAnswer1.Text.Length>0 || convertAnswer2.Text.Length>0) {
                
                if (radioKg1.Checked)
                {
                    if (radioKg2.Checked)
                    {
                        double answer = Double.Parse(convertAnswer1.Text);
                    }
                }
            }

        }

        private void convertAnswer1_TextChanged(object sender, EventArgs e)
        {
            //=========== similar conversions================
            if (radioKg1.Checked && radioKg2.Checked) {
                convertAnswer2.Text = convertAnswer1.Text;
            }
            if (radioPound1.Checked && radioPound2.Checked)
            {
                convertAnswer2.Text = convertAnswer1.Text;
            }
            if (radioGram1.Checked && radioGram2.Checked)
            {
                convertAnswer2.Text = convertAnswer1.Text;
            }

            if (radioTon1.Checked && radioTon1.Checked)
            {
                convertAnswer2.Text = convertAnswer1.Text;
            }
            //=========== similar conversions================



        }
    }
}
