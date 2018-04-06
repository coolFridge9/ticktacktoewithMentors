using System;

namespace TicTakToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //maybe make a set up class for this stuff
            
            var game = new GameEngine();
            game.AddNewPlayer(new Player('X',new HumanMover()));
            game.AddNewPlayer(new Player('O',new HumanMover()));
            //game.AddNewPlayer(new Player('A',new AIMover()));
            game.RunGame();
        }
    }
}