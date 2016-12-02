using ChessGame.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    /// <summary>
    /// Chessboard feautures
    /// </summary>
    public class Chessboard
    {
        #region Private members

        /// <summary>
        /// Private members: chessboard matrix, X and Y dimension of it.
        /// </summary>
        private object[,] board;

        private string[,] strBoard;

        private int boardX;

        private int boardY;

        private int numberCoordinate;

        private Dictionary<int, string> letters;

        private string verticalCellBorder;

        private string horizontalCellBorder;
        
        #endregion

        #region Public members

        /// <summary>
        /// Print the design  of the chessboard
        /// </summary>
        public Chessboard()
        {
            try
            {
                boardX = ConfigurationHelper.GetBoardXValue();
                boardY = ConfigurationHelper.GetBoardYValue();
                board = new object[boardX, boardY];
                strBoard = new string[boardX, boardY];
                numberCoordinate = 8;

                letters = new Dictionary<int, string>();
                letters.Add(1, "a");
                letters.Add(3, "b");
                letters.Add(5, "c");
                letters.Add(7, "d");
                letters.Add(9, "e");
                letters.Add(11, "f");
                letters.Add(13, "g");
                letters.Add(15, "h");

                verticalCellBorder = " | ";

                horizontalCellBorder = " - ";

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        //Write numbers on the left and right side of the chessboard
                        if (j == 0 && i % 2 != 0)
                        {
                            board[i, j] = " " + numberCoordinate.ToString() + "|";
                            board[i, board.GetLength(1) - 1] = "|" + numberCoordinate.ToString() + " ";

                            strBoard[i, j] = " " + numberCoordinate.ToString() + "|";
                            strBoard[i, board.GetLength(1) - 1] = "|" + numberCoordinate.ToString() + " ";

                            numberCoordinate--;
                        }
                        //Write letters on the top and bottom of the chessboard
                        if (i == 0 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            board[i, j] = " " + (letters[j]) + " ";
                            board[(board.GetLength(0) - 1), j] = " " + (letters[j]) + " ";

                            strBoard[i, j] = " " + (letters[j]) + " ";
                            strBoard[(board.GetLength(0) - 1), j] = " " + (letters[j]) + " ";
                        }
                        //Add borders to empty cells
                        if (i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 !=0)
                        {
                            board[i, j] = (verticalCellBorder);

                            strBoard[i, j] = (verticalCellBorder);
                        }
                        if (i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 == 0)
                        {
                            board[i, j] = (horizontalCellBorder);

                            strBoard[i, j] = (horizontalCellBorder);
                        }
                        //Place black and white pawns on the chessboard
                        if (i == 3 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            Chess.Model.Pawn Pawn = new Chess.Model.Pawn("BPa", i, j);
                            board[i, j] = Pawn;//Stands for Black Pawn

                            strBoard[i, j] = Pawn.Name;
                        }
                        if (i == 13 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            Chess.Model.Pawn Pawn = new Chess.Model.Pawn("WPa", i, j);
                            board[i, j] = Pawn;//Stands for White Pawn

                            strBoard[i, j] = Pawn.Name;
                        }
                        //Fill with spaces null cells, in order to allign the matrix
                        if (board[i,j] == null)
                        {
                            board[i, j] = "   ";

                            strBoard[i, j] = "   ";
                        }
                        //Place black and white rooks on the chessboard
                        if (i == 1 && j== 1)
                        {
                            Chess.Model.Rook Rook = new Chess.Model.Rook("BRo", i, j);
                            board[i, j] = Rook;//Stands for Black Rook
                            board[i, j + 14] = Rook;

                            strBoard[i, j] = Rook.Name;
                            strBoard[i, j + 14] = Rook.Name;
                        }
                        if (i == 15 && j == 1)
                        {
                            Chess.Model.Rook Rook = new Chess.Model.Rook("WRo", i, j);
                            board[i, j] = Rook;//Stands for White Rook
                            board[i, j + 14] = Rook;

                            strBoard[i, j] = Rook.Name;
                            strBoard[i, j + 14] = Rook.Name;
                        }
                        //Place black and white knights on the chessboard
                        if (i == 1 && j == 3)
                        {
                            Chess.Model.Knight Knight = new Chess.Model.Knight("BKn", i, j);
                            board[i, j] = Knight;//Stands for Black Knight
                            board[i, j + 10] = Knight;

                            strBoard[i, j] = Knight.Name;
                            strBoard[i, j + 10] = Knight.Name;
                        }
                        if (i == 15 && j == 3)
                        {
                            Chess.Model.Knight Knight = new Chess.Model.Knight("WKn", i, j);
                            board[i, j] = Knight;//Stands for White Knight
                            board[i, j + 10] = Knight;

                            strBoard[i, j] = Knight.Name;
                            strBoard[i, j + 10] = Knight.Name;
                        }
                        //Place black and white bishops on the chessboard
                        if (i == 1 && j == 5)
                        {
                            Chess.Model.Bishop Bishop = new Chess.Model.Bishop("BBi", i, j);
                            board[i, j] =Bishop;//Stands for Black Bishop
                            board[i, j + 6] = Bishop;

                            strBoard[i, j] = Bishop.Name;
                            strBoard[i, j + 6] = Bishop.Name;
                        }
                        if (i == 15 && j == 5)
                        {
                            Chess.Model.Bishop Bishop = new Chess.Model.Bishop("WBi", i, j);
                            board[i, j] = Bishop;//Stands for White Bishop
                            board[i, j + 6] = Bishop;

                            strBoard[i, j] = Bishop.Name;
                            strBoard[i, j + 6] = Bishop.Name;
                        }
                        //Place white and black queen on the chessboard
                        if (i == 1 && j == 7)
                        {
                            Chess.Model.Queen Queen = new Chess.Model.Queen("BQu", i, j);
                            board[i, j] = Queen;//Stands for Black Queen

                            strBoard[i, j] = Queen.Name;
                        }
                        if (i == 15 && j == 7)
                        {
                            Chess.Model.Queen Queen = new Chess.Model.Queen("WQu", i, j);
                            board[i, j] = Queen;//Stands for White Queen

                            strBoard[i, j] = Queen.Name;
                        }
                        //Place black and white king on the chessboard
                        if (i == 1 && j == 9)
                        {
                            Chess.Model.King King = new Chess.Model.King("BKi", i, j);
                            board[i, j] = King;//Stands for Black King

                            strBoard[i, j] = King.Name;
                        }
                        if (i == 15 && j == 9)
                        {
                            Chess.Model.King King = new Chess.Model.King("WKi", i, j);
                            board[i, j] = King;//Stands for White King

                            strBoard[i, j] = King.Name;
                        }
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Draw the chessboard design and the pieces
        /// </summary>
        public void Draw()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }

                Console.Write(Environment.NewLine);
            }

            Console.ReadLine();
        }

        public void Tostring()
        {
            for (int i = 0; i < strBoard.GetLength(0); i++)
            {
                for (int j = 0; j < strBoard.GetLength(1); j++)
                {
                    Console.Write(strBoard[i, j] + " ");
                }

                Console.Write(Environment.NewLine);
            }

            Console.ReadLine();
        }

        public object[,] Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
            }
        }

        public string[,] StrBoard
        {
            get
            {
                return strBoard;
            }
            set
            {
                strBoard = value;
            }
        }

        #endregion
    }
}
