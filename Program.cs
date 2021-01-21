 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,2,'*');
            Point p2 = new Point(5,5,'*');
            Point p3 = new Point(5, 6, '#');
            Point p4 = new Point(5, 7, '@');

            p1.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            /*for (int i=0; i<numList.Count; i++) {
                Console.WriteLine(i);
            }*/
            foreach (int i in numList) {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);
        
            List <char> Sym = new List<char>() { '*', '*', '#', '*'};
            foreach (char i in Sym)
            {
                Console.WriteLine(i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
