namespace Zad_1;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.WriteLine($"Нечетный элемент с порядковым номером {i}: {numbers[i]}");
            }
        }
    }
}