using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Classes
{
    class MyConsole
    {
        static public void WaitPress()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }

    class TicTacToe
    {
        private char[,] board = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        private char currentPlayer;
        private bool isAgainstComputer;

        public void SetupGame()
        {
            WriteLine("Welcome to \"Tic-Tac-Toe\"");
            WriteLine("Select game mode:");
            WriteLine("1. Player VS Computer");
            WriteLine("2. Player VS Player");
            string choice = ReadLine();
            isAgainstComputer = (choice == "1");

            currentPlayer = new Random().Next(0, 2) == 0 ? 'X' : 'O';
            WriteLine($"The first goes: {currentPlayer}");
            StartGame();
        }

        private void StartGame()
        {
            while (true)
            {
                DrawBoard();
                PlayerMove();
                if (CheckWin())
                {
                    DrawBoard();
                    WriteLine($"Player '{currentPlayer}' win!");
                    break;
                }
                if (CheckDraw())
                {
                    DrawBoard();
                    WriteLine("Draw!");
                    break;
                }
                SwitchPlayer();
            }
            
            MyConsole.WaitPress();
            Clear();
            if (IsRestartGame())
            {
                ClearBoard();
                StartGame();
            }
            else
            {
                return;
            }
        }

        private void ClearBoard()
        {
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    board[i, j] = (char)(48 + num++); 
            }
        }

        private bool IsRestartGame()
        {
            WriteLine("Do you want to restart the game? (y\\n):");
            while (true)
            {
                string choice = ReadLine();
                if (choice.ToLower() == "y") return true; 
                else if (choice.ToLower() == "n") return false; 
                else WriteLine("You entered the wrong key. Try again");
            }
        }

        private void DrawBoard()
        {
            Clear();
            for (int i = 0; i < 3; i++)
            {
                WriteLine($" {board[i, 0]} | {board[i, 1]} | {board[i, 2]} ");
                if (i < 2) WriteLine("---+---+---");
            }
        }

        private void PlayerMove()
        {
            int move;
            if (isAgainstComputer && currentPlayer == 'O')
            {
                move = ComputerMove();
                WriteLine($"Computer choose: {move}");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                while (true)
                {
                    Write($"Player \"{currentPlayer}\", enter cell number: ");
                    if (int.TryParse(ReadLine(), out move))
                    {
                        if (IsValidMove(move)) break;
                        else WriteLine("This cell isn't empty. Choose another");
                    }
                    else WriteLine("Incorrect input! Try again");
                }
            }
            PlaceMove(move);
        }

        private int ComputerMove()
        {
            Random rand = new Random();
            int move;
            do
            {
                move = rand.Next(1, 10);
            } while (!IsValidMove(move));
            return move;
        }

        private bool IsValidMove(int move)
        {
            if (move < 0 || move > board.Length) return false;
            int row = (move - 1) / 3;
            int col = (move - 1) % 3;
            return (board[row, col] != 'X' && board[row, col] != 'O');
        }

        private void PlaceMove(int move)
        {
            int row = (move - 1) / 3;
            int col = (move - 1) % 3;
            board[row, col] = currentPlayer;
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }

        private bool CheckWin()
        {
            return (CheckRows() || CheckCols() || CheckDiagonals());
        }

        private bool CheckRows()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
            }
            return false;
        }

        private bool CheckCols()
        {
            for (int i = 0; i < 3; i++)
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            return false;
        }

        private bool CheckDiagonals()
        {
            return (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                   (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
        }

        private bool CheckDraw()
        {
            foreach (char cell in board)
                if (cell != 'X' && cell != 'O')
                    return false;
            return true;
        }
    }
}

namespace HW10
{
    internal class Program
    {
        static void Main()
        {
            TicTacToe Game = new TicTacToe();
            Game.SetupGame();
        }
    }
}