﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Melih";
            label7.Text = "Gencdogan";
            label8.Text = "Computer engineer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Melih";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }
    }
}
