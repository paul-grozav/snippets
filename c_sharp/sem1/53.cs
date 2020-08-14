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
            String[] c = new String[] { "triunghi", "patrat", "trimestru", "artrita" };
            ArrayList ctri = new ArrayList();

            //stabilim care elemente incep cu "tri"
            foreach (String cu in c)
                if (cu.StartsWith("tri"))
                    ctri.Add(cu);

            //afisarea elementelor ce incep cu "tri"
            foreach (String cu in ctri) Console.WriteLine(cu);

            Console.ReadLine();
        }
    }
}