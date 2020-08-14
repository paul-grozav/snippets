using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] a = new int[100,100];
        static int n, p, q;

        static void interschimba(int indice)
        {
            if (indice == n + 1 - indice) return;
            //a[p,q] <-> a[p, n+1-q]
            a[indice, indice] += a[indice, n+1-indice];
            a[indice, n+1-indice] = a[indice, indice] - a[indice, n+1-indice];
            a[indice, indice] -= a[indice, n+1-indice];
        }

        static void dei(int s, int d)
        {
            if (d == s)
                interschimba(s);
            else
            {
                dei(s, (s + d) / 2);
                dei((s + d) / 2 + 1, d);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            dei(1, n);//schimba la toate linile

            Console.WriteLine("Matricea obtinuta in urma schimbarii diagonalei principale cu diagonala secundara este:");
            //afisarea matricii
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    Console.Write(a[i,j]+"\t");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}