using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    class Program
    {
        static int m, n, o;
        static int[,] a = new int[20, 20];
        static int[,] b = new int[20, 20];
 
        static void Citire(int[,] x)
        {
            int i, j;
            for (i = 1; i <= m; i++)
                for (j = 1; j <= n; j++)
                {
                    Console.Write("element["+i+","+j+"]=");
                    x[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Afisare(int[,] x)
        {
            int i, j;
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                    Console.Write(x[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int i, j;
            Console.Write("Cate linii are matricea?");
            m = int.Parse(Console.ReadLine());
            Console.Write("Cate coloane are matricea?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Citesc elementele matricii A");
            Citire(a);
            Console.WriteLine("Citesc elementele matricii B");
            Citire(b);
            for (i = 1; i <= m; i++)
                if (a[i, 1] == b[i, 1] && a[i, 2] == b[i, 2])
                    for (j = 1; j <= n; j++)
                    {
                        o = a[i, j];
                        a[i, j] = b[i, j];
                        b[i, j] = o;
                    }
            Afisare(a);
            Afisare(b);
            Console.ReadLine();
        }
    }
}