using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess.MatchRules.Game game = new Chess.MatchRules.Game();

            bool match = false;

            do
            {
                match = game.move();
            }
            while (!match);
        }
    }
}
