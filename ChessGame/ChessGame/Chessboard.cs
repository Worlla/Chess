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
        private Chess.Model.Piece[,] board;

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
                board = new Chess.Model.Piece[boardX, boardY];
               
                letters = new Dictionary<int, string>();
                letters.Add(1, " a ");
                letters.Add(3, " b ");
                letters.Add(5, " c ");
                letters.Add(7, " d ");
                letters.Add(9, " e ");
                letters.Add(11, " f ");
                letters.Add(13, " g ");
                letters.Add(15, " h ");
                
                verticalCellBorder = " | ";

                horizontalCellBorder = " - ";
                
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        //Place black and white pawns on the chessboard
                        if (i == 3 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            Chess.Model.Pawn pawn = new Chess.Model.Pawn("BPa", i, j);
                            board[i, j] = pawn;//Stands for Black Pawn                           
                        }
                        if (i == 13 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                        {
                            Chess.Model.Pawn pawn = new Chess.Model.Pawn("WPa", i, j);
                            board[i, j] = pawn;//Stands for White Pawn
                        }
                        //Place black and white rooks on the chessboard
                        if (i == 1 && j== 1)
                        {
                            Chess.Model.Rook rook = new Chess.Model.Rook("BRo", i, j);
                            board[i, j] = rook;//Stands for Black Rook
                            board[i, j + 14] = rook;
                        }
                        if (i == 15 && j == 1)
                        {
                            Chess.Model.Rook rook = new Chess.Model.Rook("WRo", i, j);
                            board[i, j] = rook;//Stands for White Rook
                            board[i, j + 14] = rook;
                        }
                        //Place black and white knights on the chessboard
                        if (i == 1 && j == 3)
                        {
                            Chess.Model.Knight knight = new Chess.Model.Knight("BKn", i, j);
                            board[i, j] = knight;//Stands for Black Knight
                            board[i, j + 10] = knight;
                        }
                        if (i == 15 && j == 3)
                        {
                            Chess.Model.Knight knight = new Chess.Model.Knight("WKn", i, j);
                            board[i, j] = knight;//Stands for White Knight
                            board[i, j + 10] = knight;
                        }
                        //Place black and white bishops on the chessboard
                        if (i == 1 && j == 5)
                        {
                            Chess.Model.Bishop bishop = new Chess.Model.Bishop("BBi", i, j);
                            board[i, j] = bishop;//Stands for Black Bishop
                            board[i, j + 6] = bishop;
                        }
                        if (i == 15 && j == 5)
                        {
                            Chess.Model.Bishop bishop = new Chess.Model.Bishop("WBi", i, j);
                            board[i, j] = bishop;//Stands for White Bishop
                            board[i, j + 6] = bishop;
                        }
                        //Place white and black queen on the chessboard
                        if (i == 1 && j == 7)
                        {
                            Chess.Model.Queen queen = new Chess.Model.Queen("BQu", i, j);
                            board[i, j] = queen;//Stands for Black Queen
                        }
                        if (i == 15 && j == 7)
                        {
                            Chess.Model.Queen queen = new Chess.Model.Queen("WQu", i, j);
                            board[i, j] = queen;//Stands for White Queen
                        }
                        //Place black and white king on the chessboard
                        if (i == 1 && j == 9)
                        {
                            Chess.Model.King king = new Chess.Model.King("BKi", i, j);
                            board[i, j] = king;//Stands for Black King
                        }
                        if (i == 15 && j == 9)
                        {
                            Chess.Model.King king = new Chess.Model.King("WKi", i, j);
                            board[i, j] = king;//Stands for White King
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
        public string Tostring()
        {
            StringBuilder sb = new StringBuilder();

            numberCoordinate = 8;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j == 0 && i % 2 != 0)
                    {
                        sb.Append(" " + numberCoordinate.ToString() + "|");
                        numberCoordinate--;
                    }
                    if (i == 0 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0 || i == board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 != 0)
                    {
                        sb.Append(letters[j]);
                    }
                    if (board[i, j] == null)
                    {
                        sb.Append("   ");
                    }
                    if (i != 0 && j != 0)
                    {
                        sb.Append(board[i, j]);
                    }
                    if (i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 != 0)
                    {
                        sb.Append(verticalCellBorder);
                    }
                    if(i > 0 && i < board.GetLength(0) - 1 && j > 0 && j < board.GetLength(1) - 1 && j % 2 == 0 && i % 2 == 0)
                    {
                        sb.Append(horizontalCellBorder);
                    }
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        public Chess.Model.Piece[,] Board
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
