using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Test
    {
        static void Main()
        {
            string s1 = "Salut", s2 = "salut";
            if (s1 != s2)
                Console.WriteLine("s1 != s2");
            if (s1.ToUpper() == s2.ToUpper())//ToUpper() returneaza stringul cu toate literele MARI
                Console.WriteLine(s1.ToUpper());
            s1 += s2;//concatenarea stringurilor
            string s = s1.Insert(5, " ");//introducerea unui string in alt string la o pozitie anume
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}