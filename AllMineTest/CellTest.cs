using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AllMine.Models;


namespace AllMineTest
{
    [TestFixture]
    public class CellTest
    {
        [Test]
        public void ToStringIsHit_Returns()
        {
            //arrange
            var Cell = new Cell()
            {
                IsRevealed = true
            };
            //act
            var output = Cell.ToString();

            //assert
            Assert.IsTrue(output == "O");
        }

        [Test]
        public void ToStringIsHitAndIsMine_Returns()
        {
            //arrange
            var Cell = new Cell()
            {
                IsRevealed = true,
                IsMine = true
            };
            //act
            var output = Cell.ToString();

            //assert
            Assert.IsTrue(output == "X");
        }

        [Test]
        public void ToStringIsNotHitAndIsMine_Returns()
        {
            //arrange
            var Cell = new Cell()
            {
                IsRevealed = false,
                IsMine = true
            };
            //act
            var output = Cell.ToString();

            //assert
            Assert.IsTrue(output == "?");
        }

        [Test]
        public void ToStringIsNotHitIsNotMine_Returns()
        {
            //arrange
            var Cell = new Cell()
            {
                IsRevealed = false,
                IsMine = false
            };
            //act
            var output = Cell.ToString();

            //assert
            Assert.IsTrue(output == "?");
        }
    }
}
