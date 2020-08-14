using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class S
    {
        public void Schimba(int x, int y)
        {
            //schimbam locul valorilor prin regula paharelor
            int aux;
            aux = x;
            x = y;
            y = aux;
        }

        public void SchimbaPrinRef(ref int x, ref int y)
        {
            //schimbam locul valorilor prin regula paharelor
            int aux;
            aux = x;
            x = y;
            y = aux;
        }
    }

    class Test
    {
        static void Main()
        {
            S s = new S();
            int a = 10, b = 20;
 
            s.Schimba(a, b);//apelarea acestei functii nu afecteaza variabilele a si b originale
            Console.Write("In urma primei schimbari\na=" + a + " si b=" + b);
            
            s.SchimbaPrinRef(ref a, ref b);//apelarea acestei functii AFECTEAZA variabilele a si b originale
            Console.Write("\nDupa a 2-a schimbare\na=" + a + " si b=" + b);
            
            Console.ReadLine();
        }
    }
}