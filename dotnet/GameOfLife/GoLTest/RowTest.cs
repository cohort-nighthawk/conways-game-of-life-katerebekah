using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GoLTest
{
    [TestClass]
    public class RowTest
    {
        [TestMethod]
        public void NumberofColumnsEqualsNumberofCells()
        {
            var r = new Row(4, 7);
            Assert.AreEqual(4, r.NumberOfColumns());
        }
    }
}
