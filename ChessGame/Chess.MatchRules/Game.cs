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
                if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BPa" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WPa")
                {
                    pawn.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, startingCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                //Knight move
                else if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BKn" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WKn")
                {
                    knight.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                //King move
                else if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BKi" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WKi")
                {
                    king.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                //Bishop move
                else if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BBi" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WBi")
                {
                    bishop.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                //Rook move
                else if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BRo" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WRo")
                {
                    rook.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                //Queen move
                else if (chessboard.Board[XInitialCoordinate, YFinalCoordinate] == "BQu" || chessboard.Board[XInitialCoordinate, YInitialCoordinate] == "WQu")
                {
                    queen.ismoveAllowed(XInitialCoordinate, YInitialCoordinate, XFinalCoordniate, YFinalCoordinate, chessboard.Board);
                    chessboard.Board[XFinalCoordniate, YFinalCoordinate] = chessboard.Board[XInitialCoordinate, YInitialCoordinate];
                    chessboard.Board[XInitialCoordinate, YInitialCoordinate] = "   ";
                    initialAndFinalCoordinates = true;
                }

                else
                {
                    Console.WriteLine("Irregular move!");
                    continue;
                }

                chessboard.Draw();
            }

            return false;
        }

        #endregion
    }
}
