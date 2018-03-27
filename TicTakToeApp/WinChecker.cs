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
            var xCoordinates = AddXCoordinatesIntoSortedList(moveList.Moves); 
            var yCoordinates = AddYCoordinatesIntoSortedList(moveList.Moves);
            return ContainsStraightLine(xCoordinates) || ContainsStraightLine(yCoordinates) || 
                   CheckForDiagonalWin(moveList.Moves);
        }

        public List<int> AddXCoordinatesIntoSortedList(List<Move> moveList)
        {
            var xCoordinates = new List<int>();

            foreach (var move in moveList)
                xCoordinates.Add(move.X);
    
            xCoordinates.Sort();
            return xCoordinates;
        }
        
        public List<int> AddYCoordinatesIntoSortedList(List<Move> moveList)
        {
            var xCoordinates = new List<int>();

            foreach (var move in moveList)
                xCoordinates.Add(move.Y);
    
            xCoordinates.Sort();
            return xCoordinates;
        }

        public bool ContainsStraightLine(List<int> listOfCoordinates)
        {
            var count = 0;
            for (int i = 1; i < listOfCoordinates.Count; i++)
            {
                count = GetCount(count, listOfCoordinates[i], listOfCoordinates[i - 1]);

                if (count == NumberInARowToWin-1)
                    return true;
            }

            return false;
        }

        public int GetCount(int count, int coordinate, int previousCoordinate)
        {
            if (coordinate == previousCoordinate)
                return count + 1;
            else
            {
                return 0;
            }
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
            var moves = convertToTupleList(a);
            var winmoves = convertToTupleList(b);
            return !winmoves.Except(moves).Any();
        }

        private static List<Tuple<int,int>> convertToTupleList(List<Move> moves)
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