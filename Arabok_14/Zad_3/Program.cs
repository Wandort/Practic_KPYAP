using System;
using System.Threading;

class Program
{
    static Mutex mutex = new Mutex();
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение A:");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Thread thread1 = new Thread(() => Method1(A, N));
        Thread thread2 = new Thread(() => Method1(A, N));
        Thread thread3 = new Thread(() => Method2(A, N));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.ReadLine();
    }

    static void Method1(double A, int N)
    {
        double result = 0;
        for (int i = 0; i <= N; i++)
        {
            result += Math.Pow(A, i);
        }
        Console.WriteLine("Результат метода 1: " + result);
    }

    static void Method2(double A, int N)
    {
        mutex.WaitOne();
        double result = 1;
        for (int i = 0; i <= N; i++)
        {
            result *= Math.Pow(A, i);
        }
        Console.WriteLine("Результат метода 2: " + result);
        mutex.ReleaseMutex();
    }
}
