using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// Rook piece
    /// </summary>
    public class Rook
    {
        /// <summary>
        /// Rook features
        /// </summary>

        #region Private members

        private string name;
        private bool ismoveallowed;
        private ChessGame.Chessboard chessboard;
        private string[,] board;

        private int XInitialCoordinate;
        private int YInitialCoordinate;
        private int XFinalCoordniate;
        private int YFinalCoordinate;
        #endregion

        #region Public members
        /// <summary>
        /// Initialize the Roook piece
        /// </summary>
        public Rook()
        {
            chessboard = new ChessGame.Chessboard();
            board = chessboard.Board;

            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }


        /// <summary>
        /// Check if the Rook move is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string[,] board)
        {
            ismoveallowed = false;

            while (!ismoveallowed)
            {
                //Top Vertical movement
                if (xFinalCoordinate == (xInitialCoordinate - 2) && yFinalCoordinate == yInitialCoordinate || xFinalCoordinate == (xInitialCoordinate - 4) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate - 6) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 4), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate - 8) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 6), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate - 10) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 8), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate - 12) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 8), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 10), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate - 14) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate - 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 8), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 10), yFinalCoordinate] == "   " && board[(xInitialCoordinate - 12), yFinalCoordinate] == "   ")
                {
                    ismoveallowed = true;
                }

                //Bottom Vertical movement
                else if (xFinalCoordinate == (xInitialCoordinate + 2) && yFinalCoordinate == yInitialCoordinate || xFinalCoordinate == (xInitialCoordinate + 4) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate + 6) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 4), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate + 8) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 6), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate + 10) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 8), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate + 12) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 8), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 10), yFinalCoordinate] == "   " || xFinalCoordinate == (xInitialCoordinate + 14) && yFinalCoordinate == yInitialCoordinate && board[(xInitialCoordinate + 2), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 4), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 6), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 8), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 10), yFinalCoordinate] == "   " && board[(xInitialCoordinate + 12), yFinalCoordinate] == "   ")
                {
                    ismoveallowed = true;
                }

                //Right Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 2) || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 4) && board[xInitialCoordinate, (yInitialCoordinate + 2)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 6) && board[xInitialCoordinate, (yInitialCoordinate + 2)] == "   " && board[xInitialCoordinate, (yInitialCoordinate + 4)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 8) && board[xInitialCoordinate, (yInitialCoordinate + 2)] == "   " && board[xInitialCoordinate, (yInitialCoordinate + 4)] == "   " && board[xInitialCoordinate, (yInitialCoordinate + 6)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (YInitialCoordinate + 10) && board[xInitialCoordinate, (yInitialCoordinate + 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 8)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 12) && board[xFinalCoordinate, (yInitialCoordinate + 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 8)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 10)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 14) && board[xFinalCoordinate, (yInitialCoordinate + 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 8)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 10)] == "   " && board[xFinalCoordinate, (yInitialCoordinate + 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                //Left Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 2) || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 4) && board[xInitialCoordinate, (yInitialCoordinate - 2)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 6) && board[xInitialCoordinate, (yInitialCoordinate - 2)] == "   " && board[xInitialCoordinate, (yInitialCoordinate - 4)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 8) && board[xInitialCoordinate, (yInitialCoordinate - 2)] == "   " && board[xInitialCoordinate, (yInitialCoordinate - 4)] == "   " && board[xInitialCoordinate, (yInitialCoordinate - 6)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (YInitialCoordinate - 10) && board[xInitialCoordinate, (yInitialCoordinate - 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 8)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 12) && board[xFinalCoordinate, (yInitialCoordinate - 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 8)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 10)] == "   " || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 14) && board[xFinalCoordinate, (yInitialCoordinate - 2)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 4)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 6)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 8)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 10)] == "   " && board[xFinalCoordinate, (yInitialCoordinate - 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                else
                {
                    Console.WriteLine("Irregular move!");
                    ismoveallowed = false;
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int xInitialCoordinate
        {
            get
            {
                return XInitialCoordinate;
            }

            set
            {
                XInitialCoordinate = value;
            }
        }

        public int yInitialCoordinate
        {
            get
            {
                return YInitialCoordinate;
            }

            set
            {
                YInitialCoordinate = value;
            }
        }

        public int xFinalCoordinate
        {
            get
            {
                return XFinalCoordniate;
            }

            set
            {
                XFinalCoordniate = value;
            }
        }

        public int yFinalCoordinate
        {
            get
            {
                return YFinalCoordinate;
            }

            set
            {
                YFinalCoordinate = value;
            }
        }

        #endregion

    }
}
