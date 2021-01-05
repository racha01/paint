using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowNumberCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click_1(object sender, EventArgs e)
        {
            int number1, number2, number3;
            int max = 0;
            //int sum;

            number1 = int.Parse(textNum1.Text);
            number2 = int.Parse(textNum2.Text);
            number3 = int.Parse(textNum3.Text);

            //sum = number1 - number2;

            //if (sum == 0)
            //MessageBox.Show("ตัวเลขทั้งสองมีค่าเท่ากัน ซึ่งเท่ากับ " + number1);

            /* int[] loopnum = new int[] { number1, number2, number3};
              int i = 0;
              int max = loopnum[0];
            
                while (i < 3)
                {
                    i++;
                    if (max <= loopnum[i])
                    {
                        max = loopnum[i];
                        MessageBox.Show("asd" + max);
                    }
                    else
                    {
                        return;
                    }
                
                } */

            if (max <= number1)
            {
                max = number1;
                if (max <= number2)
                {
                    max = number2;
                    if (max <= number3)
                    {
                        max = number3;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 3 ซึ่งเท่ากลับ" + max);
                    }
                    else
                    {
                        max = number2;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 2 ซึ่งเท่ากลับ " + max);
                    }
                }
                else if (max <= number3)
                {
                    max = number3;
                    if (max <= number2)
                    {
                        max = number2;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 2 ซึ่งเท่ากลับ" + max);
                    }
                    else
                    {
                        max = number3;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 3 ซึ่งเท่ากลับ" + max);
                    }
                }
                else
                {
                    max = number1;
                    if (max <= number2)
                    {
                        max = number2;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 2 ซึ่งเท่ากลับ" + max);
                    }
                    else
                    {
                        max = number1;
                        MessageBox.Show("ค่ามากสุดอยู่คือตัวเลขที่ 1 ซึ่งเท่ากลับ" + max);
                    }
                }
                   


            }
            
        }
    }
}
