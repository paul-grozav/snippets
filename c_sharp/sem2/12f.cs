using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] v = new int[100];
        static int value;

        static int dei(int s, int d)
        {
            if (d == s)
            {
                if (v[s] == value) return 1; 
                else return 0;
            }
            else if (d - s == 1)
            {
                if ((v[s] == value) && (v[d] == value)) return 2;
                else if ((v[s] != value) && (v[d] != value)) return 0;
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
            Console.Write("Ce valoare sa caut?"); value = int.Parse(Console.ReadLine());

            Console.Write("Numarul de aparitii a valorii "+value+" in vector este "+dei(1, n));
            Console.ReadLine();
        }
    }
}