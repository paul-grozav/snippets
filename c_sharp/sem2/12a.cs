using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int dei(int s, int d)
        {
            if (d == s) return s;
            else if (d - s == 1) return s * d;
            else return (dei(s, (s+d)/2) * dei((s+d)/2+1, d));
        }

        static void Main(string[] args)
        {
            Console.Write("n="); int n = int.Parse(Console.ReadLine());
            Console.Write(dei(2, n));
            Console.ReadLine();
        }
    }
}