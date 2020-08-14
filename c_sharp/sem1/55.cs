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
            String[] cuv = new String[] { "probleem", "emre", "emrge" };//cuvintele probleme, mere, merge scrise gresit
            //mai jos la for se putea pune si conditia i < cuv.Length
            for (int i = 0; i <= cuv.GetUpperBound(0); i++)//GetUpperBound(0) returneaza indexul maxim in cazul acesta 2 pt ca avem elemente pe cuv[0], cuv[1] si cuv[2]
            {
                cuv[i] = cuv[i].Replace("em", "me");
                Console.Write(cuv[i] + " ");
            }
            Console.ReadLine();
        }
    }
}