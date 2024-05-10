using System;
using System.Threading;
using System.Threading.Tasks;

public class TaskExample
{
    public static void Main()
    {
        Task[] tasks = new Task[2]
        {
            Task.Run(() => {
                Thread.Sleep(1000);
                double alpha = 30;
                double radians = alpha * (Math.PI / 180);
                double z_1 = (1 - 2 * Math.Pow(Math.Sin(radians), 2)) / (1 + Math.Sin(2 * radians));
                Console.WriteLine($"z_1: {z_1}");
            }),
            
            Task.Run(() => {
                Thread.Sleep(2000);
                double alpha = 30; 
                double radians = alpha * (Math.PI / 180);
                double z_2 = (1 - Math.Tan(radians)) / (1 + Math.Tan(radians));
                Console.WriteLine($"z_2: {z_2}");
            })
        };

        Task.WaitAll(tasks);

        Console.WriteLine("Все задачи выполнены");

        int index = Task.WaitAny(tasks);

        Console.WriteLine($"Задание {index + 1} выполнено первым");
    }
}
