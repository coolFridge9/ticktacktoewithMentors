using System.Collections.Generic;

namespace TicTakToeApp
{
    public class GameEngine
    {
        public readonly List<Player> Players = new List<Player>();
        private readonly StringToMoveConverter converter = new StringToMoveConverter();
        private Board board= new Board();
       
        public void CreatePlayer(Player player)
        {
            Players.Add(player);
        }

        public void RunGame() 
        {
            
            var didAPlayerWin = false;
            while (!didAPlayerWin && Players.Count>0)
            {
                didAPlayerWin = IteratePlayers();
            }
        }

        private bool IteratePlayers()
        {
            foreach (var player in Players) 
            {
                var moveString = player.GetMove();

                if (moveString == "q")
                {
                    KillPlayer(player);
                    return false;
                }

                var move = converter.ConvertToMove(moveString);
                //need to check if location is taken
                player.AddMove(move);
                board.AddMove(move);

                if (player.DidWin())
                {
                    //winclass message accepting player as parameter
                    return true;
                }

                //display board with playerlist as parameter   
            }
        }

        public void KillPlayer(Player player)
        {
            Players.Remove(player);
        }
    }
}