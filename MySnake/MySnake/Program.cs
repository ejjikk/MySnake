using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отрисовка рамки
            DrowFrame(); 
            // Отрисовка змейки
            var startPoint = new Point (3, 3, '☺');
            var snake = new Snake(startPoint, 4, Direction.RIGHT);
            snake.Draw();
            snake.HandleKey();
            Console.ReadLine();
        }
        static void DrowFrame()
        {
            var UpLine = new HorizontalLine(0, 78, 0, '-');
            var DownLine = new HorizontalLine(0, 78, 24, '-');
            var LeftLine = new VerticalLine(0, 0, 24, '|');
            var RightLine = new VerticalLine(78, 0, 24, '|');
            UpLine.Draw();
            DownLine.Draw();
            LeftLine.Draw();
            RightLine.Draw();
        }
    }
}
