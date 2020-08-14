using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main()
        {
            String[] a = new String[] { " inceput. ", " sfarsit. " };//am lasat niste spatii la inceputul si la sfarsitul fiecarui cuvant
            char[] c = new char[] { ' ', '.' };//caracterele care vreau sa le tai

            Console.WriteLine("Sirurile initiale puse unul langa altul sunt:");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]);

            Console.WriteLine("\nSirurile dupa Trim() puse unul langa altul sunt:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i].TrimStart(c);
                a[i] = a[i].TrimEnd(c);
                Console.Write(a[i]);
            }


            Console.ReadLine();
        }
    }
}