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
        public void seperatesInToDictionaryByXValue()
        {
            var moveList = new MoveList();
            var winChecker = new WinChecker();
            
            moveList.AddMove(new Move(2,2));
            moveList.AddMove(new Move(2,3));
            moveList.AddMove(new Move(1,1));
            moveList.AddMove(new Move(3,3));

            var seperatedCoordinates = winChecker.MakeXValuesKeys(moveList);
            var expectedDictionary = new Dictionary<int, List<Move>>
            {
                {1, new List<Move> {new Move(1, 1)}},
                {2, new List<Move> {new Move(2,2),new Move(2,3)}},
                {3, new List<Move> {new Move(3,3)}}
            };
            
            //Assert.Equal(expectedDictionary,seperatedCoordinates);
            Assert.True(CompareDictionarys(expectedDictionary,seperatedCoordinates));
            

        }

        private bool CompareDictionarys(Dictionary<int, List<Move>> expected, Dictionary<int, List<Move>>result)
        {
            var remainderDictionary = result.Where(entry => expected[entry.Key] != entry.Value)
                .ToDictionary(entry => entry.Key, entry => entry.Value);

            return (remainderDictionary.Count == 0);
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

            var count = 0;
            var seperatedCoordinates = winChecker.MakeXValuesKeys(moveList);
            var diagonal3InARow = winChecker.CheckForDiagonalWin(count, seperatedCoordinates,
                moveList.Moves,moveList.Moves[0]);
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

            var count = 0;
            var seperatedCoordinates = winChecker.MakeXValuesKeys(moveList);
            var diagonal3InARow = winChecker.CheckForDiagonalWin(count, seperatedCoordinates,
                moveList.Moves,moveList.Moves[0]);
            Assert.False(diagonal3InARow);

        }
    }
}