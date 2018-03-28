using System;

namespace TicTakToeApp
{
    public class StringToMoveConverter
    {
        public Move ConvertToMove(string stringToConvert)
        {
            var coordinates = stringToConvert.Split(',');
            var x = Convert.ToInt32(coordinates[0]);
            var y = Convert.ToInt32(coordinates[1]);
            return new Move(x,y);
        }
    }
}