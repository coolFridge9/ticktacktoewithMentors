using System.Collections.Generic;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class RendererShould
    {
        [Fact]
        public void PutAllPlayersInto2DArray()
        {
            var board = new Board();
            var boardViewer = new Renderer();
            var players = new List<Player>();
            boardViewer.ConfigureBoard(players,board);
        }

        [Fact]
        public void GetXAxisMax()
        {
            var board = new Board();
            board.AddMove(new Move(-5, 1));
            board.AddMove(new Move(1, 1));
            board.AddMove(new Move(3, 2));
            
            var boardViewer = new Renderer();
            var xMax = boardViewer.getXAxixMax();
        }

    }

    public class Renderer
    {
        public void ConfigureBoard(List<Player> players, Board board)
        {
            
            throw new System.NotImplementedException();
        }

        public object getXAxixMax()
        {
            throw new System.NotImplementedException();
        }
    }
}