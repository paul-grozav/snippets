using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, p;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            d = 2;//primul divizor care il verificam e 2
            p = 0;//puterea initiala e 0 pentru ca inca nu stim daca se imparte macar odata n la 2
            while (n != 1)
            {
                while (n % d == 0)
                {
                    //de fiecare data cand am gasit un divizor al lui n
                    p++;//crestem puterea cu o unitate pentru ca n se imparte (inca) odata la d(divizorul)
                    n = n / d;//daca se imparte la d il "scoatem" pe d din n.
                    //spre exemplu: n=12 se imparte la d=2 deci p=1 si n care era 2*6 ramane acum n=6
                    //reluand ciclul n=6 se imparte la d=2 deci p=2 si n care era 3*2 ramane acum n=3
                    //acum n=3 si d=2 si p=2 => n % d != 0 => se termina while-ul ... deci n nu mai "contine" pe d
                    //3 nu mai "contine" pe 2 ... nu se mai scrie 2 * ceva ... deci am terminat cu divizorul 2
                    //si stim ca numarul initial s-a impartit de p ori la d. Adica s-a impartit la d*d*d*.. de p ori. Adica s-a impartit la d^p
                    //Adica numarul initial n se scrie n=d^p * ceva
                }
                if (p != 0)//daca am gasit ca n se imparte cel putin odata la divizorul d atunci afisam d^p
                    Console.WriteLine(d + "^" + p);
                d++;//dupa ce am terminat cu un divizor trecem la urmatorul
                p = 0;//si trecand la noul divizor punem iar puterea p=0 pentru ca noul divizor inca nu l-am gasit in n
            }
            Console.ReadLine();
        }
    }
}