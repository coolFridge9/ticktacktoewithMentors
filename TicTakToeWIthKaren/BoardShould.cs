using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void RecreateBasedOnPlayersMoves()
        {
            var player = new Player('O');
            player.AddMove(new Move(1,1));
            player.AddMove(new Move(2,3));
            var board = new Board();
            board.Reform(new List<Player> {player});

            var expected = new List<Move> {new Move(1, 1), new Move(2, 3)};
            
            Assert.True(expected.SequenceEqual(board.allMoves));
            
        }
        
    }
}