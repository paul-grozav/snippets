using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[9999];
            int n, i, j, k;
            Console.Write("Pana la ce valoare vreti sa aflati numerele prime(max 9999)?");
            n = int.Parse(Console.ReadLine());

            //pun in ciur(sita) toate numerele de la 2 pana la n inclusiv 2 si n. Voi avea, deci, in ciur n-1 numere pentru ca doar pe 1 l-am eliminat
            for (i = 0; i <= n - 2; i++)
                a[i] = i + 2;

            //si fac eliminarea numerelor neprime. Sa ramana in ciur(sita) doar numerele prime
            for (i = 2; i <= Math.Sqrt(n); i++)
                for (j = 0; j <= n - 2; j++)
                    for (k = 2; k <= n / i; k++)
                        if (a[j] == i * k)
                            a[j] = 0;//daca a[j] l-am setat pe 0 inseamna ca a[j] nu e prim si deci renunt la el

            //afisez numerele prime
            for (i = 0; i <= n - 2; i++)
                if (a[i] != 0)//daca nu e 0 in ciur la pozitia i inseama ca acolo am un numar prim
                    Console.Write(a[i] + " ");//si il afisez
            Console.ReadLine();
        }
    }
}