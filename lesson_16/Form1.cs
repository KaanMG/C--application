using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int n1, n2, n3, n4;

            n1 = rand.Next(1, 5);
            n2 = rand.Next(1, 5);
            n3 = rand.Next(1, 5);
            n4 = rand.Next(1, 5);

            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            label4.Text = n4.ToString();

            //if((Convert.ToInt32(textBox1.Text) == Convert.ToInt32(label1.Text)) && (Convert.ToInt32(textBox2.Text) == Convert.ToInt32(label2.Text)) && (Convert.ToInt32(textBox3.Text) == Convert.ToInt32(label3.Text)) && (Convert.ToInt32(textBox4.Text) == Convert.ToInt32(label4.Text)))
            //{
            //    MessageBox.Show("Congratulations, you got it right");
            //}

            if(label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if(label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text) 
            { 
                textBox3.BackColor = Color.Green; 
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if(label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
