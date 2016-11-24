using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// Queen piece
    /// </summary>
    public class Queen
    {
        /// <summary>
        /// Queen features
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
        /// Initialize the Queen piece
        /// </summary>

        #region Public members

        public Queen()
        {
            chessboard = new ChessGame.Chessboard();
            
            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }

        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, string[,] Board)
        {
            ismoveallowed = false;
            int tempX = xInitialCoordinate;
            int tempY = yInitialCoordinate;

            while (!ismoveallowed)
            {
                //North-East diagonal move
                if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempX--;
                    tempY++;

                    if (tempX > xFinalCoordinate && tempY < yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //North-West diagonal move
                else if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempX--;
                    tempY--;

                    if (tempX > xFinalCoordinate && tempY > yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //South-East diagonal move
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempX++;
                    tempY++;

                    if (tempX < xFinalCoordinate && tempY < yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //South-West diagonal move
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempX++;
                    tempY--;

                    if (tempX < xFinalCoordinate && tempY > yFinalCoordinate)
                    {
                        if (Board[tempX, tempY] != "   " && Board[tempX, tempY] != " | " && Board[tempX, tempY] != " - ")
                            ismoveallowed = false;
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        ismoveallowed = true;
                    }
                }

                //Top Vertical movement
                else if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate == yInitialCoordinate)
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
