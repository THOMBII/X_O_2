using static System.Windows.Forms.AxHost;
using System.Numerics;
using static X_O.GameBoard;

namespace X_O
{
    public partial class Form1 : Form
    {

        GameBoard gb;
        public static Player sp;
        public static Player sp_revers;
        public readonly int flag = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gb = new TicTacToeBoard();
            LoadBoard();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        /// <summary>
        /// Dirty, but it reloads the board display to account for all moves played so far.
        /// </summary>
        private void LoadBoard()
        {
            if (gb[0, 0] == Player.Open)
                button1.Text = "";
            else
            {
                button1.Text = gb[0, 0].ToString();
                button1.Enabled = false;
            }

            if (gb[0, 1] == Player.Open)
                button2.Text = "";
            else
            {
                button2.Text = gb[0, 1].ToString();
                button2.Enabled = false;
            }

            if (gb[0, 2] == Player.Open)
                button3.Text = "";
            else
            {
                button3.Text = gb[0, 2].ToString();
                button3.Enabled = false;
            }

            if (gb[1, 0] == Player.Open)
                button4.Text = "";
            else
            {
                button4.Text = gb[1, 0].ToString();
                button4.Enabled = false;
            }

            if (gb[1, 1] == Player.Open)
                button5.Text = "";
            else
            {
                button5.Text = gb[1, 1].ToString();
                button5.Enabled = false;
            }

            if (gb[1, 2] == Player.Open)
                button6.Text = "";
            else
            {
                button6.Text = gb[1, 2].ToString();
                button6.Enabled = false;
            }

            if (gb[2, 0] == Player.Open)
                button7.Text = "";
            else
            {
                button7.Text = gb[2, 0].ToString();
                button7.Enabled = false;
            }

            if (gb[2, 1] == Player.Open)
                button8.Text = "";
            else
            {
                button8.Text = gb[2, 1].ToString();
                button8.Enabled = false;
            }

            if (gb[2, 2] == Player.Open)
                button9.Text = "";
            else
            {
                button9.Text = gb[2, 2].ToString();
                button9.Enabled = false;
            }
        }

        /// <summary>
        /// Button click event
        /// </summary>
        private void button_click(object sender, EventArgs e)
        {
            Space s = (Space)sender;

            gb[s.X, s.Y] = sp;
            LoadBoard();
            if (CheckForWinners())
                Form1_Load(null, new EventArgs());  //Winner was found, reload the game

            if (gb.OpenSquares.Count == gb.Size) //if all spaces are open, randomly pick one for excitement
            {
                Random r = new Random();
                s = new Space(r.Next(0, 3), r.Next(0, 3));
            }
            else
                s = Ai.GetBestMove(gb, Player.X, sp, sp_revers);

            gb[s.X, s.Y] = sp_revers;
            LoadBoard();
            if (CheckForWinners())
                Form1_Load(null, new EventArgs());  //Winner was found, reload the game

        }

        /// <summary>
        /// Checks the current board for a winner and acts appropriately
        /// </summary>
        /// <returns></returns>
        public bool CheckForWinners()
        {
            Player? p = gb.Winner;

            if (p == Player.X)
            {
                MessageBox.Show("Player X win!");
                return true;
            }
            else if (p == Player.O)
            {
                MessageBox.Show("Player O win!");
                return true;
            }
            else if (gb.IsFull)
            {
                MessageBox.Show("Cat's Game");
                return true;
            }
            return false;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }*/

        private void button10_Click(object sender, EventArgs e)
        {
            sp = Player.X;
            sp_revers = Player.O;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sp = Player.O;
            sp_revers = Player.X;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        /*private void button2_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = sp;
        }*/
    }
}