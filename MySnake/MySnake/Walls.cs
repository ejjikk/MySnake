using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            var UpLine = new HorizontalLine(0, mapWidth - 2, 0, 'o');
            var DownLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, 'o');
            var LeftLine = new VerticalLine(0, 0, mapHeight - 1, 'o');
            var RightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, 'o');

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(LeftLine);
            wallList.Add(RightLine);
        }

        public void Draw()
        {
            wallList.First().Colorize();
            int color = wallList.First().color; 
            foreach(var wall in wallList)
            {
                wall.color = color;
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
    }
}
