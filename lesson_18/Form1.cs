using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point location = new Point();

            location.X = 100;
            location.Y = 250;

            pictureBox1.Location = location;
        }

        enum cities {X, Adana, Adiyaman, Afyon, Agri, Amasya, Ankara, Antalya, Artvin, Aydin}
        private void button2_Click(object sender, EventArgs e)
        {
            int plate = Convert.ToInt32(textBox1.Text);

            cities c;

            c = (cities)plate;

            label1.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number;

            number = Convert.ToDouble(textBox2.Text);

            //label3.Text = Math.Abs(number).ToString();

            //label3.Text = Math.Ceiling(number).ToString();

            //label3.Text = Math.Floor(number).ToString();

            //label3.Text = Math.Pow(number, 2).ToString();

            //label3.Text = Math.Sqrt(number).ToString();


        }
    }
}
