using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Copil
    {
        private string nume;
        private int varsta;

        public Copil(string n, int v)
        {
            nume = n;
            varsta = v;
        }

        public string Nume
        {//getter si setter pentru proprietatea Nume
            get { return nume; }
            set { nume = value;/*value e valoarea care se pune dupa egal ... cand zici de exemplu c.Nume = "Andrei" ... atunci value="Andrei"*/}
        }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
    }

    class Test
    {
        static void Main()
        {
            Copil c = new Copil("Vali", 18);
            Console.WriteLine(c.Nume+" "+c.Varsta);
            c.Nume = "Andrei";
            c.Varsta = 20;
            Console.Write(c.Nume + " " + c.Varsta);
            Console.ReadLine();
        }
    }
}