using System;
using System.Text.RegularExpressions;

namespace TicTakToeApp
{
    public class UserInputHandler
    {
        public string GetInput()
        {
            Console.Write("press q to quit or enter move x,y: ");
            var input = Console.ReadLine();
            var validInput = Validation(input);
            return validInput;
        }

        public bool IsValid(string input)
        {
            Regex format = new Regex("^q$|^-?[0-9],-?[0-9]$");
            return format.IsMatch(input);
        }

        public bool DidQuit(string input)
        {
            return input == "q";
        }

        private string Validation(string input)
        {
            if (IsValid(input))
                return input;
            Console.WriteLine("invalid");
            input = GetInput();
            return input;
        }
    }
}