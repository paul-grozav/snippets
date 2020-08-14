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
            int n, d;
            bool p = true;//p va reprezenta valoarea de adevar a propozitiei: n este prim

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            //n%d reprezinta restul impartirii lui n la d. Spre exemplu 9%7 este 2 pentru ca "7 intra in 9 o data si ramane 2" ... 6%3 este 0 pentru ca "3 intra in 6 de 2 ori si ramane 0"
            for (d = 2; (d <= n / 2 && p); d++)//d este numarul care verificam daca e divizor al lui n. Divizorul 1 nu are sens sa il verificam pt ca orice nr se imparte la 1. Si nu are rost sa verificam nici numere mai mari decat jumatatea lui n
                if (n % d == 0) p = false;//daca restul impartirii lui n la d (adica n%d) este 0 inseamna ca n se imparte exact la d => d este divizor al lui n. Cum d e diferit de 1 si n => n nu e prim 

            if (p) Console.Write("Numarul e prim");
            else Console.Write("Numarul nu e prim");
            Console.ReadLine();
        }
    }
}