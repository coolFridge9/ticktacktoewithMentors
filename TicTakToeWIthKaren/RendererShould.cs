using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class RendererShould
    {
 /*       [Fact]
        public void PutTheBoardIntoPrintableString()
        {
            var board = new Board();
            var boardViewer = new Renderer();
            var players = new List<Player>();
            var player1 = new Player('x',new HumanMover());
            var player2 = new Player('o',new HumanMover());
            
            player1.AddMove(new Move(1,1));
            player2.AddMove(new Move(-1,1));
            player1.AddMove(new Move(1,2));
            player2.AddMove(new Move(-1,-1));
            player1.AddMove(new Move(1,3));
            player2.AddMove(new Move(0,0));

            var expected = "  " +
                           "-2-1 0 1 2\n" +
                           "-2. . . . .\n" +
                           "-1 . o . o .\n" +
                           " 0 . . o . .\n" +
                           " 1 . . . x x\n" +
                           " 2 . . . . .";
            
            var result = boardViewer.ConfigureBoard(players,board);
            Assert.Equal(expected, result);
        }
*/

    }

    public class Renderer
    {
        private const int LengthFromBoardCentreToOutside = 2;
        private const int SizeOfBoard = LengthFromBoardCentreToOutside * 2 + 1;

        public string ConfigureBoard(List<Player> players, Board board)
        {

            var displayCentre = board.GetMostRecentMove();
            var xMin = displayCentre.X - LengthFromBoardCentreToOutside;
            var xMax = displayCentre.X + LengthFromBoardCentreToOutside;
            var yMax = displayCentre.Y + LengthFromBoardCentreToOutside;
            var yMin = displayCentre.Y - LengthFromBoardCentreToOutside;

            return RenderBoard(xMax, xMin, yMax, yMin, players);
        }

        private string RenderBoard(int xMax, int xMin, int yMax, int yMin, List<Player> players)
        {
            //var boardArray = 
            var boardString = "";
            boardString += FixTopRow(yMin, yMax)+"\n";
            boardString += FixRestOfBoard(xMin, xMax, players);
            return boardString;
        }

        private string FixRestOfBoard(int xMin, int xMax, List<Player> players)
        {
            var boardString = "";
            for (var i = xMin; i <= xMax; i++)
            {
                if (i >= 0)
                    boardString += " " + i;
                else
                {
                    boardString += "" + i;
                }
                
                for (var j = 0; j<= SizeOfBoard; j++)
                {
                    // need to create a 2d array so can loop through here


                    foreach (var player in players)
                    {
                        
                    }
                    //continue line here
                }

                boardString += "\n";
            }

            //return boardString;
        }

        private string FixTopRow(int yMin, int yMax)
        {
            var topRow = "";
            for (var i = yMin; i <= yMax; i++)
            {
                if (i >= 0)
                    topRow += " " + i;
                else
                {
                    topRow += "" + i;
                }
            }

            return topRow;
        }
    }
}