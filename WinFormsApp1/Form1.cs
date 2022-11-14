namespace WinFormsApp1
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }

    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            label2.Text = "Kszyszyk";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
                label2.Text = "Ku³ko";
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
                label2.Text = "Kszyszyk";
            }
        }
    }
}