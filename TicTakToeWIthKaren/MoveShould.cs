using System.Linq;
using System.Threading;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class MoveShould
    {

        [Fact]
        public void ReturnInitialisedCoordinates()
        {
            var move = new Move(2, 2);
            Assert.Equal(2, move.X);
            Assert.Equal(2, move.Y);
        }
    }
}