using System.Collections.Generic;

namespace TicTakToeApp
{
    public class WinChecker
    {
        public bool CheckIfUserWon(MoveList moveList) //rename vertical something
        {
            var xCoordinates = AddXCoordinatesIntoSortedList(moveList.UserMoveList);
            return ContainsStraightLine(xCoordinates);
        }

        public List<int> AddXCoordinatesIntoSortedList(List<Move> moveList)
        {
            var xCoordinates = new List<int>();

            foreach (var move in moveList)
                xCoordinates.Add(move.X);
    
            xCoordinates.Sort();
            return xCoordinates;
        }

        public bool ContainsStraightLine(List<int> listOfCoordinates)
        {
            var count = 0;
            for (int i = 1; i < listOfCoordinates.Count; i++)
            {
                count = GetCount(count, listOfCoordinates[i], listOfCoordinates[i - 1]);

                if (count == MoveList.SizeOfBoard-1)
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
    }
}