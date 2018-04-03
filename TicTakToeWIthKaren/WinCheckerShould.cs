using System.Collections.Generic;
using System.Linq;
using TicTakToeApp;
using Xunit;
using Xunit.Sdk;

namespace TicTakToeWIthKaren
{
    public class WinCheckerShould
    {
        
        
        [Fact]
        public void IdentifyAVerticalWin()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(1,2));
            moves.Add(new Move(2,2));
            moves.Add(new Move(1,1));
            moves.Add(new Move(1,3));

            var didUserWin = winChecker.CheckForWin(moves);
            Assert.True(didUserWin);
        }

        [Fact]
        public void IndentifyAHorizontalWin()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,2));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,3));
            moves.Add(new Move(3,3));

            var didUserWin = winChecker.CheckForWin(moves);
            Assert.True(didUserWin);
        }

        [Fact]
        public void IndentifyAUserDidntWin()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,2));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,3));
            moves.Add(new Move(3,2));

            var didUserWin = winChecker.CheckForWin(moves);
            Assert.False(didUserWin);
        }

        [Fact]
        public void IdentifyADiagonalWinFromLeftTop()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,2));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,1));
            moves.Add(new Move(3,3));

            var didUserWin = winChecker.CheckForWin(moves);
            Assert.True(didUserWin); 
        }

        [Fact]
        public void IdentifyDiagonalStraightFromLeftTop()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,2));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,1));
            moves.Add(new Move(3,3));

            var diagonal3InARow = winChecker.CheckForWin(moves);
            Assert.True(diagonal3InARow);

        }
        
        [Fact]
        public void IdentifyNotADiagonalWin()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,1));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,1));
            moves.Add(new Move(3,3));

            var diagonal3InARow = winChecker.CheckForWin(moves);
            Assert.False(diagonal3InARow);

        }
        
        [Fact]
        public void IdentifyDiagonalStraightFromRightTop()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,2));
            moves.Add(new Move(2,3));
            moves.Add(new Move(1,3));
            moves.Add(new Move(3,1));

            bool diagonal3InARow = winChecker.CheckForWin(moves);
            Assert.True(diagonal3InARow);

        }

        [Fact]
        public void IndenifyThisRandomWin()
        {
            var moves = new List<Move>();
            var winChecker = new WinChecker();
            
            moves.Add(new Move(2,4));
            moves.Add(new Move(4,2));
            moves.Add(new Move(1,3));
            moves.Add(new Move(3,3));

            bool diagonal3InARow = winChecker.CheckForWin(moves);
            Assert.True(diagonal3InARow);
        }
    }
}