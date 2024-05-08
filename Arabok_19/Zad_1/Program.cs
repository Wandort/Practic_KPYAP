/// <summary>
/// Вычисляет значение функции y = f(x, a) в заданном диапазоне.
/// </summary>
/// <param name="x">Значение аргумента x.</param>
/// <param name="a">Значение параметра a.</param>
/// <returns>Значение функции y = f(x, a).</returns>
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

/// <summary>
/// Основной метод программы.
/// </summary>
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