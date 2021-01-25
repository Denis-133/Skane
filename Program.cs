 
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
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            Point p1 = new Point(2,7,'*');
            p1.Draw();
            Point p2 = new Point(1, 2, '*');


            HorizontalLine xline1 = new HorizontalLine(1,80,1,'+');
            xline1.Drow();

            HorizontalLine xline2 = new HorizontalLine(1, 80, 25, '+');
            xline2.Drow();

            VerticalLine yline1 = new VerticalLine(1, 25, 1, '+');
            yline1.Drow();

            VerticalLine yline2 = new VerticalLine(1, 25, 80, '+');
            yline2.Drow();

            Console.ReadLine();
        
        }
    }
}
