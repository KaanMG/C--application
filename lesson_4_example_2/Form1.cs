using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_4_example_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route : "+comboBox1.Text+" - "+comboBox2.Text+" Date : "+dateTimePicker1.Text+" Time : "+maskedTextBox4.Text+" Name-Surname : "+textBox1.Text+" ID number : "+maskedTextBox2.Text+" Phone Number : "+maskedTextBox3.Text);
        }
    }
}
