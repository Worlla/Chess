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
        private string[,] board;

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
                board = new string[boardX, boardY];

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
                            numberCoordinate--;
                        }
                        //Write letters on the top and bottom of the chessboard
                        if (i == 0 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            board[i, j] = " " + (letters[j]) + " ";
                            board[(board.GetLength(0) - 1), j] = " " + (letters[j]) + " ";
                        }
                        //Add borders to empty cells
                        if (i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 !=0)
                        {
                            board[i, j] = (verticalCellBorder);
                        }
                        if (i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 == 0)
                        {
                            board[i, j] = (horizontalCellBorder);
                        }
                        //Place black and white pawns on the chessboard
                        if (i == 3 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            board[i, j] = ("BPa");//Stands for Black Pawn
                        }
                        if (i == 13 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            board[i, j] = ("WPa");//Stands for White Pawn
                        }
                        //Fill with spaces null cells, in order to allign the matrix
                        if (board[i,j] == null)
                        {
                            board[i, j] = "   ";
                        }
                        //Place black and white rooks on the chessboard
                        if (i == 1 && j== 1)
                        {
                            board[i, j] = ("BRo");//Stands for Black Rook
                            board[i, j + 14] = ("Bro");
                        }
                        if (i == 15 && j == 1)
                        {
                            board[i, j] = ("WRo");//Stands for White Rook
                            board[i, j + 14] = ("Wro");
                        }
                        //Place black and white knights on the chessboard
                        if (i == 1 && j == 3)
                        {
                            board[i, j] = ("BKn");//Stands for Black Knight
                            board[i, j + 10] = ("BKn");
                        }
                        if (i == 15 && j == 3)
                        {
                            board[i, j] = ("WKn");//Stands for White Knight
                            board[i, j + 10] = ("WKn");
                        }
                        //Place black and white bishops on the chessboard
                        if (i == 1 && j == 5)
                        {
                            board[i, j] = ("BBi");//Stands for Black Bishop
                            board[i, j + 6] = ("BBi");
                        }
                        if (i == 15 && j == 5)
                        {
                            board[i, j] = ("WBi");//Stands for White Bishop
                            board[i, j + 6] = ("WBi");
                        }
                        //Place white and black queen on the chessboard
                        if (i == 1 && j == 7)
                        {
                            board[i, j] = ("BQu");//Stands for Black Queen
                        }
                        if (i == 15 && j == 7)
                        {
                            board[i, j] = ("WQu");//Stands for White Queen
                        }
                        //Place black and white king on the chessboard
                        if (i == 1 && j == 9)
                        {
                            board[i, j] = ("BKi");//Stands for Black King
                        }
                        if (i == 15 && j == 9)
                        {
                            board[i, j] = ("WKi");//Stands for White King
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

        public string[,] Board
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

        #endregion
    }
}
