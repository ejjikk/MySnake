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
            bool end = true;
            while (true)
            {
                // Запуск игры
                StartGame();
                // Конец игры
                EndGame(out end);
                if (end)
                    break;
            }
        }

        private static void EndGame(out bool end)
        {
            Random randomColor = new Random();
            var color = randomColor.Next(9, 15);
            Console.ForegroundColor = (ConsoleColor)color;
            
            Console.SetCursorPosition(25, 11);
            Console.Write("==============================");
            Console.SetCursorPosition(25, 12);
            Console.Write("======== Начать заново? ======");
            Console.SetCursorPosition(25, 13);
            Console.Write("==============================");
            Console.SetCursorPosition(25, 14);
            Console.Write("Да - Пробел/Space, Нет - Enter");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        end = true;
                        break;
                    }
                    else
                    { 
                        end = false; 
                        break; 
                    }
                }
            }
        }
        private static void StartGame()
        {
            Console.Clear();
            // Отрисовка рамки
            Walls walls = new Walls(80, 25);
            walls.Draw();
            // Отрисовка змейки
            var startPoint = new Point(3, 3, '☺');
            Snake snake = new Snake(startPoint, 34, Direction.RIGHT);
            snake.Colorize();
            snake.Draw();
            // Отрисовка еды
            var foodCreator = new FoodCreator(80, 25, 'A');
            var food = new Point();
            do {
                food = foodCreator.CreateFood();
            } while (snake.IsHit(food));
            food.Draw(); 
            
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    do
                    {
                        food = foodCreator.CreateFood();
                    } while (snake.IsHit(food));
                    food.Draw();
                }
                else
                    snake.Move();
                Thread.Sleep(80);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
            }
        
        }

    }
}
