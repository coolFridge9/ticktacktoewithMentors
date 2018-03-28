using System.Collections.Generic;

namespace TicTakToeApp
{
    public class GameEngine
    {
        public readonly List<Player> Players = new List<Player>();
       
        public void CreatePlayer(Player player)
        {
            Players.Add(player);
        }

        public void RunGame() 
        {
            var converter = new StringToMoveConverter();
            var endGame = false;
            var board= new Board();
            while (!endGame && Players.Count>0)
            {
                foreach (var player in Players) //while no player has won
                {
                    var moveString = player.GetMove();

                    if (moveString == "q")
                    {
                        endGame = true; //remove player instead
                        //goodbye message
                        break; 
                    }

                    player.AddMove(converter.ConvertToMove(moveString));

                    if (player.DidWin())
                    {
                        endGame = true;
                        //winclass message accepting player as parameter
                        break;
                    }

                    //display board with playerlist as parameter   
                }
            }
        }

        public void KillPlayer(char c)
        {
            throw new System.NotImplementedException();
        }
    }
}