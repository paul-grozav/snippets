using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int factorial(int s, int d)
        {
            if (d == s) return s;
            else if (d - s == 1) return s * d;
            else return (factorial(s, (s + d) / 2) * factorial((s + d) / 2 + 1, d));
        }

        static int suma(int s, int d)
        {
            if (d == s) return factorial(1,s);
            else if (d - s == 1) return factorial(1, s) + factorial(1, d);
            else return (suma(s, (s + d) / 2) + suma((s + d) / 2 + 1, d));
        }

        static void Main(string[] args)
        {
            Console.Write("n="); int n = int.Parse(Console.ReadLine());
            Console.Write(suma(1, n));
            Console.ReadLine();
        }
    }
}