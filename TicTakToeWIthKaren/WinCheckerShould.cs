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
        public void PutXCoordinatesIntoASortedIntegerList()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(1,2));
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(1,3));

            var result = winChecker.AddXCoordinatesIntoSortedList(moveList.Moves);
            var expectedList = new List<int> {1,1,1,2};
            Assert.Equal(expectedList,result);
        }

        [Fact]
        public void IncrementCountIfSameElseReset()
        {
            const int currentCount = 1;
            const int expected = 2;
            var winChecker = new WinChecker();
            
            var newCount = winChecker.GetCount(currentCount, 1, 1);

            Assert.Equal(newCount,expected);
        }

        [Fact]
        public void CheckIfListContains3StraightInARow()
        {
            
            var moveList = new MoveList();
            var winChecker = new WinChecker();
        
            moveList.AddMove(new Move(1,2));
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(1,3));

            var listOfX = winChecker.AddXCoordinatesIntoSortedList(moveList.Moves);
            var result = winChecker.ContainsStraightLine(listOfX);
            
            Assert.True(result);
  
        }
        
        [Fact]
        public void IdentifyAVerticalWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(1,2));
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(1,3));

            var didUserWin = winChecker.CheckForWin(moveList);
            Assert.True(didUserWin);
        }

        [Fact]
        public void IndentifyAHorizontalWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,3));
            moveList.AddMove(new Move(3,3));

            var didUserWin = winChecker.CheckForWin(moveList);
            Assert.True(didUserWin);
        }

        [Fact]
        public void IndentifyAUserDidntWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,3));
            moveList.AddMove(new Move(3,2));

            var didUserWin = winChecker.CheckForWin(moveList);
            Assert.False(didUserWin);
        }

        [Fact]
        public void IdentifyADiagonalWinFromLeftTop()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(3,3));

            var didUserWin = winChecker.CheckForWin(moveList);
            Assert.True(didUserWin); 
        }

        [Fact]
        public void IdentifyDiagonalStraightFromLeftTop()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(3,3));

            var diagonal3InARow = winChecker.CheckForDiagonalWin(moveList.Moves);
            Assert.True(diagonal3InARow);

        }
        
        [Fact]
        public void IdentifyNotADiagonalWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,1));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(3,3));

            var diagonal3InARow = winChecker.CheckForDiagonalWin(moveList.Moves);
            Assert.False(diagonal3InARow);

        }
        
        [Fact]
        public void IdentifyDiagonalStraightFromRightTop()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,3));
            moveList.AddMove(new Move(3,1));

            bool diagonal3InARow = winChecker.CheckForDiagonalWin(moveList.Moves);
            Assert.True(diagonal3InARow);

        }

        [Fact]
        public void IndenifyThisRandomWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,4));
            moveList.AddMove(new Move(4,2));
            moveList.AddMove(new Move(1,3));
            moveList.AddMove(new Move(3,3));

            bool diagonal3InARow = winChecker.CheckForDiagonalWin(moveList.Moves);
            Assert.True(diagonal3InARow);
        }
    }
}