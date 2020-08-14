using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        static ArrayList x = new ArrayList();

        static void afiseazaMinimulDinValori()
        {
            int min = 9999999;

            foreach (Object n in x)
                if (min > (int)n) min = (int)n;

            Console.WriteLine("minimul dintre valorile date este :" + min);
        }

        static void afiseazaCheileDePePozitileImpare()
        {
            int p = 1;
            Console.Write("valorile(cheile) de pe pozitile impare sunt: ");
            foreach (Object n in x)
            {
                if (p % 2 == 1)
                    Console.WriteLine(n);
                p++;
            }
        }

        static void afiseazaCheiaCuNrDeOrdineDat(int k)
        {
            int p = 1;
            foreach (Object n in x)
            {
                if (p == k)
                    Console.WriteLine("Valoarea(cheia) de pe pozitia care ai cerut este " + n);
                p++;
            }
        }

        static void verificaDacaCheileListeiSuntInOrdineDescrescatoare()
        {
            //o lista x este descrescatoare daca este identica cu inversa sortatei ei. sortata ei este in ordine crescatoare, inversa sortatei este in ordine descrescatoare
            ArrayList y = (ArrayList)x.Clone();
            y.Sort();
            y.Reverse();

            object[] x1 = x.ToArray();
            object[] y1 = y.ToArray();

            for (int i = 0; i < x1.Length; i++)
                if (x1[i] != y1[i])
                {
                    Console.WriteLine("nu sunt in ordine descrescatoare");
                    return;
                }
            Console.WriteLine("sunt in ordine descrescatoare");

        }

        static void afiseazaNrAparitiiValoare(int k)
        {
            int aparitii = 0;
            foreach (Object n in x)
                if ((int)n == k) aparitii++;

            Console.WriteLine(k + " apare de " + aparitii + " ori");
        }

        static void Main(string[] args)
        {
            int n, i = 0;

            //citim nr de elemente din lista
            Console.Write("Cate elemente are lista(vectorul)?");
            while (i == 0) i = int.Parse(Console.ReadLine());

            //citesc elementele 
            Console.WriteLine("Introduceti cele " + i + " elemente din lista separate prin ENTER");
            while (x.Count < i)
                x.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            //afiseaza numerul de noduri din lista
            Console.WriteLine("Numarul de elemente(noduri) din lista este " + x.Count);

            afiseazaMinimulDinValori();
            afiseazaCheileDePePozitileImpare();
            Console.WriteLine("De pe ce pozitie te intereseaza? :");
            afiseazaCheiaCuNrDeOrdineDat(int.Parse(Console.ReadLine()));
            verificaDacaCheileListeiSuntInOrdineDescrescatoare();
            Console.WriteLine("Ce valoare vrei sa caut de cate ori e? :");
            afiseazaNrAparitiiValoare(int.Parse(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}