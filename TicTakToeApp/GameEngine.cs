using System.Collections.Generic;

namespace TicTakToeApp
{
    public class GameEngine
    {
        public readonly List<Player> Players = new List<Player>();
        private readonly StringToMoveConverter converter = new StringToMoveConverter();
        private Board board= new Board();
        private EndOfGameMessage message = new EndOfGameMessage();
       
        public void CreatePlayer(Player player) // TODO: adds not creates
        {
            Players.Add(player);
        }

        public void RunGame() 
        {
            
            var didAPlayerWin = false;
            while (!didAPlayerWin && Players.Count>0)
            {
                didAPlayerWin = IteratePlayerTurns();
            }
        }

        private bool IteratePlayerTurns()
        {
            foreach (var player in Players)
            {
                var moveString = player.GetMove(board); 

                if (moveString == "q")
                {
                    KillPlayer(player);
                    board.Reform(Players);
                }

                else
                {
                    var move = converter.ConvertToMove(moveString);

                    player.AddMove(move);
                    board.AddMove(move); 

                    if (player.DidWin())
                    {
                        message.WinMessage(player);
                        return true;
                    }

                    //display board with playerlist as parameter 
                }
            }

            return false;
        }

        public void KillPlayer(Player player)
        {
            Players.Remove(player);
            message.QuitMessage(player);
        }
    }
}