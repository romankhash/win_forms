using System.IO;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private string _filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _filePath = ofd.FileName;
                    textBox1.Text = File.ReadAllText(_filePath); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                File.WriteAllText(_filePath, textBox1.Text);
                MessageBox.Show("файл оновлено!");
            }
            else
            {                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Текстові файли (*.txt)|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        _filePath = sfd.FileName;
                        File.WriteAllText(_filePath, textBox1.Text);
                        MessageBox.Show("файл збережено!");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
