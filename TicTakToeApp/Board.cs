using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace TicTakToeApp
{
    public class Board
    {
        //private moves allMoves= new moves();
        public List<Move> allMoves { get; private set; }

        public Board()
        {
            allMoves = new List<Move>();
        }
        
        public void AddMove(Move move)
        {
            allMoves.Add(move);
        }

        public bool IsSpaceTaken(Move move)
        {
            var moveInList = new List<Move> {move};
            return WinChecker.ContainsAllItems(allMoves, moveInList);
        }

        public void RemovePlayer(Player player)
        {
            foreach (var move in player.Moves)
                allMoves.Remove(move);  
        }

        public Move GetMostRecentMove()
        {
            return allMoves.Count ==0 ? new Move(0,0) : allMoves[allMoves.Count - 1];
        }
    }
}