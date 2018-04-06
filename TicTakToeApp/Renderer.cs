using System;
using System.Collections.Generic;

namespace TicTakToeApp
{
    public class Renderer
    {
        private const int LengthOfBoard = 3;

        public string RenderBoard(List<Player> players)
        {
            var boardString = "";
            var board = new char[3,3];
            board = Initialise(board);

            foreach (var player in players)
            {
                foreach (var move in player.Moves)
                {
                    if(move.X>0 && move.X<=LengthOfBoard && move.Y>0 && move.Y<= LengthOfBoard)
                        board[move.X - 1, move.Y - 1] = player.Symbol;   
                }      
            }

            for (var i = 0; i < LengthOfBoard; i++)
            {
                for (var j = 0; j < LengthOfBoard; j++)
                {
                    boardString += board[i, j];
                }
                boardString += '\n';
            }
            

            return boardString;
        }

        public void DisplayBoard(List<Player> players)
        {
            Console.WriteLine(RenderBoard(players));
        }

        private static char[,] Initialise(char[,] board)
        {
            for (var i = 0; i < LengthOfBoard; i++)
            {
                for (var k = 0; k < LengthOfBoard; k++)
                {
                    board[i, k] = '.';
                }
            }

            return board;
        }
    }
}