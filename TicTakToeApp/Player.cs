using System;
using System.Collections.Generic;

namespace TicTakToeApp
{
    public class Player 
    {
        public List<Move> Moves= new List<Move>();
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
            Moves.Add(move);
        }

        public bool DidWin()
        {
            var winChecker = new WinChecker();
            return winChecker.CheckForWin(Moves);
        }


        public string GetMove(Board board)
        {
            throw new NotImplementedException();
        }

    }
}