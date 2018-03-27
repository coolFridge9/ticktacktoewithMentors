using System;
using System.Text.RegularExpressions;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class UserInputHandlerShould
    {
        
        [Theory]
        //[InlineData("1,1")]
        //[InlineData("-3,2")]
        [InlineData("q")]
        public void ValidateCorrectInput(string input)
        {
            var inputHandler = new UserInputHandler();
            bool valid = inputHandler.Validate(input);
            Assert.True(valid);
        }
    }

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
            Regex format = new Regex("q");
            return format.IsMatch(input);
        }
    }
}