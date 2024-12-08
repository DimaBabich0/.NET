using HW05.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    public class Model
    {
        public char[,] board;
        public char CurrentPlayer;
        private const int SIZE = 3;

        public Model()
        {
            board = new char[SIZE, SIZE];
            CurrentPlayer = new Random().Next(0, 1) == 0 ? 'X' : 'O';
        }

        public void SetMove(int x, int y)
        {
            if (board[x, y] != 0)
                throw new Exception("The cell is already taken");
            board[x, y] = CurrentPlayer;
        }

        public void SwitchPlayers()
        {
            CurrentPlayer = CurrentPlayer == 'X' ? 'O' : 'X';
        }

        public bool CheckBoardWinner()
        {
            for (int i = 0; i < SIZE; i++)
            {
                if ((board[i, 0] == CurrentPlayer &&
                     board[i, 1] == CurrentPlayer &&
                     board[i, 2] == CurrentPlayer) ||
                    (board[0, i] == CurrentPlayer &&
                     board[1, i] == CurrentPlayer &&
                     board[2, i] == CurrentPlayer))
                {
                    return true;
                }
            }

            if ((board[0, 0] == CurrentPlayer &&
                 board[1, 1] == CurrentPlayer &&
                 board[2, 2] == CurrentPlayer) ||
                (board[0, 2] == CurrentPlayer &&
                 board[1, 1] == CurrentPlayer &&
                 board[2, 0] == CurrentPlayer))
            {
                return true;
            }

            return false;
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (board[i, j] == 0) return false;
                }
            }
            return true;
        }

        public void ClearBoard()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    board[i, j] = '\0';
                }
            }
        }
    }
}
