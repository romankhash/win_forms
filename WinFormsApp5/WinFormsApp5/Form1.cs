namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        bool turn = true; 
        int steps = 0;

        public Form1()
        {
            InitializeComponent();
            SetupButtons();
        }

        private void SetupButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Text = ""; 
                    c.Click += UniversalButtonClick; 
                }
            }
        }

        private void UniversalButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (!string.IsNullOrEmpty(b.Text)) return;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn; 
            steps++;

            CheckWinner();
        }

        private void CheckWinner()
        {

            if (IsLine(button1, button2, button3) || IsLine(button4, button5, button6) || IsLine(button7, button8, button9) ||
                IsLine(button1, button4, button7) || IsLine(button2, button5, button8) || IsLine(button3, button6, button9) ||
                IsLine(button1, button5, button9) || IsLine(button3, button5, button7))
            {
                string winner = turn ? "O" : "X";
                MessageBox.Show($"виграв: {winner}!", "гра завершена.");
                ResetGame();
            }
            else if (steps == 9)
            {
                MessageBox.Show("нічия!", "гра завершена.");
                ResetGame();
            }
        }

        private bool IsLine(Button b1, Button b2, Button b3)
        {
            return b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text;
        }

        private void ResetGame()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button) c.Text = "";
            }
            turn = true;
            steps = 0;
        }
    }
}
