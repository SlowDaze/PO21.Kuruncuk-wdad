using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 aVG = new Form2();
            aVG.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 aVG = new Form3();
            aVG.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 aVG = new Form4();
            aVG.Show();
            Hide();
        }
    }
}
