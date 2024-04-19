namespace Zad_3;
public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Введите значение X: ");
            double X = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double Y = Convert.ToDouble(Console.ReadLine());

            if (X <= 0 || Y <= 0)
                throw new ArgumentOutOfRangeException("X и Y должны быть положительными числами.");

            double AMean, GMean;
            AMean = (X + Y) / 2;
            GMean = Math.Sqrt(X * Y);

            Console.WriteLine($"Среднее арифметическое (AMean) для X и Y: {AMean}");
            Console.WriteLine($"Среднее геометрическое (GMean) для X и Y: {GMean}");

            // Calculate for specific pairs (A, B), (A, C), (A, D)
            double A = 5, B = 8, C = 12, D = 15;
            double AMean_A_B, GMean_A_B;
            double AMean_A_C, GMean_A_C;
            double AMean_A_D, GMean_A_D;

            (AMean_A_B, GMean_A_B) = CalculateMeanAndGeometricMean(A, B);
            (AMean_A_C, GMean_A_C) = CalculateMeanAndGeometricMean(A, C);
            (AMean_A_D, GMean_A_D) = CalculateMeanAndGeometricMean(A, D);

            Console.WriteLine($"Среднее арифметическое (A, B): {AMean_A_B}");
            Console.WriteLine($"Среднее геометрическое (A, B): {GMean_A_B}");

            Console.WriteLine($"Среднее арифметическое (A, C): {AMean_A_C}");
            Console.WriteLine($"Среднее геометрическое (A, C): {GMean_A_C}");

            Console.WriteLine($"Среднее арифметическое (A, D): {AMean_A_D}");
            Console.WriteLine($"Среднее геометрическое (A, D): {GMean_A_D}");
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

    public static (double, double) CalculateMeanAndGeometricMean(double X, double Y)
    {
        double AMean = (X + Y) / 2;
        double GMean = Math.Sqrt(X * Y);
        return (AMean, GMean);
    }
}