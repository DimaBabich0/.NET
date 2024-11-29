using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    internal class TicTacToe
    {
        private char[,] board;
        public char currentPlayer;
        private const int size = 3;

        public TicTacToe()
        {
            board = new char[size, size];
            currentPlayer = new Random().Next(0,1) == 0 ? 'X' : 'O';
        }

        public void SetMove(int x, int y)
        {
            if (board[x, y] != 0)
                throw new Exception("The cell is already taken");
            board[x, y] = currentPlayer;
        }

        public void SwitchPlayers()
        {
            if (currentPlayer == 'X')
                currentPlayer = 'O';
            else
                currentPlayer = 'X';
        }

        public bool CheckBoardWinner()
        {
            for (int i = 0; i < size; i++)
            {
                if ((board[i, 0] == currentPlayer &&
                    board[i, 1] == currentPlayer &&
                    board[i, 2] == currentPlayer)
                    ||
                    (board[0, i] == currentPlayer &&
                    board[1, i] == currentPlayer &&
                    board[2, i] == currentPlayer))
                {
                    return true;
                }
            }

            if ((board[0, 0] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 2] == currentPlayer)
                ||
                (board[0, 2] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 0] == currentPlayer))
            {
                return true;
            }

            return false;
        }

        public bool isBoardFull()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == 0) return false;
                }
            }
            return true;
        }
    }
}
