using System;

class Program
{
    static double Max(double a, double b)
    {
        return Math.Max(a, b);
    }

    static double Max(double a, double b, double c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    static void Main()
    {
        Console.Write("Введите значение a1: ");
        double a1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение a2: ");
        double a2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение c2: ");
        double c2 = double.Parse(Console.ReadLine());

        double result = Max(a1, b1) - Max(a2, b2, c2);

        Console.WriteLine($"Результат выражения Max(a1, b1) - Max(a2, b2, c2) = {result}");
    }
}