using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication24
{
    class Program
    {
        static ArrayList l = new ArrayList();
        static float x;
        static void creare()
        {
            int n, i;
            float c;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("nr=");
                c = float.Parse(Console.ReadLine());
                l.Add(c);
            }
        }

        static void listare(ArrayList ll)
        {
            foreach (float y in ll)
                Console.Write(y + " ");
        }

        static void stergere()
        {
            while (l.Contains(x))
                l.Remove(x);
        }

        static void Main()
        {
            creare();
            Console.Write("lista initiala");
            listare(l);
            Console.Write("\nElementul de sters=");
            x = float.Parse(Console.ReadLine());
            stergere();
            Console.Write("lista obtinuta");
            listare(l);
            Console.ReadLine();
        }
    }
}