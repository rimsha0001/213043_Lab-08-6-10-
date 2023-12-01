using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213043_Qno09_Lab_08
{
    public partial class Form1 : Form
    {
        int remaining;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            remaining = textBox1.MaxLength - textBox1.TextLength;
            label2.Text = remaining.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "0";
        }
    }
}
