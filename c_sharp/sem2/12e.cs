using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] v = new int[100];

        static int pozitive(int s, int d)
        {
            if (d == s)
            {
                if (v[s] < 0) return 0; 
                //0 e considerat pozitiv
                else return 1;
            }
            else if (d - s == 1)
            {
                if ((v[s] < 0) && (v[d] < 0)) return 0;
                else if ((v[s] >= 0) && (v[d] >= 0)) return 1;
                else return -1;
            }
            else
            {
                if ((pozitive(s, (s + d) / 2) == 0) && (pozitive((s + d) / 2 + 1, d) == 0)) return 0;
                else if ((pozitive(s, (s + d) / 2) == 1) && (pozitive((s + d) / 2 + 1, d) == 1)) return 1;
                else return -1;
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

            if (pozitive(1, n) == -1) Console.Write("Vectorul contine si elemente pozitive si elemente negative");
            if (pozitive(1, n) == 0) Console.Write("Vectorul contine doar elemente negative");
            if (pozitive(1, n) == 1) Console.Write("Vectorul contine doar elemente pozitive");
            Console.ReadLine();
        }
    }
}