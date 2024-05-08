/// <summary>
/// Класс, представляющий программу для выполнения арифметических операций над числами.
/// </summary>
class Program
{
    /// <summary>
    /// Выполняет сложение двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма чисел.</returns>
    public static double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Выполняет вычитание двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Разность чисел.</returns>
    public static double Sub(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Выполняет умножение двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Произведение чисел.</returns>
    public static double Mul(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Выполняет деление двух чисел.
    /// </summary>
    /// <param name="a">Делимое.</param>
    /// <param name="b">Делитель.</param>
    /// <returns>Частное чисел.</returns>
    /// <exception cref="DivideByZeroException">Исключение при попытке деления на ноль.</exception>
    public static double Div(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("Деление на ноль недопустимо.");
    }

    static void Main()
    {
        // Пример использования арифметических операций
        // ...
    }
}
