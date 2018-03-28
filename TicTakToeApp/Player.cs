namespace TicTakToeApp
{
    public class Player
    {
        public MoveList Moves= new MoveList();
        public static char Symbol;
        
        
        public Player(char c)
        {
            Symbol = c;
        }

        public void AddMove(Move move)
        {
            Moves.AddMove(move);
        }

        public bool DidWin()
        {
            var winChecker = new WinChecker();
            return winChecker.CheckForWin(Moves);
        }
    }
}