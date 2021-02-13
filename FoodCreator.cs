using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int Width, int Height, char sym) {
            this.mapWidth = Width;
            this.mapHeight = Height;
            this.sym = sym;
        }

        public Point CreateFood() {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight -2);
            return new Point(x,y,sym);
        }


        /*internal bool isCollision(Point point)
        {
            foreach (Point p in pList)
                if (point.isHit(p))
                    return true;
            return false;
        }


        public Point CreateFood(Snake snake)
        {
            Point food;

            do
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                food = new Point(x, y, sym);
            } while (snake.isCollision(food));
            return food;
        }*/

    }
}
