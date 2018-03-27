namespace TicTakToeApp
{
    public class Player
    {
        public MoveList MoveList= new MoveList();
        public static char Symbol;
        
        
        public Player(char c)
        {
            Symbol = c;
        }
    }
}