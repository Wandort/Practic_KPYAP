/// <summary>
/// Класс, содержащий методы для вычисления максимальных значений и выполнения арифметических операций.
/// </summary>
class Program
{
    /// <summary>
    /// Возвращает максимальное значение из двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Максимальное значение.</returns>
    static double Max(double a, double b)
    {
        return Math.Max(a, b);
    }

    /// <summary>
    /// Возвращает максимальное значение из трех чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Максимальное значение.</returns>
    static double Max(double a, double b, double c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    /// <summary>
    /// Основной метод программы.
    /// </summary>
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
