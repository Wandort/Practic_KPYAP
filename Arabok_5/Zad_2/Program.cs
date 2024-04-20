class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 101);
        }

        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Отрицательные числа:");
        foreach (int num in numbers)
        {
            if (num < 0)
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine("\nПоложительные числа:");
        foreach (int num in numbers)
        {
            if (num >= 0)
            {
                Console.Write(num + " ");
            }
        }

        Array.Sort(numbers);

        int index = Array.BinarySearch(numbers, k);
        if (index >= 0)
        {
            Console.WriteLine($"\nЧисло {k} найдено в массиве на позиции {index}.");
        }
        else
        {
            Console.WriteLine($"\nЧисло {k} не найдено в массиве.");
        }
    }
}