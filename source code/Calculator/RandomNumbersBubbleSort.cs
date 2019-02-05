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
    public partial class RandomNumbersBubbleSort : Form {
        Random random = new Random();
        int[] array = new int[20];

        public RandomNumbersBubbleSort()
        {
            InitializeComponent();
        }

        private void RandomNumbersBubbleSort_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

            if (arrayTextBox.Left > 0)
            {
                arrayTextBox.Clear();
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(20);
            }

            for (int i = 0; i < array.Length; i++)
            {
                arrayTextBox.Text += (array[i]) + "\r\n";
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if ((array.Length) != 0)
            {

                BubbleSort(array);
                arrayTextBox.Clear();
                for (int i = 0; i < array.Length; i++)
                {
                    arrayTextBox.Text += (array[i]) + "\r\n";
                }
            }
        }





        private void BubbleSort(int[] a)
        {

            for (int i = 1; i <= a.Length - 1; ++i)

                for (int j = 0; j < a.Length - i; ++j)

                    if (a[j] > a[j + 1])


                        Swap(ref a[j], ref a[j + 1]);

        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


    }
}
