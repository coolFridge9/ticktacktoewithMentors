using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TicTakToeApp
{
    public class WinChecker
    {
        public static readonly int SizeOfBoard = 3;
        public static readonly int NumberInARowToWin = SizeOfBoard;
        
        public bool CheckForWin(MoveList moveList) 
        {
            var xCoordinates = AddXCoordinatesIntoSortedList(moveList.Moves); 
            var yCoordinates = AddYCoordinatesIntoSortedList(moveList.Moves);
            return ContainsStraightLine(xCoordinates) || ContainsStraightLine(yCoordinates);
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

        public Dictionary<int, List<Move>> MakeXValuesKeys(MoveList moveList)
        {
            var seperated = new Dictionary<int, List<Move>>();
            foreach (var move in moveList.Moves)
            {
                if(seperated.ContainsKey(move.X))
                    seperated[move.X].Add(move);
                else
                {
                    seperated[move.X]= new List<Move>();
                }
            }

            return seperated;
        }


        public bool CheckForDiagonalWinLeftDown( List<Move> moves)
        {
            var win = new List<Move> {new Move(1, 1), new Move(2, 2), new Move(3, 3)};
            return ContainsAllItems(moves, win);
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