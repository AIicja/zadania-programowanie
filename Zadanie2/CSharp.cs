using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz kierunek (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperature: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik}°C");
        }
        else
        {
            Console.WriteLine("Nieprawidlowy wybor!");
        }
    }
}
