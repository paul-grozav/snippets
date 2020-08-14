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
        static String c;
        static int min, max;

        static void creare()
        {
            String n;
            Console.WriteLine("Dati elementele listei separate prin ' ' (spatiu)");
            n = Console.ReadLine();
            String[] s = n.Split(' ');
            int n1;//ala care il adaug in lista

            foreach (String nr in s)
            {
                n1 = int.Parse(nr);
                l.Add(n1);
            }
        }

        static void listare(ArrayList ll)
        {
            foreach (int y in ll)
                Console.Write(y + " ");
            Console.WriteLine();
        }

        static int minim(ArrayList ll)
        {
            int mm;
            mm = int.MaxValue;

            foreach (int z in ll)
                if (mm > z)
                    mm = z;
            return mm;
        }

        static int maxim(ArrayList ll)
        {
            int mm;
            mm = int.MinValue;

            foreach (int z in ll)
                if (z > mm)
                    mm = z;
            return mm;
        }

        static void Main()
        {
            creare();
            Console.Write("Lista initiala ");
            listare(l);
            Console.Write("Introduceti m, M sau altceva: ");
            c = Console.ReadLine();

            while (c == "m" || c == "M")
            {
                if (c == "m")
                {
                    min = minim(l);
                    while (l.Contains(min))
                        l.Remove(min);
                }else{
                    max = maxim(l);
                    while (l.Contains(max))
                        l.Remove(max);
                }

                if (l.Count != 0)
                {
                    listare(l);
                    Console.Write("Introduceti m, M sau altceva: ");
                    c = Console.ReadLine();
                }

                else break;
            }
        }
    }
}