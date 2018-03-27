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

    public class Player
    {
        public MoveList MoveList= new MoveList();
        public static char Symbol;
        
        
        public Player(char c)
        {
            Symbol = c;
        }
    }
}