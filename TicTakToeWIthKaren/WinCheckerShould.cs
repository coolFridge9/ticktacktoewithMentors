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
            
            moveList.AddUserMove(new Move(1,2));
            moveList.AddUserMove(new Move(2,2));
            moveList.AddUserMove(new Move(1,1));
            moveList.AddUserMove(new Move(1,3));

            var result = winChecker.AddXCoordinatesIntoSortedList(moveList.UserMoveList);
            var expectedList = new List<int> {1,1,1,2};
            Assert.Equal(expectedList,result);
        }

        [Fact]
        public void IncrementCountIfSameElseReset()
        {
            var winChecker = new WinChecker();
            var currentCount = 1;
            var newCount = winChecker.GetCount(currentCount, 1, 1);
            var expected = 2;
            Assert.Equal(newCount,expected);
        }

        [Fact]
        public void CheckIfListContains3StraightInARow()
        {
            if (WinChecker.SizeOfBoard == 3)
            {
                var moveList = new MoveList();
                var winChecker = new WinChecker();
            
                moveList.AddUserMove(new Move(1,2));
                moveList.AddUserMove(new Move(2,2));
                moveList.AddUserMove(new Move(1,1));
                moveList.AddUserMove(new Move(1,3));

                var listOfX = winChecker.AddXCoordinatesIntoSortedList(moveList.UserMoveList);
                bool result = winChecker.ContainsStraightLine(listOfX);
                
                Assert.True(result);

            }
            
        }
        
        [Fact]
        public void IdentifyAVerticalWin()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddUserMove(new Move(1,2));
            moveList.AddUserMove(new Move(2,2));
            moveList.AddUserMove(new Move(1,1));
            moveList.AddUserMove(new Move(1,3));

            bool didUserWin = winChecker.CheckIfUserWon(moveList);
            Assert.True(didUserWin);
        }
    }
}