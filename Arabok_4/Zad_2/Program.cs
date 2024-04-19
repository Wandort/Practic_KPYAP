namespace Zad_2;
public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x <= 0 || x > 2)
                throw new ArgumentOutOfRangeException(nameof(x), "x должен находиться в диапазоне (0, 2]");

            double f;
            if (x < 1)
                f = 3 * Math.Pow(x, 2);
            else if (x >= 1)
                f = x / (x - 1);
            else
                throw new Exception("Произошла неожиданная ошибка.");

            Console.WriteLine($"Значение функции f при x={x} равно {f}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное вещественное число.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль не допускается.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}