using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static int fib(int x)
        {//prin definitie primele 2 elemente din sirul lui Fibonacci sunt 0 si 1. Iar fiecare dupa este suma celor 2 dinainte.
            if (x == 0) return 0;
            if (x == 1) return 1;
            if (x > 1) return fib(x-1) + fib(x-2);
            return 0;//oricum linia asta nu se executa pentru ca nu apelam fib(x) cu x < 0
        }
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            //umplerea matricii
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = fib(i*n+j);//pozitia ij din matrice este a i*n+j casuta deci acolo punem elementul al i*n+j -lea din sirul lui Fib.
            //i*n+j ... i reprezinta linia curenta... n este numarul de linii si de coloane si j este coloana curenta
            //deci sunt la casuta numarul i*n+j ... adica sunt n casute pe o linie * i linii parcurse deja + ... j casute parcuse pe linia pe care sunt

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