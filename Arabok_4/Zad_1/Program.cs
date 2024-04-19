namespace Zad_1;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x + 10 != 0)
            {
                double y1 = (Math.Pow(x, 3) - 2) / (x + 10) + 4 * x;
                Console.WriteLine($"Значение первого выражения: {y1}");
            }
            else
                throw new DivideByZeroException();

            if (x + 6 != 0)
            {
                double y2 = Math.Log(x) + Math.Cos(x) / (x + 6);
                Console.WriteLine($"Значение второго выражения: {y2}");
            }
            else
                throw new DivideByZeroException();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода.");
        }
    }
}