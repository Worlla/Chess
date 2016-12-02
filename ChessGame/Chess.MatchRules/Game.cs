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
           
            XInitialCoordinate = new int();
            YInitialCoordinate = new int();
            XFinalCoordniate = new int();
            YFinalCoordinate = new int();
            startingCoordinate = new int();
        }

        public bool move()
        {
            // Insert initial coordinates for the pawn line
            chessboard.Tostring();

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

                //Move
                ((Chess.Model.Piece)chessboard.Board[XInitialCoordinate, YInitialCoordinate]).isMoveAllowed();
                
                chessboard.Tostring();
            }

            return false;
        }

        #endregion
    }
}
