using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirCleArea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const float PI = 3.141f;
        private void button1_Click(object sender, EventArgs e)
        {
            float radius;
            float area;
            float circumference;
            radius = float.Parse(textBox1.Text);
            area = PI * (radius * radius);
            circumference = 2 * PI * radius;  

            MessageBox.Show("พื้นที่เท่ากับ :"+ area +"\nเส้นรอบรูปเท่ากับ :"+ circumference, "ผลการคำนวณ");
            //MessageBox.Show("เส้นรอบรูปเท่ากับ" + area, "ผลการคำนวณ");
        }
    }
}
