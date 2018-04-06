using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTakToeApp
{
    public class Renderer
    {
        private int BoardWidth = 3;
        private int BoardLength = 3;

        public string RenderBoard(List<Player> players)
        {
            var boardString = "";
            UpdateBoardDimentions(players);
            var board = new char[BoardWidth,BoardLength];
            board = Initialise(board);

            foreach (var player in players)
            {
                foreach (var move in player.Moves)
                    board[move.Y - 1, move.X - 1] = player.Symbol;         
            }

            for (var i = 0; i < BoardWidth; i++)
            {
                for (var j = 0; j < BoardLength; j++)
                {
                    boardString += board[i, j];
                }
                boardString += '\n';
            }
            

            return boardString;
        }

        private void UpdateBoardDimentions(List<Player> players)
        {
            var maxX = BoardWidth;
            var maxY = BoardLength;
            foreach (var player in players)
            {
                if (player.Moves.Any())
                {
                    var latestMove = player.Moves[player.Moves.Count-1];
                    if (latestMove.X > BoardLength)
                        BoardLength = latestMove.X;
                    if (latestMove.Y> BoardWidth)
                        BoardWidth = latestMove.Y;
                }
            }
        }

        public void DisplayBoard(List<Player> players)
        {
            Console.WriteLine(RenderBoard(players));
        }

        private char[,] Initialise(char[,] board)
        {
            for (var i = 0; i < BoardWidth; i++)
            {
                for (var k = 0; k < BoardLength; k++)
                {
                    board[i, k] = '.';
                }
            }

            return board;
        }
    }
}