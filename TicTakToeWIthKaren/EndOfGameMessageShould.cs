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
            var player = new Player('X',new HumanMover());
            message.WinMessage(player);
        }
        [Fact]
        public void AcceptAPlayerAndQuitMessage()
        {
            var message = new EndOfGameMessage();
            var player = new Player('X',new HumanMover());
            message.QuitMessage(player);
        }
    }
}