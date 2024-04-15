namespace Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину круга");
            double square = Convert.ToDouble(Console.ReadLine());

            double radius = square / (2 * Math.PI);

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Площадь круга равна {area:F2}");
        }
    }
}