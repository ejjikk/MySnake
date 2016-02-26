using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class FoodCreator
    {
        int mapWeight;
        int mapHeight;
        char sym;

        Random random = new Random();
 
        public FoodCreator(int mapWidth, int mapLenght, char sym)
        {
            this.mapWeight = mapWidth;
            this.mapHeight = mapLenght;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWeight - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
