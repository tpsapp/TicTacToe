using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        int[] iBoard = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int iTurn = 1; // X = 1, O = 2
        bool bFinished = false;

        private void initBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                iBoard[i] = 0;
            }
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void changePlayer()
        {
            switch (iTurn)
            {
                case 1:
                    iTurn = 2;
                    break;
                case 2:
                    iTurn = 1;
                    break;
            }
        }

        private string getPlayer()
        {
            switch (iTurn)
            {
                case 1:
                    return "X";
                case 2:
                    return "O";
            }
            return "!";
        }

        private void placePiece(int x, int y)
        {
            if (x < 93 && y < 86)
            {
                if (iBoard[0] == 0)
                {
                    iBoard[0] = iTurn;
                    label1.Text = getPlayer();
                }
            }
            else if (x > 93 && x < 189 && y < 86)
            {
                if (iBoard[1] == 0)
                {
                    iBoard[1] = iTurn;
                    label2.Text = getPlayer();
                }
            }
            else if (x > 189 && y < 86)
            {
                if (iBoard[2] == 0)
                {
                    iBoard[2] = iTurn;
                    label3.Text = getPlayer();
                }
            }
            else if (x < 93 && y > 86 && y < 173)
            {
                if (iBoard[3] == 0)
                {
                    iBoard[3] = iTurn;
                    label4.Text = getPlayer();
                }
            }
            else if (x > 93 && x < 189 && y > 86 && y < 173)
            {
                if (iBoard[4] == 0)
                {
                    iBoard[4] = iTurn;
                    label5.Text = getPlayer();
                }
            }
            else if (x > 189 && y > 86 && y < 173)
            {
                if (iBoard[5] == 0)
                {
                    iBoard[5] = iTurn;
                    label6.Text = getPlayer();
                }
            }
            else if (x < 93 && y > 173)
            {
                if (iBoard[6] == 0)
                {
                    iBoard[6] = iTurn;
                    label7.Text = getPlayer();
                }
            }
            else if (x > 93 && x < 189 && y > 173)
            {
                if (iBoard[7] == 0)
                {
                    iBoard[7] = iTurn;
                    label8.Text = getPlayer();
                }
            }
            else if (x > 189 && y > 173)
            {
                if (iBoard[8] == 0)
                {
                    iBoard[8] = iTurn;
                    label9.Text = getPlayer();
                }
            }
        }

        private void checkVictory()
        {
            if (iBoard[0] != 0)
            {
                if (iBoard[0] == iBoard[1] && iBoard[1] == iBoard[2])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
                if (iBoard[0] == iBoard[3] && iBoard[3] == iBoard[6])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
            }
            if (iBoard[4] != 0)
            {
                if (iBoard[3] == iBoard[4] && iBoard[4] == iBoard[5])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
                if (iBoard[1] == iBoard[4] && iBoard[4] == iBoard[7])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
                if (iBoard[0] == iBoard[4] && iBoard[4] == iBoard[8])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
                if (iBoard[2] == iBoard[4] && iBoard[4] == iBoard[6])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
            }
            if (iBoard[8] != 0)
            {
                if (iBoard[6] == iBoard[7] && iBoard[7] == iBoard[8])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
                if (iBoard[2] == iBoard[5] && iBoard[5] == iBoard[8])
                {
                    bFinished = true;
                    MessageBox.Show(getPlayer() + " has won the game!", "Victory!");
                    iTurn = 1;
                    initBoard();
                    return;
                }
            }
            int iDraw = 0;
            for (int i = 0; i < 9; i++)
            {
                if (iBoard[i] != 0)
                {
                    iDraw++;
                }
            }
            if (iDraw == 9)
            {
                bFinished = true;
                MessageBox.Show("The game is a draw!", "Draw!");
                iTurn = 1;
                initBoard();
                return;
            }
            changePlayer();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                placePiece(e.X, e.Y);
                checkVictory();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            iTurn = 1;
            initBoard();
        }
    }
}
