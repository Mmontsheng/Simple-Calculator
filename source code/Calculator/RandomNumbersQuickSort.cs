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
    public partial class Random_Numbers : Form {
        Random random = new Random();
        int[] array = new int[40];
        public Random_Numbers()
        {
            InitializeComponent();
        }

        private void Random_Numbers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if ((array.Length )!= 0)
            {

                QuickSortNow(array, 0, array.Length - 1);
                arrayTextBox.Clear();
                for (int i = 0; i < array.Length; i++)
                {
                    arrayTextBox.Text += (array[i]) + "\r\n";
                }
            }
            else
            {
                arrayTextBox.Text="No arrays found";
                arrayTextBox.AppendText("Click generate button first");
            }    


        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
           

            if (arrayTextBox.Left>0) {
                arrayTextBox.Clear();
            }

            for (int i=0; i<array.Length; i++) {
                array[i] = random.Next(40);
            }

            for (int i = 0; i < array.Length; i++) {
                arrayTextBox.Text+=(array[i]) + "\r\n";
            }
        }



        public static void QuickSortNow(int[] iInput, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(iInput, start, end);
                QuickSortNow(iInput, start, pivot - 1);
                QuickSortNow(iInput, pivot + 1, end);
            }
        }

        public static int Partition(int[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] <= pivot)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }
    }
}
