 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            Console.CursorVisible = false;

            /* Полиморфизм!!!! 
             * тут я отрисовываю вертикальную линию как фигуру, используя другой метод, который
             * вызывает базовый метод отрисовки фигуры
             * 
             *
             */
            /*VerticalLine vl1 = new VerticalLine(0, 10, 5, '%');
            Draw(vl1);*/

            /*static void Draw(Figure figure) {
                figure.Drow();
            }*/

            //Point pf = new Point(4,5,'^');
            //Здесь я рассматриваю змейку исключительно как фигуру, мне не доступны методы из класса Snake.
            //Figure fSnake = new Snake(pf,5,Direction.RIGHT);
            //Draw(fSnake);
            //Здесь я использую явное приведение типа и говорю, что snake - это экзмепляр класса Snake, а не фигуры
            //Snake snake1 = (Snake)fSnake;
            //После этого для моей snake будут доступны методы из класса Snake
            //snake.Move();

            /*
            HorizontalLine h1 = new HorizontalLine(0, 5, 6 , '&');
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl1);
            figures.Add(h1);
            foreach (var f in figures) {
                f.Drow();
            }*/

            Walls walls = new Walls(80,25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

        }
    }
}
