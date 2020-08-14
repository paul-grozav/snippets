using System;

class intreg
{
    public int x;
}

class Test
{
    static void Main(string[] args)
    {
        intreg r = new intreg();
        r.x = 14;
        Console.Write(r.x);//Console.WriteLine() scrie pe ecran ce ii dam ca parametru dupa care sare pe randul urmator
        //Console.Write() scrie pe ecran dar nu sare pe linia urmatoare
        // se mai poate folosi: 
        //Console.Write("x="+r.x);//sau
        //Console.Write("x={0}", r.x);// unde 0 scris intre {} reprezinta indexul parametrului care vrem sa apara unde am pus {0}
        //spre exemplu daca avem mai multe valori de afisat scriem:
        //Console.Write("x={0}, y={1}", x, y);//dar aceasta comanda nu merge la noi pentru ca nu avem cele 2 variabile x si y
    }
}