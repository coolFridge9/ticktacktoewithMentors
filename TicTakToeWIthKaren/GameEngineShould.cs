using System.Collections.Generic;
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

    public class GameEngine
    {
        private List<Player> Players = new List<Player>();
       
        public void CreatePlayer(Player player)
        {
            Players.Add(player);
        }

        public void RunGame()
        {
            foreach (var player in Players)
            {
                var moveString= player.GetMove();
                if (moveString == "q")
                    break;
                player.AddMove();

            }
        }
    }
}