using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GoLTest
{
    [TestClass]
    public class CellTest
    {
        //Any live cell with fewer than two live neighbours dies, as if caused by under-population.

        [TestMethod]
        public void CellDiesWithUnderPopulation()
        {
            var c = new Cell(1, 2);
            c.Neighbors = 1;
            Assert.AreEqual(false, c.IsAlive);
        }

        //Any live cell with two or three live neighbours lives on to the next generation.

        [TestMethod]
        public void CellWith2or3NeighborsLives()
        {
            var c = new Cell(1, 2);
            c.Neighbors = 2;
            Assert.AreEqual(true, c.IsAlive);
        }

        //Any live cell with more than three live neighbours dies, as if by overcrowding.

        [TestMethod]
        public void CellDiesWithOverPopulation()
        {
            var c = new Cell(1, 2);
            c.Neighbors = 4;
            Assert.AreEqual(false, c.IsAlive);
        }

        //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

        [TestMethod]
        public void CellReproducesWith3Neighbors()
        {
            var c = new Cell(1, 2);
            c.IsAlive = false;
            c.Neighbors = 3;
            Assert.AreEqual(true, c.IsAlive);
        }
    }
}
