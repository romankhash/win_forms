using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private string[] images = { "mem1.jfif", "mem2.jfif", "mem3.jfif" };
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }

        private void ShowImage()
        {
            if (File.Exists(images[index]))
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

                pictureBox1.Image = Image.FromFile(images[index]);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show($"Τΰιλ {images[index]} νε νΰιδεν β οΰοκε bin/Debug/...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0) index = images.Length - 1;
            ShowImage();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            index++;
            if (index >= images.Length) index = 0;
            ShowImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
