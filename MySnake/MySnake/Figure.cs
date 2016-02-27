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
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        protected int color = 15;

        public void Colorize()
        {
            Random randomColor = new Random();
            color = randomColor.Next(9, 15);
        }
    }
}
