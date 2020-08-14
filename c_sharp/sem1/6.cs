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
            int a, b;

            do
            {
                Console.Write("a=");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.Write("b=");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);

            while (a != b)
                if (a > b)
                    a -= b;
                else
                    b -= a;

            Console.Write("cmmdc=" + a);
            Console.ReadLine();

        }
    }
}