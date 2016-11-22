using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// King piece
    /// </summary>
    public class King
    {
        /// <summary>
        /// King features
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
        /// Initialize the King piece
        /// </summary>

        #region Public members

        public King()
        {
            chessboard = new ChessGame.Chessboard();
            board = chessboard.Board;

            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }

        /// <summary>
        /// Check is the king move is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string [,] board)
        {
            ismoveallowed = false;

            while (!ismoveallowed)
            {
                if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 2) || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 2))
                {
                    ismoveallowed = true;
                }
                else if (xFinalCoordinate == (xInitialCoordinate + 2) && yFinalCoordinate == yInitialCoordinate || xFinalCoordinate == (xInitialCoordinate - 2) && yFinalCoordinate == yInitialCoordinate)
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
