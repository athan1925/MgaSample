using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgaSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;
            if ((uname == "user") && (pass == "123"))
            {
                MessageBox.Show("Hello User");

            }
            else
            {
                MessageBox.Show("Mali passsword");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
