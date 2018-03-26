using System.Collections.Generic;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class MoveListShould
    {

        [Fact]
        public void AddAMoveToMoveList()
        {
            var move = new Move(2,2);
            var moveList = new MoveList();
            moveList.AddMove(move);
        }
    
        
        [Fact]
        public void RetainMoves()
        {
            var moveList = new MoveList();
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));

            var expectedMovesList = new List<Move> 
                {new Move(1, 1), new Move(2, 2), new Move(2, 3)};
            
            ContainsSameItems(expectedMovesList, moveList);
        }

        private static void ContainsSameItems(List<Move> expected, MoveList actual)
        {
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i].X, actual.Moves[i].X);
                Assert.Equal(expected[i].Y, actual.Moves[i].Y);
            }
        }
    }
}