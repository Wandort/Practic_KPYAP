namespace Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            string numberStr = number.ToString();

            int firstDigit = int.Parse(numberStr[0].ToString());

            int lastDigit = int.Parse(numberStr[numberStr.Length - 1].ToString());

            Console.WriteLine($"Первая цифра числа {number} - это {firstDigit}");
            Console.WriteLine($"Последняя цифра числа {number} - это {lastDigit}");
        }
    }
}