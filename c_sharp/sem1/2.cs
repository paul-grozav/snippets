using System;

namespace SpatiuMeu
{
    class Test
    {
        static void Main(string[] args)
        {
            int a;
            a = 20;
            double b = 10;
            string s = "obiecte de tip string";
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            System.Console.WriteLine("s="+s);//e tot una daca se apeleaza Console.WriteLine() sau System.Console.WriteLine();
            //daca pun using System nu mai trebuie sa zic System.Console.WriteLine()
            //dar daca nu pun using System trebuie sa zic cu System. in fatza ca altfel da eroare
        }
    }
}