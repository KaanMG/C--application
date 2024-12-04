using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int counter = 0;
        int i = 1, j = 2;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Text = "Continue";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        
            
        counter++;
        label1.Text = counter.ToString();        
        if (counter == 1*i)
        {
            this.BackColor = Color.Blue;    
            i += 2;   
        }
        if(counter == 1 * j)
        {
            this.BackColor = Color.Red;
            j += 2;
        }        
             
        }
    }
}
