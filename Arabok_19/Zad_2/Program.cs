/// <summary>
/// Вычисляет периметр и площадь равностороннего треугольника.
/// </summary>
/// <param name="a">Длина стороны треугольника.</param>
/// <param name="P">Периметр треугольника.</param>
/// <param name="S">Площадь треугольника.</param>
static void TrianglePS(double a, out double P, out double S)
{
    P = 3 * a;
    S = (Math.Sqrt(3) / 4) * a * a;
}

/// <summary>
/// Основной метод программы.
/// </summary>
static void Main()
{
    Console.Write("Введите значение стороны a: ");
    double a = double.Parse(Console.ReadLine());

    double P, S;
    TrianglePS(a, out P, out S);

    Console.WriteLine($"Периметр треугольника: P = {P:F2}");
    Console.WriteLine($"Площадь треугольника: S = {S:F2}");

    for (int i = 1; i <= 3; i++)
    {
        double side = a * i;
        TrianglePS(side, out P, out S);
        Console.WriteLine($"Треугольник {i}:");
        Console.WriteLine($"Периметр: P = {P:F2}");
        Console.WriteLine($"Площадь: S = {S:F2}");
    }
}
