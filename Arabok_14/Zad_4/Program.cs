using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = Enumerable.Range(0, 100).Select(_ => random.Next(0, 10)).ToArray();
        int numberOfThreads = Environment.ProcessorCount;

        var dividedArray = new int[numberOfThreads][];
        int size = numbers.Length / numberOfThreads;
        for (int i = 0; i < numberOfThreads; i++)
        {
            dividedArray[i] = numbers.Skip(i * size).Take(size).ToArray();
        }

        Task<int>[] tasks = new Task<int>[numberOfThreads];
        for (int i = 0; i < numberOfThreads; i++)
        {
            int[] part = dividedArray[i];
            tasks[i] = Task.Factory.StartNew(() => SumOddNumbers(part));
        }

        Task.WaitAll(tasks);
        int totalSum = tasks.Sum(t => t.Result);

        Console.WriteLine("Сумма нечетных чисел: " + totalSum);
    }

    static int SumOddNumbers(int[] numbers)
    {
        return numbers.Where(n => n % 2 != 0).Sum();
    }
}
