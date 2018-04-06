using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class UserInputHandlerShould
    {
        
        [Theory]
        [InlineData("1,1")]
        [InlineData("3,2")]
        [InlineData("q")]
        [InlineData("2,2")]
        public void ValidateCorrectInput(string input)
        {
            var inputHandler = new UserInputHandler();
            bool valid = inputHandler.IsValid(input);
            Assert.True(valid);
        }
        [Theory]
        [InlineData("qq")]
        [InlineData("1,1,")]
        [InlineData(",1,1")]
        [InlineData("a1,2r")]
        [InlineData("-2,-2")]
        [InlineData("0,0")]
        public void ValidateInorrectInput(string input)
        {
            var inputHandler = new UserInputHandler();
            bool valid = inputHandler.IsValid(input);
            Assert.False(valid);
        }

        [Fact]
        public void TellIfUserQuits()
        {
            var inputHandler = new UserInputHandler();
            bool quit = inputHandler.DidQuit("q");
            Assert.True(quit);
        }
        
    }
}