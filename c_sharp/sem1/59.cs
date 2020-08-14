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
            String s1, s2;
            int k, n1;
            Console.Write("Dati un text:");
            s1 = Console.ReadLine();
            Console.Write("Dati cuvantul ce vreti a fi sters:");
            s2 = Console.ReadLine();

            //Eliminarea aparitilor lui s2 in s1
//            n1 = s2.Length;
//            k = s1.IndexOf(s2);
//            while (k >= 0)
//            {
//                s1 = s1.Remove(k, n1);
//                k = s1.IndexOf(s2);
//            }
            //nu ca nu e buna metoda de mai sus dar ... nu e mai simplu asa?
            s1 = s1.Replace(s2, "");//a sterge aparitile lui s2 inseamna a inlocui pe s2 cu "" (nimic)

            Console.Write("Noul text este:"+s1);
            Console.ReadLine();
        }
    }
}