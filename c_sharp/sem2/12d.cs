using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] v = new int[100];

        static int dei(int s, int d)
        {
            if (d == s)
            {
                if (v[s] % 2 == 0) return 1; 
                else return 0;
            }
            else if (d - s == 1)
            {
                if ((v[s] % 2 == 0) && (v[d] % 2 == 0)) return 2;
                else if ((v[s] % 2 == 1) && (v[d] % 2 == 1)) return 0;
                else return 1;
            }
            else
            {
                return (dei(s, (s + d) / 2) + dei((s + d) / 2 + 1, d));
            }
        }

        static void Main(string[] args)
        {
            Console.Write("numarul de numere="); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("v[" + i + "]=");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Numarul de elemente pare din vector este "+dei(1, n));
            Console.ReadLine();
        }
    }
}