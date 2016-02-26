using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Figure
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
