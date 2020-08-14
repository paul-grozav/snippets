using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n="); int n = int.Parse(Console.ReadLine());
            for(int i=1; i<n; i++) Console.WriteLine("Prima persoana ia "+i+" obiecte iar a doua ia "+(n-i)+" obiecte");
            Console.ReadLine();
        }
    }
}