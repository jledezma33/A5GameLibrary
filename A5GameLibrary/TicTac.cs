using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe 
{
    public class TicTac : GameLibrary.IClassLibrary
    {
        public Game game = new Game();
        static void Main(string[] args)
        {
            TicTac p = new TicTac();
            p.InitTicTac();
        }

        private void InitTicTac()
        {
            game.SetEventHandler(this);
            game.Start();
        }

        public char[,] BoardSize()
        {
            return new char[3, 3];
        }
        public char TileToken(int row, int column) 
        {
            char tokenValue = game.board[row, column];
            return tokenValue;
        }
        private bool CheckHorizontal()
        {
            if (TileToken(0, 0) == 'X' && TileToken(0, 1) == 'X' && TileToken(0, 2) == 'X')
            {
                return true;
            }
            else if (TileToken(1, 0) == 'X' && TileToken(1, 1) == 'X' && TileToken(1, 2) == 'X')
            {
                return true;
            }
            else if (TileToken(2, 0) == 'X' && TileToken(2, 1) == 'X' && TileToken(2, 2) == 'X')
            {
                return true;
            }
            else if (TileToken(0, 0) == 'O' && TileToken(0, 1) == 'O' && TileToken(0, 2) == 'O')
            {
                return true;
            }
            else if (TileToken(1, 0) == 'O' && TileToken(1, 1) == 'O' && TileToken(1, 2) == 'O')
            {
                return true;
            }
            else if (TileToken(2, 0) == 'O' && TileToken(2, 1) == 'O' && TileToken(2, 2) == 'O')
            {
                return true;
            }
            else
                return false;
        }

        private bool CheckVertical()
        {
            if (TileToken(0, 0) == 'X' && TileToken(1, 0) == 'X' && TileToken(2, 0) == 'X')
            {
                return true;
            }
            else if (TileToken(0,1) == 'X' && TileToken(1,1) == 'X' && TileToken(2,1) == 'X')
            {
                return true;
            }
            else if (TileToken(0,2) == 'X' && TileToken(1,2) == 'X' && TileToken(2,2) == 'X')
            {
                return true;
            }
            else if (TileToken(0, 0) == 'O' && TileToken(1, 0) == 'O' && TileToken(2, 0) == 'O')
            {
                return true;
            }
            else if (TileToken(0, 1) == 'O' && TileToken(1, 1) == 'O' && TileToken(2, 1) == 'O')
            {
                return true;
            }
            else if (TileToken(0, 2) == 'O' && TileToken(1, 2) == 'O' && TileToken(2, 2) == 'O')
            {
                return true;
            }
            else
                return false;
        }

        public bool CheckDiagonal()
        {
            if (TileToken(0, 0) == 'X' && TileToken(1, 1) == 'X' && TileToken(2, 2) == 'X')
            {
                return true;
            }
            else if (TileToken(0, 2) == 'X' && TileToken(1, 1) == 'X' && TileToken(2, 0) == 'X')
            {
                return true;
            }
            else if (TileToken(0, 0) == 'O' && TileToken(1, 1) == 'O' && TileToken(2, 2) == 'O')
            {
                return true;
            }
            else if (TileToken(0, 2) == 'O' && TileToken(1, 1) == 'O' && TileToken(2, 0) == 'O')
            {
                return true;
            }
            else
                return false;

        }
        public bool WinCondition()
        {
            if (CheckHorizontal().Equals(true) || CheckVertical().Equals(true) || CheckDiagonal().Equals(true))
            {
                return true;
            }
            else
                return false;
        }
    }
}
