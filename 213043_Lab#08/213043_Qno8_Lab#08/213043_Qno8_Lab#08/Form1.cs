using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213043_Qno8_Lab_08
{
    public partial class Form1 : Form
    {
        private string[] imageFiles = new string[5];
        private int current = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string folder = @"C:\Users\HP\OneDrive\Desktop";
            imageFiles = Directory.GetFiles(folder, "*.png");

            foreach (string imageFile in imageFiles)
            {
                listBox1.Items.Add(imageFile);
            }

            label3.Text = listBox1.Items.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = imageFiles[current];
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
        }
    }
}
