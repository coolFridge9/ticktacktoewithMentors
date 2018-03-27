using System.Collections.Generic;

namespace TicTakToeApp
{
    public class MoveList
    {
        public readonly List<Move> Moves = new List<Move>();

        public void AddMove(Move move)
        {
            Moves.Add(move);
        }
    }
}