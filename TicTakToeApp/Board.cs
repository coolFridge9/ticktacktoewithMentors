using System.Collections.Generic;

namespace TicTakToeApp
{
    public class Board
    {
        private MoveList allMoves= new MoveList();
        
        public void AddMove(Move move)
        {
            allMoves.AddMove(move);
        }

        public bool IsSpaceTaken(Move move)
        {
            var moveInList = new List<Move> {move};
            return WinChecker.ContainsAllItems(allMoves.Moves, moveInList);
        }
    }
}