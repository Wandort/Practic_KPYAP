using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<int> firstTask = Task.Run(() =>
        {
            int number = 123;
            int firstDigit = number / 100;
            int lastDigit = number % 10;
            return firstDigit * 10 + lastDigit;
        });

        Task continuationTask = firstTask.ContinueWith(taskResult =>
        {
            int result = taskResult.Result;
            Console.WriteLine($"Первая и последняя цифры числа: {result}");
        });

        await Task.WhenAll(firstTask, continuationTask);
    }
}
