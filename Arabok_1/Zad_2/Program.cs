namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Вы указали четное число");
            }
            else
            {
                Console.WriteLine("Заданное число является нечетным");
            }
        }
    }
}