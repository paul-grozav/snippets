using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _14.Fisier_cu_linii
{
    class Program
    {
        static void Main(string[] args)
        {

            //Atentie! apare caracterul @ inainte de stringul ce reprezinta adresa catre fisier
            //trebuie sa faci acest fisier altfel apare o eroare 
            string f = @"C:\test.txt";
            StreamReader sr = new StreamReader(f);
            string s = null;
            string linie = null;

            //stabilim care linie are lungimea minima
            int x = 0, min;
            linie = sr.ReadLine();//sr.ReadLine() returneaza la prima apelare prima linie din fisier. la a 2-a apelare a 2-a linie ... si tot asa
            min = linie.Length;
            s = linie;
            while ((linie = sr.ReadLine()) != null)
            {
                x = linie.Length;
                if (min > x)
                {
                    min = x;
                    s = linie;
                }
            }
            Console.Write(s);//afisam linia s care este cea mai scurta(ca numar de caractere)
            sr.Close();
            Console.ReadLine();

        }
    }
}