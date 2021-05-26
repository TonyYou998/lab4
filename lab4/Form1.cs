using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 f = new bai1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 f = new bai2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 f = new bai3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 f = new bai4();
            f.Show();
        }
    }
}
