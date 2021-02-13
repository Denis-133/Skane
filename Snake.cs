using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction) {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);//Почему нельзя просто присвоить так Point nextPoint = head;
            /*Point nextPoint = new Point(head); - создаем новую точку через конструктор класса Point для точек. 
             * А что если Point nextPoint = head; ? 
             * Что если просто присвоить следующей точке точку головы, я так понимаю это будет не верным решением,
             * так как мы по факту будем обращаться по ссылке к двум переменным ? 
             * То бищь, если применим метод Move к точке nextPoint мы изменим и точку head, 
             * так как фактически данные к точке будут храниться в одном стеке ?*/

            nextPoint.Move(1, direction);
            return nextPoint;

        }

        public void HandleKey(ConsoleKey key) {
            Direction last = direction;
            if (key == ConsoleKey.RightArrow && last != Direction.LEFT) {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.LeftArrow && last != Direction.RIGHT) {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.UpArrow && last != Direction.DOWN) {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow && last != Direction.UP) {
                direction = Direction.DOWN;
            }
        }

        internal bool Eat(Point food) {
            Point head = GetNextPoint();
            //Point head = this.pList.Last();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else {
            return false;
            }
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
