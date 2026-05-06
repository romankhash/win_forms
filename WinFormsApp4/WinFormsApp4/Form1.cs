namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += button1_MouseEnter;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            int nextX = random.Next(0, maxX);
            int nextY = random.Next(0, maxY);

            button1.Location = new Point(nextX, nextY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("як...");
        }
    }
}