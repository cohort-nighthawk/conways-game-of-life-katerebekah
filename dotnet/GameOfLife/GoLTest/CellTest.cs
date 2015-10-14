using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoLTest
{
    [TestClass]
    public class CellTest
    {
        //Any live cell with fewer than two live neighbours dies, as if caused by under-population.

        [TestMethod]
        public void CellDiesWithUnderPopulation()
        {
            
        }

        //Any live cell with two or three live neighbours lives on to the next generation.

        [TestMethod]
        public void CellWith2or3NeighborsLives()
        {

        }

        //Any live cell with more than three live neighbours dies, as if by overcrowding.

        [TestMethod]
        public void CellDiesWithOverPopulation()
        {

        }

        //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

        [TestMethod]
        public void CellReproducesWith3Neighbors()
        {

        }
    }
}
