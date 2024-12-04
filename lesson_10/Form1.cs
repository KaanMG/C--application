using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void colorIt()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.Green;
            textBox3.BackColor = Color.Blue;
            textBox4.BackColor = Color.Red;

        }

        private int addition(int value1, int value2)
        {
            return value1 + value2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorIt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(addition((Convert.ToInt32(textBox5.Text)),Convert.ToInt32(textBox6.Text)));
        }
    }
}
