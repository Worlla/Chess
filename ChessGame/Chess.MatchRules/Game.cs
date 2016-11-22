using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MatchRules
{
    /// <summary>
    /// Starting the game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Game features
        /// </summary>

        #region Private members
        //Declare necessary items for the match to develop    
        private ChessGame.Chessboard chessboard;
        private Chess.Model.Pawn pawn;
        private Chess.Model.Knight knight;
        private Chess.Model.Bishop bishop;
        private Chess.Model.Rook rook;
        private Chess.Model.Queen queen;
        private Chess.Model.King king;

        private int startingCoordinate;
        private int XInitialCoordinate;
        private int YInitialCoordinate;
        private int XFinalCoordniate;
        private int YFinalCoordinate;

        private string[,] board;

        #endregion

        #region Public members

        public Game()
        {
            chessboard = new ChessGame.Chessboard();
            pawn = new Model.Pawn();
            knight = new Model.Knight();
            bishop = new Model.Bishop();
            rook = new Model.Rook();
            queen = new Model.Queen();
            king = new Model.King();

            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
            startingCoordinate = new int();
            
            board = chessboard.Board;
        }

        public bool move()
        {
            // Insert initial coordinates for the pawn line
            bool StartingCoordinate = false;
            while (!StartingCoordinate)
            {
                Console.WriteLine("Please enter the Starting Coordinate of your pawn line, so that the computer could recognse if yours are black or white, if you want to move one of them");
                Console.WriteLine("Type 3 if you manage black pieces, 13 if you manage white pieces");
                string startingCoordinateInput = (Console.ReadLine());

                int.TryParse(startingCoordinateInput, out startingCoordinate);

                if (startingCoordinate != 3 && startingCoordinate != 13)
                {
                    Console.WriteLine("Invalid starting Coordinate!");
                    continue;
                }
                else StartingCoordinate = true;
            }

            bool initialAndFinalCoordinates = false;
            while (!initialAndFinalCoordinates)
            {
                Console.WriteLine("Enter the X Initial Coordinate of your piece");
                XInitialCoordinate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Y Initial Coordinate");
                YInitialCoordinate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the X Final Coordinate of your piece");
                XFinalCoordniate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Y Final Coordinate of your piece");
                YFinalCoordinate = Convert.ToInt32(Console.ReadLine());

                //Pawn move
                if (board[XInitialCoordinate, YFinalCoordinate] == "BPa" || board[XInitialCoordinate, YInitialCoordinate] == "WPa")
                {
                    pawn.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, startingCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                //Knight move
                else if (board[XInitialCoordinate, YFinalCoordinate] == "BKn" || board[XInitialCoordinate, YInitialCoordinate] == "WKn")
                {
                    knight.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                //King move
                else if (board[XInitialCoordinate, YFinalCoordinate] == "BKi" || board[XInitialCoordinate, YInitialCoordinate] == "WKi")
                {
                    king.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                //Bishop move
                else if (board[XInitialCoordinate, YFinalCoordinate] == "BBi" || board[XInitialCoordinate, YInitialCoordinate] == "WBi")
                {
                    bishop.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                //Rook move
                else if (board[XInitialCoordinate, YFinalCoordinate] == "BRo" || board[XInitialCoordinate, YInitialCoordinate] == "WRo")
                {
                    rook.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                //Queen move
                else if (board[XInitialCoordinate, YFinalCoordinate] == "BQu" || board[XInitialCoordinate, YInitialCoordinate] == "WQu")
                {
                    queen.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, board);
                    board[XFinalCoordniate, YFinalCoordinate] = board[XInitialCoordinate, YInitialCoordinate];
                    board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    chessboard.Draw();
                    initialAndFinalCoordinates = true;
                }

                else
                {
                    Console.WriteLine("Irregular move!");
                    continue;
                }
            }
            
            return false;
        }

        #endregion
    }
}
