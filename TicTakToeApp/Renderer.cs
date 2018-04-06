using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToeApp
{
    public class Renderer
    {
        private int LengthOfBoard = 3;
        private int WidthOfBoard = 3;

        public string RenderBoard(List<Player> players)
        {
            var boardString = "";
            UpdateBoardDimentions(players);
            var board = new char[LengthOfBoard,WidthOfBoard];
            board = Initialise(board);

            foreach (var player in players)
            {
                foreach (var move in player.Moves)
                {
                    if(move.X>0 && move.X<=LengthOfBoard && move.Y>0 && move.Y<= WidthOfBoard)
                        board[move.X - 1, move.Y - 1] = player.Symbol;   
                }      
            }

            for (var i = 0; i < LengthOfBoard; i++)
            {
                for (var j = 0; j < WidthOfBoard; j++)
                {
                    boardString += board[i, j];
                }
                boardString += '\n';
            }
            

            return boardString;
        }

        private void UpdateBoardDimentions(List<Player> players)
        {
            var maxX = LengthOfBoard;
            var maxY = WidthOfBoard;
            foreach (var player in players)
            {
                if (player.Moves.Any())
                {
                    var latestMove = player.Moves[player.Moves.Count-1];
                    if (latestMove.X > LengthOfBoard)
                        LengthOfBoard = latestMove.X;
                    if (latestMove.Y> WidthOfBoard)
                        WidthOfBoard = latestMove.Y;
                }
            }
        }

        public void DisplayBoard(List<Player> players)
        {
            Console.WriteLine(RenderBoard(players));
        }

        private char[,] Initialise(char[,] board)
        {
            for (var i = 0; i < LengthOfBoard; i++)
            {
                for (var k = 0; k < WidthOfBoard; k++)
                {
                    board[i, k] = '.';
                }
            }

            return board;
        }
    }
}