namespace TicTakToeApp
{
    public class Player
    {
        public MoveList Moves= new MoveList();
        public static char Symbol;
        private bool IsAI;
        
        
        public Player(char c,bool isAI= false)
        {
            Symbol = c;
            IsAI = isAI;
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


        public string GetMove()
        {
            var move = !IsAI ? GetMoveFromUser() : GetMoveFromAI();

            return move;
        }

        private string GetMoveFromAI()
        {
            throw new System.NotImplementedException();
        }

        private string GetMoveFromUser()
        {
            var inputHandler = new UserInputHandler();
            var move = inputHandler.GetInput();
            //needs validate space not taken
            return move;
        }
    }
}