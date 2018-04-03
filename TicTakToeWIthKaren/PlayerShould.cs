using TicTakToeApp;
using Xunit;
using Xunit.Sdk;

namespace TicTakToeWIthKaren
{
    public class PlayerShould
    {
        [Fact]
        public void BeInitialisedWithmovesAndSymbol()
        { 
           var player = new Player('x',new HumanMover());   
        }

        [Fact]
        public void BeAbletoAddMove()
        {
            var player = new Player('x',new HumanMover());
            Move move = new Move(3,3);
            player.AddMove(move);

        }
        
        [Fact]
        public void KnowWhenWonGame()
        {
            var player = new Player('x',new HumanMover());
            
            player.AddMove(new Move(3,3));
            player.AddMove(new Move(5,3));
            player.AddMove(new Move(1,1));
            player.AddMove(new Move(2,2));

            bool won = player.DidWin();
            Assert.True(won);

        }
        [Fact]
        public void KnowWhenDidntWinGame()
        {
            var player = new Player('x',new HumanMover());
            
            player.AddMove(new Move(3,3));
            player.AddMove(new Move(5,3));
            player.AddMove(new Move(1,1));
            player.AddMove(new Move(2,3));

            bool won = player.DidWin();
            Assert.False(won);

        }
        
    }
}