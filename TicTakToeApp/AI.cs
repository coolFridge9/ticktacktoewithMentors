using System;
using System.Xml.Schema;

namespace TicTakToeApp
{
    public class AI
    {
        public string ChooseMove(Board board)
        {
            var move = board.GetMostRecentMove();
            while (board.IsSpaceTaken(move))
            {
                move = GetRandomMove(move);
            }

            return $"{move.X},{move.Y}";
        }

        private Move GetRandomMove(Move move)
        {
            var random = new Random();
            var x = random.Next(-1, 1)+move.X;
            var y = random.Next(-1, 1)+move.Y;
            
            return new Move(x,y);
            
        }
    }
}