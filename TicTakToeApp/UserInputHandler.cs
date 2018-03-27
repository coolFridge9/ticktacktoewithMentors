using System;
using System.Text.RegularExpressions;

namespace TicTakToeApp
{
    public class UserInputHandler
    {
        public string getInput()
        {
            Console.Write("press q to quit or enter move x,y: ");
            var input = Console.ReadLine();
            return input;
        }


        public bool Validate(string input)
        {
            Regex format = new Regex("^q$|^-?[0-9],-?[0-9]$");
            return format.IsMatch(input);
        }
    }
}