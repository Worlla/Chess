using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    /// <summary>
    /// Pawn piece
    /// </summary>
    public class Pawn : Piece
    {
        #region Public members

        /// <summary>
        /// Initialize the pawn piece
        /// </summary>
       
        public Pawn() { }

        public Pawn(string Name, int xActualCoordinate, int yActualCoordinate) : base(Name, xActualCoordinate, yActualCoordinate)
        {
            this.Name = Name;
            this.xActualCoordinate = xActualCoordinate;
            this.yActualCoordinate = yActualCoordinate;
        }
        
        /// <summary>
        /// Check if the pawn move is regular
        /// </summary>

        private void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, int StartingPosition, object[,] Board, string[,] strBoard, int xActualCoordinate, int yActualCoordinate)
        {
            isMoveAllowed = false;

            while (!isMoveAllowed)
            {
                //White Pawn move
                if (StartingPosition == 13)
                {
                    if (xInitialCoordinate != Board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate == 0)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 2 && Board[xFinalCoordinate + 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   ")
                        {
                            xActualCoordinate = xFinalCoordinate;
                            yActualCoordinate = yFinalCoordinate;
                            isMoveAllowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, the destination cell must be empty!");
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;                        }
                    }
                    else if (xInitialCoordinate == Board.GetLength(0) - 4)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 0 && Board[xFinalCoordinate + 2, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   " || xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 0 && Board[xFinalCoordinate + 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   ")
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
                            break;                        }
                    }
                    else if (xInitialCoordinate != Board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate != 0)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 2 && Board[xFinalCoordinate + 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() != "   ")
                        {
                            xActualCoordinate = xFinalCoordinate;
                            yActualCoordinate = yFinalCoordinate;
                            isMoveAllowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, there's no opponent's piece to assault");
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;                        }
                    }
                }

                //Black Pawn Move
                else if (StartingPosition == 3)
                {
                    if (xInitialCoordinate != 3 && yFinalCoordinate - yInitialCoordinate == 0)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 2 && Board[xFinalCoordinate - 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   ")
                        {
                            xActualCoordinate = xFinalCoordinate;
                            yActualCoordinate = yFinalCoordinate;
                            isMoveAllowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, the destination cell must be empty!");
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;                        }
                    }
                    else if (xInitialCoordinate == 3)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 0 && Board[xFinalCoordinate - 2, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   " || xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 0 && Board[xFinalCoordinate - 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() == "   ")
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
                            break;
                        }
                    }
                    else if (xInitialCoordinate != Board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate != 0)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 2 && Board[xFinalCoordinate - 1, yFinalCoordinate].ToString() == "   " && Board[xFinalCoordinate, yFinalCoordinate].ToString() != "   ")
                        {
                            xActualCoordinate = xFinalCoordinate;
                            yActualCoordinate = yFinalCoordinate;
                            isMoveAllowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, there's no opponent's piece to assault");
                            xActualCoordinate = xInitialCoordinate;
                            yActualCoordinate = yInitialCoordinate;
                            break;
                        }
                    }
                }

                //Irregular initial coordinate
                else
                {
                    Console.WriteLine("Irregular starting position coordinate");
                    break;
                }
            }
        }

        public override void Move(int finalX, int finalY)
        {
            if (isMoveAllowed == true)
            {
                xActualCoordinate = finalX;
                yActualCoordinate = finalY;
            }
            else
            {
                xActualCoordinate = xActualCoordinate;
                yActualCoordinate = yActualCoordinate;
            }
        }

        #endregion
    }
}
