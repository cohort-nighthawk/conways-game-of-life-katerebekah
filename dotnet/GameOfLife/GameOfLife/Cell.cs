using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public Cell (int x, int y)
        {
            this.row = x;
            this.column = y;
        }

        public bool IsAlive { get; set; }

        private int neighbors;
        public int Neighbors
        {
            get { return neighbors; }
            set
            {
                if (value > 3 || value < 2)
                {
                    IsAlive = false;
                }
                else
                {
                    IsAlive = true;
                }

                neighbors = value;
            }
        }
        public int row { get; set; }

        public int column { get; set; }

    }
}
