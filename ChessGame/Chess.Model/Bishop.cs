using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// Bishop piece
    /// </summary>
    public class Bishop
    {
        /// <summary>
        /// Bishop features
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

        /// <summary>
        /// Initialize the Bishop piece
        /// </summary>

        #region Public members
        public Bishop()
        {
            chessboard = new ChessGame.Chessboard();
            board = chessboard.Board;

            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }

        /// <summary>
        /// Check if the bishop name is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string[,] board)
        {
            ismoveallowed = false;

            while (!ismoveallowed)
            {
                //North-East diagonal move
                if (xFinalCoordinate == (xInitialCoordinate - 2) && yFinalCoordinate == (yInitialCoordinate + 2) || xFinalCoordinate == (xInitialCoordinate - 4) && yFinalCoordinate == (yInitialCoordinate + 4) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " || xFinalCoordinate == (xInitialCoordinate - 6) && yFinalCoordinate == (yInitialCoordinate + 6) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate + 4)] == "   " || xFinalCoordinate == (xInitialCoordinate - 8) && yFinalCoordinate == (yInitialCoordinate + 8) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate + 6)] == "   " || xFinalCoordinate == (xInitialCoordinate - 10) && yFinalCoordinate == (yInitialCoordinate + 10) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate + 8)] == "   " || xFinalCoordinate == (xInitialCoordinate - 12) && yFinalCoordinate == (yInitialCoordinate + 12) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate + 8)] == "   " && board[(xInitialCoordinate - 10), (yInitialCoordinate + 10)] == "   " || xFinalCoordinate == (xInitialCoordinate - 14) && yFinalCoordinate == (yInitialCoordinate + 14) && board[(xInitialCoordinate - 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate + 8)] == "   " && board[(xInitialCoordinate - 10), (yInitialCoordinate + 10)] == "   " && board[(xInitialCoordinate - 12), (yInitialCoordinate + 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                //North-West diagonal move
                else if (xFinalCoordinate == (xInitialCoordinate - 2) && yFinalCoordinate == (yInitialCoordinate - 2) || xFinalCoordinate == (xInitialCoordinate - 4) && yFinalCoordinate == (yInitialCoordinate - 4) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " || xFinalCoordinate == (xInitialCoordinate - 6) && yFinalCoordinate == (yInitialCoordinate - 6) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate - 4)] == "   " || xFinalCoordinate == (xInitialCoordinate - 8) && yFinalCoordinate == (yInitialCoordinate - 8) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate - 6)] == "   " || xFinalCoordinate == (xInitialCoordinate - 10) && yFinalCoordinate == (yInitialCoordinate - 10) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate - 8)] == "   " || xFinalCoordinate == (xInitialCoordinate - 12) && yFinalCoordinate == (yInitialCoordinate - 12) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate - 8)] == "   " && board[(xInitialCoordinate - 10), (yInitialCoordinate - 10)] == "   " || xFinalCoordinate == (xInitialCoordinate - 14) && yFinalCoordinate == (yInitialCoordinate - 14) && board[(xInitialCoordinate - 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate - 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate - 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate - 8), (yInitialCoordinate - 8)] == "   " && board[(xInitialCoordinate - 10), (yInitialCoordinate - 10)] == "   " && board[(xInitialCoordinate - 12), (yInitialCoordinate - 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                //South-East diagonal move
                else if (xFinalCoordinate == (xInitialCoordinate + 2) && yFinalCoordinate == (yInitialCoordinate + 2) || xFinalCoordinate == (xInitialCoordinate + 4) && yFinalCoordinate == (yInitialCoordinate + 4) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " || xFinalCoordinate == (xInitialCoordinate + 6) && yFinalCoordinate == (yInitialCoordinate + 6) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate + 4)] == "   " || xFinalCoordinate == (xInitialCoordinate + 8) && yFinalCoordinate == (yInitialCoordinate + 8) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate + 6)] == "   " || xFinalCoordinate == (xInitialCoordinate + 10) && yFinalCoordinate == (yInitialCoordinate + 10) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate + 8)] == "   " || xFinalCoordinate == (xInitialCoordinate + 12) && yFinalCoordinate == (yInitialCoordinate + 12) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate + 8)] == "   " && board[(xInitialCoordinate + 10), (yInitialCoordinate + 10)] == "   " || xFinalCoordinate == (xInitialCoordinate + 14) && yFinalCoordinate == (yInitialCoordinate + 14) && board[(xInitialCoordinate + 2), (yInitialCoordinate + 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate + 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate + 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate + 8)] == "   " && board[(xInitialCoordinate + 10), (yInitialCoordinate + 10)] == "   " && board[(xInitialCoordinate + 12), (yInitialCoordinate + 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                //South-West diagonal move
                else if (xFinalCoordinate == (xInitialCoordinate + 2) && yFinalCoordinate == (yInitialCoordinate - 2) || xFinalCoordinate == (xInitialCoordinate + 4) && yFinalCoordinate == (yInitialCoordinate - 4) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " || xFinalCoordinate == (xInitialCoordinate + 6) && yFinalCoordinate == (yInitialCoordinate - 6) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate - 4)] == "   " || xFinalCoordinate == (xInitialCoordinate + 8) && yFinalCoordinate == (yInitialCoordinate - 8) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate - 6)] == "   " || xFinalCoordinate == (xInitialCoordinate + 10) && yFinalCoordinate == (yInitialCoordinate - 10) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate - 8)] == "   " || xFinalCoordinate == (xInitialCoordinate + 12) && yFinalCoordinate == (yInitialCoordinate - 12) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate - 8)] == "   " && board[(xInitialCoordinate + 10), (yInitialCoordinate - 10)] == "   " || xFinalCoordinate == (xInitialCoordinate + 14) && yFinalCoordinate == (yInitialCoordinate - 14) && board[(xInitialCoordinate + 2), (yInitialCoordinate - 2)] == "   " && board[(xInitialCoordinate + 4), (yInitialCoordinate - 4)] == "   " && board[(xInitialCoordinate + 6), (yInitialCoordinate - 6)] == "   " && board[(xInitialCoordinate + 8), (yInitialCoordinate - 8)] == "   " && board[(xInitialCoordinate + 10), (yInitialCoordinate - 10)] == "   " && board[(xInitialCoordinate + 12), (yInitialCoordinate - 12)] == "   ")
                {
                    ismoveallowed = true;
                }

                else
                {
                    Console.WriteLine("Irregular move");
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
