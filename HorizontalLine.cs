using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym) {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++) {
                Point p = new Point(x,y,sym);
                pList.Add(p);
            }
        }

        public override void Drow()
        {
            //До отрисовки меняем цвет на зеленый
            Console.ForegroundColor = ConsoleColor.Green;

            //Тут мы указываем, что можно взять реализацию метода из родителя.
            //По аналогии с parent::FunctionName(); в php 
            base.Drow();
            //После отрисовки меняем цвет на белый
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
