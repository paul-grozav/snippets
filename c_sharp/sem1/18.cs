using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            a[0, 0] = 1;
            a[0, 1] = 1;

            //completare linia 1
            for (i = 2; i < n; i++)
                a[0, i] = a[0, i - 1] + a[0, i - 2];

            //completez restul linilor 1 -> n
            for (i = 1; i < n; i++)
                for (j = 0; j < n; j++)
                {
                    if (j == 0) a[i, j] = a[i - 1, n - 1] + a[i - 1, n - 2];
                    else if (j == 1) a[i, j] = a[i - 1, n - 1] + a[i, 0];//j-1 = 0 cand j-1
                    else a[i, j] = a[i, j - 1] + a[i, j - 2];

                }

            //afisarea matricii
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}