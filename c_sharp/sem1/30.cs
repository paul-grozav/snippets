using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, k=0;
            int[,] a = new int[20, 20];//matricea pe care am citit-o
            int[] b = new int[50];
            int[] c = new int[50];//in c pun elementele distincte

            do
            {
                Console.Write("linii=");
                n = int.Parse(Console.ReadLine());

                Console.Write("coloane=");
                m = int.Parse(Console.ReadLine());
            } while (n == m || n < 1 || m < 1);

            //citirea matricei a
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                {
                    Console.Write("a[" + i + ", " + j + "]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }


            //aflarea numarului de numere distincte de pe fiecare linie
            for (i = 1; i <= n; i++)//ma plimb pe linile matricei
            {
                //pt fiecare linie formez un vector c in care pun elementele distincte de pe linia respectiva
                k = 0;//cate elemente am in vectorul c = adica cate elemente distincte sunt pe linie
                for (j = 1; j <= m; j++)//ma plimb prin elementele liniei
                {
                    bool g = false;//elementul a[i,j] initial nu l-am gasit in c
                    for (int l = 1; l <= k; l++)//ma plimb prin c
                        if (c[l] == a[i, j]) g = true;//daca il gasesc pe a[i, j] pe o pozitie in c inseamna ca g(gasit)=true
                    if (!g)//daca nu l-am gasit pe elementul a[i,j] in c
                    {
                        k++;//atunci mai fac un loc in C crescand-ui dimensiunea(k) cu o unitate
                        c[k] = a[i, j];//si in celula libera il pun pe a[i,j] ... ca nu era in c
                    }
                }
                b[i] = k;//b[i] este numarul de elemente distincte de pe linia care tocmai am parcurs
            }

            //in b am pe pozitia i cate elemente distincte am in matricea a pe linia i
            //aflu numarul maxim de numere distincte pe o linie
            int max = b[1];
            for (i = 2; i <= n; i++)
                if (b[i] > max)
                {
                    max = b[i];
                    k = i;
                }



            for (i = 1; i <= n; i++)
                if (i == k)
                {
                    for (j = 1; j <= m; j++)
                        Console.Write(a[i, j] + " ");
                }

            Console.ReadLine();
        }
    }
}