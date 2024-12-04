using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car rb = new Car();
            rb.color = "Blue";
            rb.speed = 260;
            rb.engineSize = 2.0;
            rb.price = 2500000;
            rb.status = 'C';

            label1.Text = rb.color;
            label2.Text = rb.speed.ToString();
            label3.Text = rb.engineSize.ToString();
            label4.Text = rb.price.ToString();
            label5.Text = rb.status.ToString();

            pictureBox1.BackColor = Color.Blue;
        }
    }
}
