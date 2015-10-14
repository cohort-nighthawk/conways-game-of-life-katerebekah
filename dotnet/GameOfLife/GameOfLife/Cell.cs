using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        public Cell (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsAlive { get; set; }

        public int neightbors { get; set; }

        public int x { get; set; }

        public int y { get; set; }

    }
}
