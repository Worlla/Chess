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
            
            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }


        /// <summary>
        /// Check if the Rook move is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string[,] Board)
        {
            ismoveallowed = false;
            int tempX = xInitialCoordinate;
            int tempY = yInitialCoordinate;

            while (!ismoveallowed)
            {
                //Top Vertical movement
                if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate == yInitialCoordinate)
                {
                    tempX--;

                    if (tempX > xFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //Bottom Vertical movement
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate == yInitialCoordinate)
                {
                    tempX++;

                    if (tempX < xFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //Right Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempY++;

                    if (tempY < yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //Left Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempY--;

                    if (tempY > yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
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
