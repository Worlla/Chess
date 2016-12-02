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
    public class Knight : Piece
    {
        /// <summary>
        /// Initialize the Knight piece
        /// </summary>

        public Knight() { }

        public Knight(string Name, int xActualCoordinate, int yActualCoordinate) : base(Name, xActualCoordinate, yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }
        
        #region Public members

        //Check if the knight move represents an L
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, object[,] Board)
        {
            isMoveAllowed = false;

            while (!isMoveAllowed)
            {
                if (xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 4 || xFinalCoordinate - xInitialCoordinate == 2 && yInitialCoordinate - yFinalCoordinate == 4)
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }

                else if (xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 4 || xInitialCoordinate - xFinalCoordinate == 2 && yInitialCoordinate - yFinalCoordinate == 4)
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }

                else if (xFinalCoordinate - xInitialCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 2 || xFinalCoordinate - xInitialCoordinate == 4 && yInitialCoordinate - yFinalCoordinate == 2)
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }

                else if (xInitialCoordinate - xFinalCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 2 || xInitialCoordinate - xFinalCoordinate == 4 && yInitialCoordinate - yFinalCoordinate == 2)
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }

                else
                {
                    Console.WriteLine("Irregular move, the Knight movement must represent an L!");
                    xActualCoordinate = xInitialCoordinate;
                    yActualCoordinate = yInitialCoordinate;
                    break;                }
            }
        }

        #endregion
    }
}
