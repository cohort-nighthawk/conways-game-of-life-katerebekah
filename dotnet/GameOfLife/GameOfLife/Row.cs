using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Row
    {
        public List<Cell> GridRow;
        public int RowNumber;
        public int NumberOfColumns()
        {
            return GridRow.Count();
        }
        public Row( int columns, int rowNumber)
        {
            this.RowNumber = rowNumber;
            for (var i = 1; i < columns+1; i++)
            {
                GridRow.Add(new Cell(rowNumber, i));
            }
        }
    }
}
