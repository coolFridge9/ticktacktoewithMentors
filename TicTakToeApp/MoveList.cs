using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace TicTakToeApp
{
    public class MoveList
    {
        public readonly List<Move> UserMoveList = new List<Move>();
        public readonly List<Move> ComputerMoveList = new List<Move>();
        public static readonly int SizeOfBoard = 3;
        
        public void AddUserMove(Move move)
        {
            UserMoveList.Add(move);
        }

        public void AddComputerMove(Move move)
        {
            ComputerMoveList.Add(move);
        }
    }
}