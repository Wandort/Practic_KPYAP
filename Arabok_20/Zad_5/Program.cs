using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 54, 17, 25, 66 };

        CancellationTokenSource cts = new CancellationTokenSource();

        ParallelOptions options = new ParallelOptions
        {
            CancellationToken = cts.Token,
            MaxDegreeOfParallelism = Environment.ProcessorCount
        };

        Task.Factory.StartNew(() =>
        {
            if (Console.ReadKey().KeyChar == 'c')
                cts.Cancel();
            Console.WriteLine("Нажмите любую клавишу для выхода.");
        });

        try
        {
            int sum = 0;
            long product = 1;

            Parallel.ForEach(numbers, options, (num) =>
            {
                options.CancellationToken.ThrowIfCancellationRequested();

                sum += num;
                product *= num;

                Console.WriteLine($"Обработка числа {num} на потоке {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine($"Произведение чисел: {product}");
        }
        catch (OperationCanceledException e)
        {
            Console.WriteLine($"Операция отменена: {e.Message}");
        }
        finally
        {
            cts.Dispose();
        }

        Console.ReadKey();
    }
}
