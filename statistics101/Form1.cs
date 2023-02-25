using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistics101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statistics s = new statistics();
            Text = s.Radjsqr(0.5, 50, 5).ToString();
            textBox1.Text = Text;
            Text += " : ";
            Text += s.testRadjsqr(0.5, 50, 5, 0.164772727272727).ToString();
        }
    }
}
