using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("спочатку відкрийте файл!");
                return;
            }

            try
            {
                File.WriteAllText(filePath, textBox1.Text);
                MessageBox.Show("файл успішно збережено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("помилка при збереженні: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
