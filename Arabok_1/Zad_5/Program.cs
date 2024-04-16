namespace Zad_5;
class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += (2 * i - 1);
            Console.WriteLine($"Текущая сумма: {sum}");
        }

        int square = sum;
        Console.WriteLine($"Квадрат числа {N} равен: {square}");
    }
}