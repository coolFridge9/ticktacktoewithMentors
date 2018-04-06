using System;

namespace TicTakToeApp
{
    public class HumanMover : PlayerMove
    {
        
        private UserInputHandler inputHandler = new UserInputHandler();
        private  StringToMoveConverter converter = new StringToMoveConverter();

        public string GetMove(Board board)
        {
            while (true)
            {
                var moveString = inputHandler.GetInput();
                if (moveString == "q") 
                    return moveString;

                var move = converter.ConvertToMove(moveString);
                if (!board.IsSpaceTaken(move)) 
                    return moveString;
                else
                {
                    Console.WriteLine("This space is taken lol\n");
                }
            }
        }
    }
}