using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbe ocen: ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Podaj ocene {i} (1-6): ");
            suma += int.Parse(Console.ReadLine());
        }

        double srednia = suma / n;
        Console.WriteLine($"Srednia ocen: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczen zaliczyl przedmiot.");
        else
            Console.WriteLine("Uczen nie zaliczyl przedmiotu.");
    }
}
