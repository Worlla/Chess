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
    public class Bishop : Piece
    {
        #region Public Members

        /// <summary>
        /// Initialize the Bishop piece
        /// </summary>

        public Bishop() { }

        public Bishop(string Name, int xActualCoordinate, int yActualCoordinate) : base(Name, xActualCoordinate, yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }

        /// <summary>
        /// Check if the bishop name is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, object[,] Board)
        {
            isMoveAllowed = false;
            int tempX = xInitialCoordinate;
            int tempY = yInitialCoordinate;

            while (!isMoveAllowed)
            {
                //North-East diagonal move
                if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempX--;
                    tempY++;

                    if (tempX > xFinalCoordinate && tempY < yFinalCoordinate)
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

                //North-West diagonal move
                else if (xFinalCoordinate < xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempX--;
                    tempY--;

                    if (tempX > xFinalCoordinate && tempY > yFinalCoordinate)
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

                //South-East diagonal move
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate > yInitialCoordinate)
                {
                    tempX++;
                    tempY++;

                    if (tempX < xFinalCoordinate && tempY < yFinalCoordinate)
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

                //South-West diagonal move
                else if (xFinalCoordinate > xInitialCoordinate && yFinalCoordinate < yInitialCoordinate)
                {
                    tempX++;
                    tempY--;

                    if (tempX < xFinalCoordinate && tempY > yFinalCoordinate)
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
                    Console.WriteLine("Irregular move");
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
