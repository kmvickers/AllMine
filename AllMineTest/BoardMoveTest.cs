using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AllMine.Models;
using AllMine.Builders;

namespace AllMineTest
{
    [TestFixture]
    class BoardMoveTest
    {
        private IBoardBuilder boardBuilder;
        private IBoard _board;

        public BoardMoveTest()
        {
            boardBuilder = new BoardBuilder();

            _board = boardBuilder.Build(8, 8, 5);
        }



        [Test]
        public void BoardExists()
        {
            Assert.IsTrue(_board != null);
        }

        [Test]
        public void BoardInitial()
        {
            //arrange
            var initialLocation = _board.CurrentLocation();

            TestContext.Out.WriteLine(initialLocation);
            //assert
            Assert.IsTrue(initialLocation.Row == 0);
        }

        public void MoveUp_CurrentLocationRowRemains()
        {
            //arrange
            var initialLocation = _board.CurrentLocation();

            //act
            _board.Move('u');
            var currentPosition = _board.CurrentLocation().Row;
            //assert
            Assert.IsTrue(currentPosition == initialLocation.Row);
        }
        [Test]
        public void MoveLeft_CurrentLocationColumnRemains()
        {
            //arrange
            var initialLocation = _board.CurrentLocation();

            //act
            _board.Move('l');
            var currentPosition = _board.CurrentLocation().Column;
            //assert
            Assert.IsTrue(currentPosition == initialLocation.Column);

        }


        [Test]
        public void MoveRight_CurrentColumnIncrease()
        {
            //arrange
            var initialLocation = _board.CurrentLocation();

            //act
            _board.Move('r');
            var currentPosition = _board.CurrentLocation().Column;
            //assert
            Assert.IsTrue(currentPosition == initialLocation.Column + 1);
        }

        [Test]
        public void MoveDown_CurrentLocationRowIncreases()
        {
            //arrange
            var initialLocation = _board.CurrentLocation();

            //act
            _board.Move('d');
            var currentPosition = _board.CurrentLocation().Row;
            //assert
            Assert.IsTrue(currentPosition == initialLocation.Row + 1);
        }
        
        
    }
}
