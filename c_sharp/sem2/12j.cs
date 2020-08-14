using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int[,] a = new int[100,100];
        static int n, m, min = int.MaxValue, max = int.MinValue;

        static void interschimba(int linia)
        {
            for (int coloana = 1; coloana <= m; coloana++)
            {
                if (a[linia, coloana] > max) max = a[linia, coloana];
                if (a[linia, coloana] < min) min = a[linia, coloana];
            }
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
            //am putea lucra pe un vector cu n*m elemente
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write("m="); m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            dei(1, n);//calculeaza pe toate linile

            Console.WriteLine("minim:"+min+"\nmax:"+max);

            Console.ReadLine();
        }
    }
}