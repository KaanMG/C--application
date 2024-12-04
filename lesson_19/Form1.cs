using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnlocation = new Point(20,10);

            btn.Name = "Button2";
            btn.Text = "Click";
            btn.BackColor = Color.Green;
            btn.Location = btnlocation;
            btn.Height = 70;
            btn.Width = 70;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lbllocation = new Point(250,250);

            lbl.Name = "Label1";
            lbl.Text = "Hello";
            lbl.Location = lbllocation;
            lbl.BackColor = Color.CadetBlue;
            lbl.AutoSize = true;

            this.Controls.Add(lbl);

        }
    }
}
