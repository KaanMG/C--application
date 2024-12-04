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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car rb2 = new Car();

            rb2.color = "Green";
            rb2.speed = 340;
            rb2.engineSize = 3.5;
            rb2.price = 5750000;
            rb2.status = 'S';
            rb2.Year = -2020;
            rb2.Brand = "mercedes";
            rb2.inspection = 2024;
            rb2.plate = "63 EG 777";
            rb2.owner = "Melih";

            label1.Text = rb2.color;
            label2.Text = rb2.speed.ToString();
            label3.Text = rb2.engineSize.ToString();
            label4.Text = rb2.price.ToString();
            label5.Text = rb2.status.ToString();
            label6.Text = rb2.Year.ToString();
            label7.Text = rb2.Brand;
            label8.Text = rb2.inspection.ToString();
            label9.Text = rb2.plate;
            label10.Text = rb2.owner;

            pictureBox1.BackColor = Color.Green;
        }
    }
}
