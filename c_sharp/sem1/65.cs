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
            float[] x;
            float sm = 0, gm = 0; //gm=suma maxima , sm= suma pana la momentu curent
            int n, k, i, l;
            int j = -1, i1 = -1;//i1 si j sunt cei 2 indici i1<j 

            //citim vectorul
            Console.Write("Cate elemente are vectorul?");
            n = int.Parse(Console.ReadLine());
            x = new float[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("x["+i+"]=");
                x[i] = float.Parse(Console.ReadLine());
            }

            //creez noul sir
            l = 0;
            for (k = 0; k < n; k++)
            {
                if (x[k] + sm > gm)//daca adaug si x[k] la sm obtin o suma mai mare decat suma cea mai mare(care o stiu) atunci
                {
                    sm += x[k];//suma momentana creste cu x[k]
                    gm = sm;//si suma maxima e tocmai noua suma care a devenit cea mai mare(care o stiu)
                    i1 = l;//noul indice mic e l
                    j = k;//noul indice mare e k
                }
                else if (x[k] + sm > 0)//daca adaug si pe x[k] la sm obtin ceva pozitiv dar totusi mai mic sau egal cu suma maxima atunci
                    sm += x[k];//il adaug totusi pe x[k] in suma
                else//daca adaug pe x[k] si obtin ceva <= 0 atunci
                {
                    sm = 0;//suma momentana e 0
                    l = k + 1;// ?? :)
                }
            }

            //afisez noul sir
            for (i = i1; i <= j; i++)
                Console.Write(x[i] + " ");
            Console.ReadLine();
        }
    }
}