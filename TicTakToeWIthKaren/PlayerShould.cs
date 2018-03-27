using TicTakToeApp;
using Xunit;
using Xunit.Sdk;

namespace TicTakToeWIthKaren
{
    public class PlayerShould
    {
        [Fact]
        public void BeInitialisedWithMoveListAndSymbol()
        { 
           var player = new Player('x');   
        }
    }
}