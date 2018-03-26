using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace TicTakToeApp
{
    public class MoveList
    {
        public readonly List<Move> UserMoveList = new List<Move>();
        public readonly List<Move> ComputerMoveList = new List<Move>();
        public readonly List<Move> Moves = new List<Move>();
        
        
        public void AddUserMove(Move move)
        {
            UserMoveList.Add(move);
        }

        public void AddComputerMove(Move move)
        {
            ComputerMoveList.Add(move);
        }

        public void AddMove(Move move)
        {
            Moves.Add(move);
        }
    }
}