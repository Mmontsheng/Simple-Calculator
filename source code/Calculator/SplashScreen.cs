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
    public partial class SplashScreen : Form {
        private int counter = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter++;
            progressBar1.Value = counter;
            // label2.Text = (5*counter).ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
