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
    public class Pawn
    {
        /// <summary>
        /// Pawn features
        /// </summary>
        #region Private members

        private string name;
        private bool ismoveallowed;
        private ChessGame.Chessboard chessboard;
        private string[,] board;

        private int startingPosition;
        private int XInitialCoordinate;
        private int YInitialCoordinate;
        private int XFinalCoordniate;
        private int YFinalCoordinate;

        #endregion

        #region Public members

        /// <summary>
        /// Initialize the pawn piece
        /// </summary>
        public Pawn()
        {
            chessboard = new ChessGame.Chessboard();
            board = chessboard.Board;

            startingPosition = new int();
            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
        }

        /// <summary>
        /// Check if the pawn move is regular
        /// </summary>
        public void ismoveAllowed(int xInitialCoordinate, int yInitialCoordinate, int xFinalCoordinate, int yFinalCoordinate, int StartingPosition, string[,] board)
        {
            ismoveallowed = false;

            while (!ismoveallowed)
            {
                //White Pawn move
                if (StartingPosition == 13)
                {
                    if (xInitialCoordinate != board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate == 0)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 2 && board[xFinalCoordinate + 1, yFinalCoordinate] == "   " && board[XFinalCoordniate, YFinalCoordinate] == "   ")
                        {
                            ismoveallowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, the destination cell must be empty!");
                            ismoveallowed = false;
                        }
                    }
                    else if (xInitialCoordinate == board.GetLength(0) - 4)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 0 && board[xFinalCoordinate + 2, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] == "   " || xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 0 && board[xFinalCoordinate + 1, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] == "   ")
                            ismoveallowed = true;
                        else
                        {
                            Console.WriteLine("Irregular move!");
                            ismoveallowed = false;
                        }
                    }
                    else if (xInitialCoordinate != board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate != 0)
                    {
                        if (xInitialCoordinate - xFinalCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 2 && board[xFinalCoordinate + 1, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] != "   ")
                            ismoveallowed = true;
                        else
                        {
                            Console.WriteLine("Irregular move, there's no opponent's piece to assault");
                            ismoveallowed = false;
                        }
                    }
                }

                //Black Pawn Move
                else if (StartingPosition == 3)
                {
                    if (xInitialCoordinate != 3 && yFinalCoordinate - yInitialCoordinate == 0)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 2 && board[xFinalCoordinate - 1, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] == "   ")
                        {
                            ismoveallowed = true;
                        }
                        else
                        {
                            Console.WriteLine("Irregular move, the destination cell must be empty!");
                            ismoveallowed = false;
                        }
                    }
                    else if (xInitialCoordinate == 3)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 4 && yFinalCoordinate - yInitialCoordinate == 0 && board[xFinalCoordinate - 2, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] == "   " || xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 0 && board[xFinalCoordinate - 1, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] == "   ")
                            ismoveallowed = true;
                        else
                        {
                            Console.WriteLine("Irregular move!");
                            ismoveallowed = false;
                        }
                    }
                    else if (xInitialCoordinate != board.GetLength(0) - 4 && yFinalCoordinate - yInitialCoordinate != 0)
                    {
                        if (xFinalCoordinate - xInitialCoordinate == 2 && yFinalCoordinate - yInitialCoordinate == 2 && board[xFinalCoordinate - 1, yFinalCoordinate] == "   " && board[xFinalCoordinate, yFinalCoordinate] != "   ")
                            ismoveallowed = true;
                        else
                        {
                            Console.WriteLine("Irregular move, there's no opponent's piece to assault");
                            ismoveallowed = false;
                        }
                    }
                }

                //Irregular initial coordinate
                else
                {
                    Console.WriteLine("Irregular starting position coordinate");
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

        public int StartingPosition
        {
            get
            {
                return startingPosition;
            }

            set
            {
                startingPosition = value;
            }
        }

        #endregion
    }
}
