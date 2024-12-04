using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double avarage, midterm, final, project;
            string name, surname, courseStatus;

            name = textBox1.Text;
            surname = textBox2.Text;

            midterm = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);

            avarage = (midterm+final+project)/3;

            if(avarage < 50)
            {
                courseStatus = "Failed";
            }
            else
            {
                courseStatus = "Successful";
            }

            listBox1.Items.Add(name+" "+surname+" Avarage = "+avarage+"  "+courseStatus);

        }
    }
}
