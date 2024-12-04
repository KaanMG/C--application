using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Book"].Points.AddXY("Mediterranean", 5);
            chart1.Series["Book"].Points.AddXY("Aegean", 8);
            chart1.Series["Book"].Points.AddXY("Central Anatolia", 3);
        }
    }
}
