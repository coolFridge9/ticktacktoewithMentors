using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TicTakToeApp;
using Xunit;

namespace TicTakToeWIthKaren
{
    public class MoveShould
    {

        [Fact]
        public void ReturnInitialisedCoordinates()
        {
            var move = new Move(2, 2);
            Assert.Equal(2, move.X);
            Assert.Equal(2, move.Y);
        }
    }
    public class MoveListShould
    {

        [Fact]
        public void AddAMoveToUserMoveList()
        {
            var move = new Move(2,2);
            var moveList = new MoveList();
            moveList.AddUserMove(move);
        }
     

        [Fact]
        public void AddAMoveToComputerMoveList()
        {
            var move = new Move(1, 1);
            var moveList = new MoveList();
            moveList.AddComputerMove(move);
        }
        
        [Fact]
        public void HaveTheAddedMovesInTheCorrectList()
        {
            var moveList = new MoveList();
            moveList.AddComputerMove(new Move(1,1));
            moveList.AddComputerMove(new Move(2,2));
            moveList.AddUserMove(new Move(1,2));
            moveList.AddComputerMove(new Move(2,3));
            moveList.AddUserMove(new Move(3,3));

            var expectedCompMovesList = new List<Move> 
                {new Move(1, 1), new Move(2, 2), new Move(2, 3)};

            var expectedUserMovesList = new List<Move> 
                {new Move(1, 2), new Move(3, 3)};

            for (var i = 0; i < expectedCompMovesList.Count; i++)
            {
                Assert.Equal(expectedCompMovesList[i].X,moveList.ComputerMoveList[i].X);
                Assert.Equal(expectedCompMovesList[i].Y,moveList.ComputerMoveList[i].Y);
            }
            for (var i = 0; i < expectedUserMovesList.Count; i++)
            {
                Assert.Equal(expectedUserMovesList[i].X,moveList.UserMoveList[i].X);
                Assert.Equal(expectedUserMovesList[i].Y,moveList.UserMoveList[i].Y);
            }
            
        }
    }

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
            if (MoveList.SizeOfBoard == 3)
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
        }
    }
}