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
        public void RemoveAPlayerFromBoard()
        {
            var player = new Player('O',new HumanMover());
            player.AddMove(new Move(1,1));
        
            var board = new Board();
            
            board.AddMove(new Move(1,1));
            board.AddMove(new Move(2,3));
            board.AddMove(new Move(3,2));
            
            board.RemovePlayer(player);

            var expected = new List<Move> {new Move(2, 3), new Move(3,2)};
            Assert.True(ComparePlayerLists(expected,board.allMoves));
            
        }
        
       /* [Fact]
        public void RecreateBasedOnPlayersMoves()
        {
            var player = new Player('O',new HumanMover());
            player.AddMove(new Move(1,1));
            player.AddMove(new Move(2,3));
            var board = new Board();
            board.CleanUpBoard(new List<Player> {player});

            var expected = new List<Move> {new Move(1, 1), new Move(2, 3)};
            
            Assert.True(ComparePlayerLists(expected,board.allMoves));
            
        }*/

        [Fact]
        public void ReturnMostRecentMove()
        {
            var board = new Board();
            board.AddMove(new Move(1, 1));
            board.AddMove(new Move(1, 2));
            Move result = board.GetMostRecentMove();
            Assert.Equal(result.X,1);
            Assert.Equal(result.Y,2);
        }

        

        private bool ComparePlayerLists(List<Move> expected,List<Move> actual)
        {
            for (int i = 0; i < expected.Count; i++)
            {
                if (expected[i].X != actual[i].X)
                    return false;
                if (expected[i].Y != actual[i].Y)
                    return false;
            }

            return true;
        }
        
    }
}