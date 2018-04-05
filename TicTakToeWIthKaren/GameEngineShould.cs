using System.Linq;
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
            game.CreatePlayer(new Player('X',new HumanMover()));
            Assert.Equal(game.Players[0].Symbol,'X');
        }

        [Fact]
        public void RunGame()
        {
            var game = new GameEngine();
            game.RunGame();
        }

        [Fact]
        public void DeletePlayer()
        {
            var game = new GameEngine();
            var player = new Player('X',new HumanMover());
            game.CreatePlayer(player);
            game.RemovePlayer(player);
            Assert.False(game.Players.Any());
        }
    }
}