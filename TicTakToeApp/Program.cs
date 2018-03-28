using System;

namespace TicTakToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //maybe make a set up class for this stuff
            
            var game = new GameEngine();
            game.CreatePlayer(new Player('X'));
            game.RunGame();
        }
    }
}