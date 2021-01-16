 
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
            Point P1 = new Point();
            P1.x = 1;
            P1.y = 3;
            P1.sym = '!';
            P1.Draw();
            //Draw(P1.x, P1.y, P1.sym);
            /*Draw(1,2,'+');
            Draw(1, 3, '-');*/
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym) {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        
    }
}
