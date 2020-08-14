using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            String t = Console.ReadLine();
            Console.WriteLine("k=");
            int n = int.Parse(Console.ReadLine());
            String[] v = t.Split(' ');
            for (int i = 0; i < v.Length; i++)
                if (v[i].Length == n)
                    Console.WriteLine(v[i]);
            Console.ReadLine();
        }
    }
}