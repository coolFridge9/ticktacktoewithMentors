using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TicTakToeApp
{
    public class WinChecker
    {
        public static readonly int NumberInARowToWin = 3;

        
        public bool CheckForWin(MoveList moveList)
        {

            const int stepRight = 1;
            const int stepDown = 1;
            const int stepUp = -1;
            const int stepNowhere = 0;
            
            foreach (var move in moveList.Moves)
            {
                var movesRequiredForHorizontalWin = CalculateWinningMoves(move, stepRight, stepNowhere);
                var movesRequiredForVerticalWin = CalculateWinningMoves(move, stepNowhere, stepDown);
                var movesRequiredForDiagonalLeftWin = CalculateWinningMoves(move, stepRight, stepUp);
                var movesRequiredForDiagonalRightWin= CalculateWinningMoves(move, stepRight, stepDown);

                if (ContainsAllItems(moveList.Moves, movesRequiredForHorizontalWin) || 
                    ContainsAllItems(moveList.Moves, movesRequiredForVerticalWin) ||
                    ContainsAllItems(moveList.Moves, movesRequiredForDiagonalLeftWin) ||
                    ContainsAllItems(moveList.Moves, movesRequiredForDiagonalRightWin))                
                    return true;
            }
            
            return false;
        }

        private List<Move> CalculateWinningMoves(Move startingMove, int horizontalStep, int verticalStep)
        {
            List<Move> winners = new List<Move>();
                                    
            for (int i = 1; i < NumberInARowToWin; i++)
                winners.Add(new Move(startingMove.X+(i * horizontalStep),startingMove.Y+(i * verticalStep)));
         
            return winners;
        }
        

        public static bool ContainsAllItems(List<Move> a, List<Move> b)
        {
            var moves = ConvertToTupleList(a);
            var winmoves = ConvertToTupleList(b);
            return !winmoves.Except(moves).Any();
        }

        private static List<Tuple<int,int>> ConvertToTupleList(List<Move> moves)
        {
            List<Tuple<int,int>> converted = new List<Tuple<int, int>>();
            foreach (var move in moves)
            {
                converted.Add(Tuple.Create(move.X,move.Y));
            }

            return converted;
        }

       
    }
}