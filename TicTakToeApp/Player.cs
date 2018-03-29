namespace TicTakToeApp
{
    public class Player
    {
        public MoveList Moves= new MoveList();
        public char Symbol;
        private bool IsAI;
        private UserInputHandler inputHandler = new UserInputHandler();
        private  StringToMoveConverter converter = new StringToMoveConverter();
        
        
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


        public string GetMove(Board board)
        {
            var move = !IsAI ? GetMoveFromUser(board) : GetMoveFromAI();

            return move;
        }

        private string GetMoveFromAI()
        {
            throw new System.NotImplementedException();
        }

        private string GetMoveFromUser(Board board)
        {
            while (true)
            {
                var moveString = inputHandler.GetInput();
                if (moveString == "q") return moveString;
                
                var move = converter.ConvertToMove(moveString);
                if (!board.IsSpaceTaken(move)) return moveString;
            }

        }
    }
}