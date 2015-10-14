using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GoLTest
{
    [TestClass]
    public class GridTest
    {
        [TestMethod]
        public void InputEqualsNumberofRows()
        {
            var g = new Grid(7, 12);
            Assert.AreEqual(12, g.NumberofRows());
        }
    }
}
