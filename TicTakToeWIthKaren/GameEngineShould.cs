using System.Runtime.InteropServices.ComTypes;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class GameEngineShould
    {
        [Fact]
        public void CreateUserPlayers()
        {
            var game = new GameEngine();
            game.CreatePlayer(new Player('X'));
        }

        [Fact]
        public void RunGame()
        {
            var game = new GameEngine();
            game.RunGame();
        }
    }
}