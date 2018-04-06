using System;

namespace TicTakToeApp
{
    public class EndOfGameMessage
    {
        public void WinMessage(Player player)
        {
            var message = "player " + player.Symbol + " has won the game.";
            Console.WriteLine(message);
        }

        public void QuitMessage(Player player)
        {
            var message = "\n"+player.Symbol+" quit the game\n" +
                          "Good bye player " + player.Symbol + "! Hope to see you again soon.";
            Console.WriteLine(message);
        }
    }
}