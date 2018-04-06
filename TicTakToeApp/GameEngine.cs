using System;
using System.Collections.Generic;

namespace TicTakToeApp
{
    public class GameEngine
    {
        public readonly List<Player> Players = new List<Player>();
        private readonly StringToMoveConverter converter = new StringToMoveConverter();
        private Board board= new Board();
        private EndOfGameMessage message = new EndOfGameMessage();
        private Renderer renderer = new Renderer();
       
        public void AddNewPlayer(Player player) 
        {
            Players.Add(player);
        }

        public void RunGame() 
        {
            
            var didAPlayerWin = false;
            while ((!didAPlayerWin) && Players.Count>0)
            {
                didAPlayerWin = IteratePlayerTurns();
            }
        }

        private bool IteratePlayerTurns()
        {
            var playersToRemove = new List<Player>();
            foreach (var player in Players)
            {
                Console.WriteLine("player "+player.Symbol+"'s turn:");
                var moveString = player.GetMove(board); 

                if (moveString == "q")
                {
                    board.RemovePlayer(player);
                    playersToRemove.Add(player);
                    message.QuitMessage(player);
                    player.Symbol = '.';
                    renderer.DisplayBoard(Players);
                }

                else
                {
                    var move = converter.ConvertToMove(moveString);

                    player.AddMove(move);
                    board.AddMove(move); 

                    if (player.DidWin())
                    {
                        renderer.DisplayBoard(Players);
                        message.WinMessage(player);
                        return true;
                    }

                    renderer.DisplayBoard(Players);
                }
            }

            RemoveDeadPlayers(playersToRemove);
            return false;
        }

        private void RemoveDeadPlayers(List<Player> playersToRemove)
        {
            foreach (var player in playersToRemove)
            {
                Players.Remove(player);
            }
        }

    }
}