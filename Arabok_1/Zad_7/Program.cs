namespace Zad_7;
class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру k: ");
        int k = int.Parse(Console.ReadLine());

        int count = CountDigitOccurrences(n, k);
        Console.WriteLine($"Цифра {k} входит в число {n} {count} раз(а).");
    }

    static int CountDigitOccurrences(int number, int digit)
    {
        int count = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            if (lastDigit == digit)
            {
                count++;
            }
            number /= 10;
        }
        return count;
    }
}