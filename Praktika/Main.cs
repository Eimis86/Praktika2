using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            LoginA f = new LoginA();
            f.ShowDialog();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginA f = new LoginA();
            f.ShowDialog();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginA f = new LoginA();
            f.ShowDialog();
            //this.Hide();
        }
    }
}
