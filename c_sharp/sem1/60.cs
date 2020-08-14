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
            String s;
            String[] s1;
            int k = 0;
            char[] sep = new char[] { ' ', ',', '.' };

            Console.WriteLine("Dati un text in care cuvintele sunt separate prin un singur spatiu, virgula sau punct:");
            s = Console.ReadLine();

            s1 = s.Split(sep, s.Length);//facem impartirea

            //afisam cuvintele si le numaram
            foreach (String c in s1)
            {
                k++;
                Console.WriteLine(c);
            }
            Console.WriteLine("Numarul de cuvinte este: " + k);

            Console.ReadLine();
        }
    }
}