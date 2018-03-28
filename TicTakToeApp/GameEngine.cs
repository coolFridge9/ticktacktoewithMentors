using System.Collections.Generic;

namespace TicTakToeApp
{
    public class GameEngine
    {
        private List<Player> Players = new List<Player>();
       
        public void CreatePlayer(Player player)
        {
            Players.Add(player);
        }

        public void RunGame()
        {
            var converter = new StringToMoveConverter();
            foreach (var player in Players)
            {
                var moveString= player.GetMove();
                
                if (moveString == "q")
                    break;
                
                player.AddMove(converter.ConvertToMove(moveString));
                
                if (player.DidWin())
                    break; //add win message

            }
        }
    }
}