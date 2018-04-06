using System;

namespace TicTakToeApp
{
    public class AIMover : PlayerMove
    {
        public string GetMove(Board board)
        {
            Console.WriteLine("Computer's Turn:");
            var move = new AI();
            return move.ChooseMove(board);
        }
    }
}