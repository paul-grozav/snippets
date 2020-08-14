using System;

struct Student
{
    public string Nume;
    public int Varsta;
}

class Test
{
    static void Main()
    {
        Student s = new Student();
        s.Nume = "Vlad";
        Console.Write("Varsta=");
        s.Varsta = int.Parse(Console.ReadLine());//Console.ReadLine() reprezinta sirul de caractere(stringul) pe care l-a introdus utilizatorul de la tastatura.
        //Atentie! chiar daca utilizatorul a scris la tastatura 123 ... aceasta valoare va ajunge in C# ca string "123". Din acest motiv stringul trebuie
        //convertit in numar(in cazul nostru in numar intreg - int) pentru aceasta folosim int.Parse(). Aceasta functie transforma parametrul primit in numar intreg
        //Presupunand ca utilizatorul a introdus 123 Console.ReadLine() va avea valoarea "123" si astfel s.Varsta = int.Parse("123") iar int.Parse("123") are valoarea 123 (ca numar intreg) deci s.Varsta va avea valoarea 123 
        //Atentie! Console.ReadLine() blocheaza programul(programul nu executa urmatoarele comenzi) pana cand utilizatorul nu apasa tasta ENTER
        Console.Write("s.Nume="+s.Nume+"\ns.Varsta="+s.Varsta);//Cand scriem \n intr-un string (adica intre ghilimele) calculatorul va intelege Salt la linie noua adica ce vine dupa \n va fi scris pe randul urmator
        Console.ReadLine();//aceasta linie spune calculatorului sa astepte pana se apasa Enter. Astfel putem citi ce a afisat pe ecran.
    }
}