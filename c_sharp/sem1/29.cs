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
            int n, m, i, j, t = 0;
            int[,] a = new int[20, 20];
            int[] b = new int[50];

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write("m=");
            m = int.Parse(Console.ReadLine());

            //citirea matricei a
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                {
                    Console.Write("a[" + i + ", " + j + "]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            //adunarea numerelor ca la clasele mici
            for (j = m; j >= 1; j--)
            {
                int s = 0;//suma cifrelor de pe coloana j
                for (i = 1; i <= n; i++) s += a[i, j];//se aduna cifra de la fiecare rand
                s += t;//se mai aduna si transportul (adica + cat am avut in minte)
                b[j] = s % 10;//ultima cifra o scriu
                //Console.Write(s % t);
                t = s / 10;//ce ramane tin minte
            }
            if (t != 0) Console.Write(t);//daca am ceva transport il scriu

            //tiparirea vectorului b (dupa eventualul transport)
            for (i = 1; i <= m; i++) Console.Write(b[i]);

            Console.ReadLine();
        }
    }
}