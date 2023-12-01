using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213043_Qno07_Lab_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            string Date = dateTime.ToString("MMM dd,yyyy");
            string Day = dateTime.ToString("dddd");
            label1.Text = Date + "," + Date;
            string Time = dateTime.ToString("h:mm:ss:tt");
            label2.Text = Time;
        }
    }
}
