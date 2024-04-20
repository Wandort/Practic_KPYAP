class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (N < 10): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Write("Введите значение C: ");
        int C = int.Parse(Console.ReadLine());
        Console.Write("Введите значение D: ");
        int D = int.Parse(Console.ReadLine());

        long product = 1;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] >= C && matrix[i, j] <= D)
                {
                    product *= matrix[i, j];
                }
            }
        }
        Console.WriteLine($"Произведение чисел в промежутке [{C}, {D}]: {product}");

        for (int j = 0; j < N; j++)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += matrix[i, j];
            }
            Console.WriteLine($"Сумма элементов столбца {j + 1}: {sum}");
        }
    }
}