namespace Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 целых числа");

            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            Console.WriteLine($"{a} + {b} + {c} = {sum}");
            Console.ReadLine();
        }
    }
}