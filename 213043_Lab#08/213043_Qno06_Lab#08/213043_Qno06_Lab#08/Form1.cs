using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _213043_Qno06_Lab_08
{
    public partial class Form1 : Form
    {
        private int TotalTime;
        private int remaining;
        public Form1()
        {

            InitializeComponent();
            TotalTime = remaining = 0;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TotalTime = (int)numericUpDown1.Value;
            remaining = TotalTime;
            Updatetime();
            timer1.Enabled = true;
            timer1.Start();
            numericUpDown1.Enabled = false;
            button1.Enabled = false;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
           
            numericUpDown1.Increment = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = false;
            label3.Visible = false;
        }

        private void  Updatetime()
        {
            label3.Visible=true;
            label3.Text  = remaining.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remaining--;
            Updatetime();
            if (remaining == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up!!!");
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
        }
    }
}
