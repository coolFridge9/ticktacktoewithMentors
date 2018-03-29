using System;
using System.Security.Cryptography.X509Certificates;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class EndOfGameMessageShould
    {
        [Fact]
        public void AcceptAPlayerAndCreateWinMessage()
        {
            var message = new EndOfGameMessage();
            var player = new Player('X');
            message.WinMessage(player);
        }
        [Fact]
        public void AcceptAPlayerAndQuitMessage()
        {
            var message = new EndOfGameMessage();
            var player = new Player('X');
            message.QuitMessage(player);
        }
    }

    public class EndOfGameMessage
    {
        public void WinMessage(Player player)
        {
            var message = "player " + player.Symbol + " has won the game.";
            Console.WriteLine(message);
        }

        public void QuitMessage(Player player)
        {
            var message = "Good bye player " + player.Symbol + "! Hope to see you again soon.";
            Console.WriteLine(message);
        }
    }
}