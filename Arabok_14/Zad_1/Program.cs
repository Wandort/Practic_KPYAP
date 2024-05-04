class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(CountNumbers);
        Thread thread2 = new Thread(CountNumbers);
        Thread thread3 = new Thread(CountNumbers);

        thread1.Priority = ThreadPriority.Lowest;
        thread2.Priority = ThreadPriority.Normal;
        thread3.Priority = ThreadPriority.Highest;

        thread1.Start(0);
        thread2.Start(10);
        thread3.Start(20);

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Главный поток завершил работу.");
    }

    static void CountNumbers(object startNumberObj)
    {
        int startNumber = (int)startNumberObj;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {startNumber + i}");
            Thread.Sleep(100);
        }
    }
}