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
            return CheckForDiagonalWin(moveList.Moves) || CheckForStraightWin(moveList.Moves);
        }

        public bool CheckForDiagonalWin( List<Move> moves)
        {
            foreach (var move in moves)
            {
                List<Move> corrospondingMovesForLeftWin = CalculateCorospondingMovesFromLeft(move);
                List<Move> corrospondingMovesForRightWin = CalculateCorospondingMovesFromRight(move);
                if (ContainsAllItems(moves, corrospondingMovesForLeftWin) || 
                    ContainsAllItems(moves,corrospondingMovesForRightWin))                
                    return true;
            }

            return false;
        }
        
        public bool CheckForStraightWin( List<Move> moves)
        {
            foreach (var move in moves)
            {
                List<Move> corrospondingMovesForHorizontal = CalculateCorospondingHorizontal(move);
                List<Move> corrospondingMovesForVertical = CalculateCorospondingVertical(move);
                if (ContainsAllItems(moves, corrospondingMovesForHorizontal) || 
                    ContainsAllItems(moves,corrospondingMovesForVertical))                
                    return true;
            }

            return false;
        }

        private List<Move> CalculateCorospondingHorizontal(Move move)
        {
            List<Move> winners = new List<Move>();
                                    
            for (int i = 1; i < NumberInARowToWin; i++)
                winners.Add(new Move(move.X+i,move.Y));
         
            return winners;
        }
        
        private List<Move> CalculateCorospondingVertical(Move move)
        {
            List<Move> winners = new List<Move>();
                                    
            for (int i = 1; i < NumberInARowToWin; i++)
                winners.Add(new Move(move.X,move.Y+i));
         
            return winners;
        }


        private List<Move> CalculateCorospondingMovesFromRight(Move move)
        {
            List<Move> winners = new List<Move>();
                        
            for (int i = 1; i < NumberInARowToWin; i++)
                winners.Add(new Move(move.X+i,move.Y-i));
         
            return winners;
        }

        private List<Move> CalculateCorospondingMovesFromLeft(Move move)
        {
            List<Move> winners = new List<Move>();
            
            for (int i = 1; i < NumberInARowToWin; i++)
                winners.Add(new Move(move.X+i,move.Y+i));
         
            return winners;
        }

        private static bool ContainsAllItems(List<Move> a, List<Move> b)
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