 
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
            Point P1 = new Point(1,2,'*');
            P1.Draw();

            Point P2 = new Point(5,5,'!');
            P2.Draw();

            Console.ReadLine();
        
        }        
    }
}
