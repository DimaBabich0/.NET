using HW03.Properties;
using System;
using System.Drawing.Design;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HW03
{
    public partial class Form1 : Form
    {
        TicTacToe game;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();

            buttons = Controls.OfType<Button>()
                .Where(button => button.Name.StartsWith("button", StringComparison.OrdinalIgnoreCase))
                .OrderBy(button =>
                {
                    var match = Regex.Match(button.Name, @"\d+");
                    return match.Success ? int.Parse(match.Value) : 0;
                })
                .ToList();
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void ClearImages()
        {
            foreach (Button button in buttons)
            {
                button.BackgroundImage = null;
            }
        }

        private void ComputerMove()
        {
            Random rnd = new Random();
            bool isPlaced;
            int x = rnd.Next(0, 3);
            int y = rnd.Next(0, 3);

            do
            {
                try
                {
                    isPlaced = true;
                    game.SetMove(x, y);
                }
                catch (Exception ex)
                {
                    isPlaced = false;
                    x = rnd.Next(0, 3);
                    y = rnd.Next(0, 3);
                }
            } while (!isPlaced);

            buttons[x * 3 + y].BackgroundImage = (game.currentPlayer == 'X' ? Resources.cross : Resources.circle);

            ShowInfo("Computer made a move");
            if (CheckWinDraw()) return;
            game.SwitchPlayers();
        }

        private bool CheckWinDraw()
        {

            if (game.CheckBoardWinner())
            {
                ShowInfo($"Player {game.currentPlayer} win!");
                game = null;
                startGameButton.Enabled = true;
                return true;
            }

            if (game.isBoardFull())
            {
                ShowInfo($"Draw!");
                game = null;
                startGameButton.Enabled = true;
                return true;
            }
            return false;
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            if (game == null)
            {
                ShowError("You need to click to \"Start new game\"");
                return;
            }

            Button button = sender as Button;
            int num = int.Parse(Regex.Match(button.Name, @"\d+").Value) - 1;
            int x = num / 3;
            int y = num % 3;

            try
            {
                game.SetMove(x, y);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return;
            }

            button.BackgroundImage = (game.currentPlayer == 'X' ? Resources.cross : Resources.circle);

            if (CheckWinDraw()) return;
            game.SwitchPlayers();
            ComputerMove();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                ClearImages();
                game = new TicTacToe();
                startGameButton.Enabled = false;
                if (isBotMoveFirst.Checked)
                {
                    ComputerMove();
                }
            }
        }
    }
}
