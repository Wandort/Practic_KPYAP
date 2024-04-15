namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.7;
            double y = 20 * Math.Log(Math.Pow(Math.Cos(2 / Math.Sqrt(Math.Pow(Math.Sin(Math.PI), 3) + 1 - Math.Pow(x, 2))), Math.E));

            Console.WriteLine($"Значение y при x = {x} равно: {y}");
        }
    }
}