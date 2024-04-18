namespace Zad_1;
class Program
{
    static double Function(double x, double a)
    {
        if (x < a)
        {
            return 0;
        }
        else if (x > a)
        {
            return x - a + a;
        }
        else
        {
            return 1;
        }
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите h: ");
        double h = double.Parse(Console.ReadLine());

        for (double x = a; x <= b; x += h)
        {
            double y = Function(x, a);
            Console.WriteLine($"x = {x:F3}, y = {y:F2}");
        }
    }
}