using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Grid
    {
        List<Row> World;
        public Grid (int columns, int rows)
        {

            for (var i = 0; i < rows; i++)
            {
                World.Add(new Row(columns, i));
            }
        }
    }
}
