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
    public class Rook : Piece
    {
        #region Public members

        /// <summary>
        /// Initialize the Roook piece
        /// </summary>

        public Rook() { }

        public Rook(string Name, int xActualCoordinate, int yActualCoordinate) : base(Name, xActualCoordinate, yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }
        
        /// <summary>
        /// Check if the Rook move is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, object[,] Board)
        {
            isMoveAllowed = false;
            int tempX = xInitialCoordinate;
            int tempY = yInitialCoordinate;

            while (!isMoveAllowed)
            {
                //Top Vertical movement
                if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate == yInitialCoordinate)
                {
                    tempX--;

                    if (tempX > xFinalCoordinate)
                    {
                        if (Board[tempX, tempY].ToString() != "   " && Board[tempX, tempY].ToString() != " | " && Board[tempX, tempY].ToString() != " - ")
                        {
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;
                        }
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        xActualCoordinate = xFinalCoordinate;
                        yActualCoordinate = yFinalCoordinate;
                        isMoveAllowed = true;
                    }
                }

                //Bottom Vertical movement
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate == yInitialCoordinate)
                {
                    tempX++;

                    if (tempX < xFinalCoordinate)
                    {
                        if (Board[tempX, tempY].ToString() != "   " && Board[tempX, tempY].ToString() != " | " && Board[tempX, tempY].ToString() != " - ")
                        {
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;
                        }
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        xActualCoordinate = xFinalCoordinate;
                        yActualCoordinate = yFinalCoordinate;
                        isMoveAllowed = true;
                    }
                }

                //Right Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempY++;

                    if (tempY < yFinalCoordinate)
                    {
                        if (Board[tempX, tempY].ToString() != "   " && Board[tempX, tempY].ToString() != " | " && Board[tempX, tempY].ToString() != " - ")
                        {
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;
                        }
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        xActualCoordinate = xFinalCoordinate;
                        yActualCoordinate = yFinalCoordinate;
                        isMoveAllowed = true;
                    }
                }

                //Left Horizontal movement 
                else if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempY--;

                    if (tempY > yFinalCoordinate)
                    {
                        if (Board[tempX, tempY].ToString() != "   " && Board[tempX, tempY].ToString() != " | " && Board[tempX, tempY].ToString() != " - ")
                        {
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;
                        }
                    }

                    else if (tempX == xFinalCoordinate && tempY == yFinalCoordinate)
                    {
                        xActualCoordinate = xFinalCoordinate;
                        yActualCoordinate = yFinalCoordinate;
                        isMoveAllowed = true;
                    }
                }

                else
                {
                    Console.WriteLine("Irregular move!");
                    {
                        xActualCoordinate = xInitialCoordinate;
                        yActualCoordinate = yInitialCoordinate;
                        break;
                    }
                }
            }
        }

        #endregion

    }
}
