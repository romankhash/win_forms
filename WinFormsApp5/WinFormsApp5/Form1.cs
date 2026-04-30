using System;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        bool isPlayerX = true;
        int turns = 0;
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void HandleButtonClick(object sender)
        {
            Button b = (Button)sender;
            if (b.Text != "") return; 

            b.Text = isPlayerX ? "X" : "O";
            turns++;

            if (CheckWinner())
            {
                MessageBox.Show($"Переміг гравець {b.Text}!");
                ResetGame();
            }
            else if (turns == 9)
            {
                MessageBox.Show("Нічия!");
                ResetGame();
            }
            else
            {
                isPlayerX = !isPlayerX;
            }
        }

        private bool CheckWinner()
        {

            return (AreSame(button1, button2, button3) || AreSame(button4, button5, button6) || AreSame(button7, button8, button9) ||
                    AreSame(button1, button4, button7) || AreSame(button2, button5, button8) || AreSame(button3, button6, button9) ||
                    AreSame(button1, button5, button9) || AreSame(button3, button5, button7));
        }
         private bool AreSame(Button b1, Button b2, Button b3)
        {
            return !string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text;
        }
        private void ResetGame()
        {
            button1.Text = button2.Text = button3.Text = button4.Text =
            button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            isPlayerX = true;
            turns = 0;
        }
        private void button1_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button2_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button3_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button4_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button5_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button6_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button7_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button8_Click(object sender, EventArgs e) => HandleButtonClick(sender);
        private void button9_Click(object sender, EventArgs e) => HandleButtonClick(sender);
    }
}
