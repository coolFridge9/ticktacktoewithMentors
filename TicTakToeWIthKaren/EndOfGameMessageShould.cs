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
        
        
    }

    public class EndOfGameMessage
    {
        public void WinMessage(Player player)
        {
            var message = "player " + player.Symbol + " has won the game.";
            Console.WriteLine(message);
        }
    }
}