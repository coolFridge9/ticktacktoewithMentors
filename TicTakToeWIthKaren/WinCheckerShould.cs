using System.Collections.Generic;
using TicTakToeApp;
using Xunit;

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
            if (WinChecker.SizeOfBoard == 3)
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
    }
}