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
    public class King : Piece
    {
        /// <summary>
        /// Initialize the King piece
        /// </summary>

        #region Public members

        public King() { }

        public King(string Name, int xActualCoordinate, int yActualCoordinate) : base(Name, xActualCoordinate, yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }
        
        /// <summary>
        /// Check is the king move is regular
        /// </summary>

        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, object[,] Board)
        {
            isMoveAllowed = false;

            while (!isMoveAllowed)
            {
                if (xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate + 2) || xFinalCoordinate == xInitialCoordinate && yFinalCoordinate == (yInitialCoordinate - 2))
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }
                else if (xFinalCoordinate == (xInitialCoordinate + 2) && yFinalCoordinate == yInitialCoordinate || xFinalCoordinate == (xInitialCoordinate - 2) && yFinalCoordinate == yInitialCoordinate)
                {
                    xActualCoordinate = xFinalCoordinate;
                    yActualCoordinate = yFinalCoordinate;
                    isMoveAllowed = true;
                }
                else
                {
                    Console.WriteLine("Irregular move!");
                    xActualCoordinate = xInitialCoordinate;
                    yActualCoordinate = yInitialCoordinate;
                    isMoveAllowed = false;
                }
            }
        }

        #endregion
    }
}
