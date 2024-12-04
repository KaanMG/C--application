using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100 && progressBar2.Value != 100)
            {
                progressBar2.Value++;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100 && progressBar3.Value != 100)
            {
                progressBar3.Value++;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100 && progressBar4.Value != 100)
            {
                progressBar4.Value++;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("YOUR CAKE IS READY!");
            }
        }
    }
}
