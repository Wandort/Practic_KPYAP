namespace Zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 5;
            double height = 10;

            double surfaceArea = 2 * Math.PI * radius * (radius + height);

            Console.WriteLine($"Площадь поверхности цилиндра: {surfaceArea:F2} кв. см");
        }
    }
}