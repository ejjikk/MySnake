using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class FoodCreator
    {
        private int mapWeight;
        int mapHeight;
        char sym;

        Random random = new Random();
 
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWeight = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWeight - 2);
            int y = random.Next(2, mapHeight - 2);
            var randomFood = new Random();
            char sym = (char)(int)randomFood.Next(65, 90); 
            return new Point(x, y, sym);
        }
    }
}
