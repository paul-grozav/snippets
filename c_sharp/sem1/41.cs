using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static ArrayList creazaLista(Double[] a)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < a.Length; i++)
                al.Add(a[i]);
            return al;
        }

        static void afiseaza(ArrayList al)
        {
            foreach (Object nr in al)
                Console.WriteLine(nr);
        }

        static ArrayList oAltaLista(ArrayList al, int index)
        {
            return al.GetRange(index, al.Count - index);
        }

        static ArrayList divizoriiLuiK(int k, ArrayList al)
        {
            ArrayList alr = new ArrayList();
            //gaseste indicii
            foreach (double y in al)
                if (k % y == 0)
                    alr.Add(y);
            return alr;
        }

        static void Main(string[] args)
        {
            Console.Write("nr de elemente din lista=");
            int n = int.Parse(Console.ReadLine());
            Double[] a = new Double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lista initiala este:");
            afiseaza(creazaLista(a));

            Console.WriteLine("Elementele din lista initiala de pe pozitii >" + 2 + " sunt:");
            afiseaza(oAltaLista(creazaLista(a), 2));

            Console.Write("Ai cui divizori vrei sa ii afisez din lista?");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementele care se divid la " + k + " sunt:");
            afiseaza(divizoriiLuiK(k, creazaLista(a)));

            Console.ReadLine();
        }
    }
}