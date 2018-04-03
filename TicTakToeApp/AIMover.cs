namespace TicTakToeApp
{
    public class AIMover : PlayerMove
    {
        public string GetMove(Board board)
        {
            var move = new AI();
            return move.ChooseMove(board);
        }
    }
}