﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySnake
{
    class Snake : Figure
    {
        public Direction direction;
        public Snake (Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First(); // tooooh -> tail = t
            pList.Remove(tail);  // tooooh  -> ooooh 
            Point head = GetNextPoint(); // head = n
            pList.Add(head); // oooohn
            if (tail.x < 79)
                tail.Clear();
            else
                tail.Clear();
            Console.ForegroundColor = (ConsoleColor)color;
            head.Draw();
            Console.ForegroundColor = (ConsoleColor)15;
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow && direction != Direction.RIGHT && direction != Direction.LEFT)
                direction = Direction.RIGHT;
            else if (key.Key == ConsoleKey.LeftArrow && direction != Direction.LEFT && direction != Direction.RIGHT)
                direction = Direction.LEFT;
            else if (key.Key == ConsoleKey.UpArrow && direction != Direction.UP && direction != Direction.DOWN)
                direction = Direction.UP;
            else if (key.Key == ConsoleKey.DownArrow && direction != Direction.UP && direction != Direction.DOWN)
                direction = Direction.DOWN;

        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
