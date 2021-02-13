using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public virtual void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }


        //Проверяющий метод, имеет ли стенка пересечение по координатам с фигурой(змейка)
        //В цикле проходим по всем точкам змейки
        //В pList попадают все точки стены, которые попали из метода IsHit класса Walls
        //Далее точки стены в цикле передаются в метод IsHit, для проверки с точками змейки, при совпадении возвращает false
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }


        //Проверяющий метод для точек на столкновение двух точек(змейки и точек стены)
        //В переменную p попадают точки 
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
