using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// Knight piece
    /// </summary>
    public class Knight
    {
        /// <summary>
        /// Knight features
        /// </summary>

        #region Private members

        private string name;
        private bool ismoveallowed;
        private ChessGame.Chessboard chessboard;
        
        private int XInitialCoordinate;
        private int YInitialCoordinate;
        private int XFinalCoordniate;
        private int YFinalCoordinate;

        #endregion

        /// <summary>
        /// Initialize the Knight piece
        /// </summary>
        /// 

        #region Public members

        public Knight()
        {
            chessboard = new ChessGame.Chessboard();
            
            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }

        //Check if the knight move represents an L
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string[,] Board)
        {
            ismoveallowed = false;

            while (!ismoveallowed)
            {
                if (xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 4 || xFinalCoordinate - xInitialCoordinate == 2 && yInitialCoordinate - yFinalCoordinate == 4)
                    ismoveallowed = true;

                else if (xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 4 || xInitialCoordinate - xFinalCoordinate == 2 && yInitialCoordinate - yFinalCoordinate == 4)
                    ismoveallowed = true;

                else if (xFinalCoordinate - xInitialCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 2 || xFinalCoordinate - xInitialCoordinate == 4 && yInitialCoordinate - yFinalCoordinate == 2)
                    ismoveallowed = true;

                else if (xInitialCoordinate - xFinalCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 2 || xInitialCoordinate - xFinalCoordinate == 4 && yInitialCoordinate - yFinalCoordinate == 2)
                    ismoveallowed = true;

                else
                {
                    Console.WriteLine("Irregular move, the Knight movement must represent an L!");
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
