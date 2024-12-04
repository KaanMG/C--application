using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] symbol2 = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "]", "{", "}", "|", ";", ":", "'", ",", "<", ".", ">", "/", "?" };

            Random rand = new Random();
            int s1, s2, s3, s4, s5, s6;
            string captcha;
            s1 = rand.Next(0, symbol.Length);
            s4 = rand.Next(0, symbol.Length);
            s2 = rand.Next(0, symbol2.Length);
            s5 = rand.Next(0, symbol2.Length);
            s3 = rand.Next(0,10);
            s6 = rand.Next(0, 10);
            captcha = symbol[s1].ToString() + symbol2[s2].ToString() + s3.ToString() + symbol[s4].ToString() + symbol2[s5].ToString() + s5.ToString();

            label1.Text = symbol[s1].ToString() + symbol2[s2].ToString() + s3.ToString() + symbol[s4].ToString() + symbol2[s5].ToString() + s5.ToString();

            Form2 frm = new Form2();
            frm.message = captcha;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
