using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    class OutParam
    {
        public void Metoda(out int x)
        {
            x = 10;
            x++;
        }
    }

    class Test
    {
        static void Main()
        {
            OutParam z = new OutParam();
            int y;
            z.Metoda(out y);
            Console.Write(y);
            Console.ReadLine();
        }
    }
}