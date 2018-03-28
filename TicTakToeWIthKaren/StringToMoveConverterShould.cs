using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class StringToMoveConverterShould
    {
        [Fact]
        public void ConvertStringToMove()
        {
            var converter = new StringToMoveConverter();
            var stringToConvert = "2,-3";
            Move move = converter.ConvertToMove(stringToConvert);
            Assert.Equal(2,move.X);
            Assert.Equal(-3,move.Y);
        }
    }
}