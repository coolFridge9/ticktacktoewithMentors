using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class AIShould //Find a taken space and find a space which isnt taken
    {
        [Fact]
        public void ReturnMove()
        {
            var board = new Board();
            board.AddMove(new Move(1,1));
            var converter = new StringToMoveConverter();
            var AI = new AI();
            var AIMove = AI.ChooseMove(board);
            Assert.False(board.IsSpaceTaken(converter.ConvertToMove(AIMove)));

        }
    }
}