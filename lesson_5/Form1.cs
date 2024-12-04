using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, square, cube, add, sub, mul;
            double div;
 
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);
            square = number1*number1;
            cube = number1*number1*number1;

            add = number1+number2;
            sub = number1-number2;
            div = Convert.ToDouble(number1)/Convert.ToDouble(number2);
            mul = number1*number2;

            label4.Text = square.ToString();
            label5.Text = cube.ToString();
            label11.Text = add.ToString();
            label12.Text = sub.ToString();
            label13.Text = div.ToString("0.000");
            label14.Text = mul.ToString();

            MessageBox.Show("Addition = " + add + "\nSubtraction = " + sub + "\nDivision = " + div + "\nMultiplication = " + mul);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
