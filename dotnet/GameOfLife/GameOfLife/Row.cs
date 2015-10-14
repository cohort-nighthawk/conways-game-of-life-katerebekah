using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Row
    {
        public List<Cell> GridRow;
        public int RowNumber;
        public Row( int columns, int rowNumber)
        {
            this.RowNumber = rowNumber;
            for (var i = 0; i < columns; i++)
            {
                GridRow.Add(new Cell(rowNumber, i));
            }
        }
    }
}
