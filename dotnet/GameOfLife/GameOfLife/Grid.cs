﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Grid
    {
        List<Row> World = new List<Row>{ };
        public int NumberofRows()
        {
            return World.Count();
        }
        public Grid (int columns, int rows)
        {

            for (int i = 1; i < rows+1; i++)
            {
                World.Add(new Row(columns, i));
            }
        }
    }
}
