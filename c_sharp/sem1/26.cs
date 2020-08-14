using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication31
{
    class Program
    {
        public static int m, n;
        public static int[,] a = new int[20, 20];
 
        static void Citire(int m, int n, int[,] a)
        {
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + "," + j + "]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Produs(int m, int n, int[,] a)
        {
            int p = 1, i, j;
            for (i = 1; i < m; i += 2)
            for (j = 0; j < n; j += 2)
            {
                if (a[i, j] > 0)
                p *= a[i, j];
            }
            Console.WriteLine("produsul elementelor pozitive aflate pe linii pare si coloane impare = " + p);
        }

        static void Suma(int m, int n, out int s, int[,] a)
        {
            int i, j, s1 = 0;
            for (i = 0; i < m; i++)
            for (j = 0; j < m; j++)
            if (a[i, j] > 0 && a[i, j] % 2 != 0)
            s1 += a[i, j];
            s = s1;
        }

        static void Numar(int m, int n, out int nrpoz, out int nrneg, out int nul, int[,] a)
        {
            int i, j, nrpoz1 = 0, nrneg1 = 0, nul1 = 0;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] > 0) nrpoz1++;
                    else if (a[i, j] < 0) nrneg1++;
                    else nul1++;
                }
            nrpoz = nrpoz1;
            nrneg = nrneg1;
            nul = nul1;
        }

        static void Elemente(int m, int n, int[,] a)
        {
            int i, j;
            for (i = 0; i < m; i += 2)
                for (j = 0; j < n; j++)
                    if (((j+1) % 3) == 0)
                        Console.Write(" " + a[i, j]);
        }

        static void Main(string[] args)
        {
            int s, nrpoz, nrneg, nul;
            Console.Write("Cate linii are matricea?");
            m = int.Parse(Console.ReadLine());
            Console.Write("Cate coloane are matricea?");
            n = int.Parse(Console.ReadLine());
            Citire(m, n, a);
            Produs(m, n, a);
            Suma(m, n, out s, a);
            Console.WriteLine("suma elementelor pozitive impare din matrice = " + s);
            Numar(m, n, out nrpoz, out nrneg, out nul, a);
            Console.WriteLine("numere pozitive=" + nrpoz);
            Console.WriteLine("numere negative=" + nrneg);
            Console.WriteLine("zerouri=" + nul);
            Console.Write("elementele aflate pe linii impare si coloane divizibile cu 3 =");
            Elemente(m, n, a);
            Console.ReadLine();
        }
    }
}