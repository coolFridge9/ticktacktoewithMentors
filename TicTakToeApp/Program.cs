using System;

namespace TicTakToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new UserInputHandler();
            var a = input.GetInput();
        }
    }
}