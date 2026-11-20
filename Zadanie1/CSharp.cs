using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwsza liczbe: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj druga liczbe: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj operacje (+, -, *, /): ");
        string op = Console.ReadLine();

        if (op == "+")
            Console.WriteLine("Wynik: " + (a + b));
        else if (op == "-")
            Console.WriteLine("Wynik: " + (a - b));
        else if (op == "*")
            Console.WriteLine("Wynik: " + (a * b));
        else if (op == "/")
        {
            if (b == 0)
                Console.WriteLine("Blad: dzielenie przez zero!");
            else
                Console.WriteLine("Wynik: " + (a / b));
        }
        else
            Console.WriteLine("Nieznana operacja!");
    }
}
