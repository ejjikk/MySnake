using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
=======
            Point p1 = new Point();
            p1.Draw(3, 4, '*');

            Console.ReadLine();
        }

        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
>>>>>>> Stashed changes
        }
    }
}
