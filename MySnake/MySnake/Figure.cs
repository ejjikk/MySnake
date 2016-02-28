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
        virtual public void Draw()
        {
            foreach (Point p in pList)
            {
                Console.ForegroundColor = (ConsoleColor)color;
                p.Draw();
            }
        }
        public int color = 15;

        public void Colorize()
        {
            Random randomColor = new Random();
            color = randomColor.Next(9, 15);
        }


        internal bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
