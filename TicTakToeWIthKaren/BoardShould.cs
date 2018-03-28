using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class BoardShould
    {
        [Fact]
        public void AddMoveToBoard()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1));
        }
    
        [Fact]
        public void CheckIfSpaceIsTaken()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1));
            bool taken = board.IsSpaceTaken(new Move(1,1));
            Assert.True(taken);

        }
        [Fact]
        public void CheckIfSpaceIsntTaken()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1));
            bool taken = board.IsSpaceTaken(new Move(1,2));
            Assert.False(taken);

        }
        
    }
}