using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {
        static int CifreInB2(int x)
        {
            int nr = 0;
            while (x > 1)
            {
                if (x % 2 == 1) nr++;
                x /= 2;
            }
            nr++;
            return nr;
        }
        static void Main(string[] args)
        {
            int n, m, i, j;
            int[,] a = new int[20, 20];

            //citim matricea
            Console.Write("Numarul de linii=");
            n = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane=");
            m = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                {
                    Console.Write("a["+i+","+j+"]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }


            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    if (CifreInB2(a[i, j]) >= 2)//daca un element scris in baza 2 are mai nr de cifre >= 2
                    {
                        //stergem linia curenta
                        for (int k = i + 1; k < n; k++)
                            for (int l = 0; l < m; l++)
                                a[k - 1, l] = a[k, l];
                        n--;//scadem numarul de linii

                        //stergem coloana curenta
                        for (int k = j + 1; k < m; k++)
                            for (int l = 0; l < n; l++)
                                a[l, k - 1] = a[l, k];
                        m--;//scadem numarul de coloane

                        j = 0;//si cautam de la coloana 0 si aceeasi linie(care defapt e urmatoarea mutata mai sus)
                    }

            //afisam noua matrice
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}