using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class MoveShould
    {
        [Fact]
        public void InitialiseWithCoordinates()
        {
            var move = new Move(2,2);
        }
    }
}