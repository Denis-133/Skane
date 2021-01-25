 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        public string a;
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'*');
            p1.Draw();

            Point p2 = new Point(1, 2, '*');
            p2.Draw();


            HorizontalLine xline1 = new HorizontalLine(1,100,1,'+');
            xline1.Drow();

            HorizontalLine xline2 = new HorizontalLine(1, 100, 30, '+');
            xline2.Drow();

            VerticalLine yline1 = new VerticalLine(1, 30, 1, '+');
            yline1.Drow();

            VerticalLine yline2 = new VerticalLine(1, 30, 100, '+');
            yline2.Drow();

            Console.ReadLine();
        
        }
    }
}
