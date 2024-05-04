using System.Diagnostics;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Сумма чисел от 1 до 10: " + totalSum);
    }

    static long totalSum = 0;

    static void CalculateSum()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 1; i <= 10; i++)
        {
            totalSum += i;
        }

        stopwatch.Stop();
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} завершил работу за {stopwatch.ElapsedMilliseconds} мс.");
    }
}