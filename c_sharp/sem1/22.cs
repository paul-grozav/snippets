using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Motor { /* ... */ }
    
    class Caroserie { /* ... */ }
    
    class Masina
    {
        private string marca;
        private Caroserie c;
        private Motor m;

        public Masina(Caroserie c, Motor m, string marca){
            this.c = c;
            this.m = m;
            this.marca = marca;
        }
    }

    class Test
    {
        static void Main()
        {
            Caroserie C = new Caroserie();
            Motor M = new Motor();
            Masina ma = new Masina(C, M, "Ford");
        }
    }
}