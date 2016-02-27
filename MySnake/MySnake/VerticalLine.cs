﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                var p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
