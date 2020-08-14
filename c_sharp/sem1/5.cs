using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.Write("x=");
            x = float.Parse(Console.ReadLine());

            if (x < -1)
                y = x;
            else if (x < 5)
                y = 2 * x - 5;
            else
                y = x * x;

            Console.Write("f(" + x + ")=" + y);
            Console.ReadLine();

        }
    }
}