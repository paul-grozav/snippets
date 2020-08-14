﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] a = new int[100,100];
        static int n, m, p, q;

        static void interschimba(int indice)
        {
            a[p, indice] += a[q, indice];
            a[q, indice] = a[p, indice] - a[q, indice];
            a[p, indice] -= a[q, indice];
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
            Console.Write("n="); int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Se vor schimba intre ele linile p si q");
            Console.Write("p="); p = int.Parse(Console.ReadLine());
            Console.Write("q="); q = int.Parse(Console.ReadLine());

            dei(1, n);//schimba toate coloanele de la liniile p,q

            Console.WriteLine("Matricea obtinuta este:");
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