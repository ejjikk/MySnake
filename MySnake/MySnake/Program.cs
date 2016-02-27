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
            Snake snake = new Snake(startPoint, 4, Direction.RIGHT);
            snake.Colorize();
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25, 'g');
            var food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
            }
            Console.ReadLine();
        }
        static void DrowFrame()
        {
            var UpLine = new HorizontalLine(0, 78, 0, '-');
            UpLine.Colorize();
            UpLine.Draw();
            var DownLine = new HorizontalLine(0, 78, 24, '-');
            DownLine.Colorize();
            DownLine.Draw();
            var LeftLine = new VerticalLine(0, 0, 24, '!');
            LeftLine.Draw();
            var RightLine = new VerticalLine(78, 0, 24, '!');
            RightLine.Draw();
        }
    }
}
