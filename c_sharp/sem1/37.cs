using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Test
    {
        static void Main()
        {

            //cream o matrice neregulata ( adica nu are acelasi numar de elemente pe fiecare coloana )
            int[][] a = new int[][] {
                new int[] {1, 2, 3, 4, 5},
                new int[] {1, 2, 3, 4},
                new int[] {1, 2, 3},
                new int[] {1, 2},
                new int[] {1}
            };

            //tiparirea matricii meregulate
            for(int i=0; i<a.Length; i++){
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write(a[i][j]+"\t");
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}