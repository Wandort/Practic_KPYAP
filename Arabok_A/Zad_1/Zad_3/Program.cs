namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.5;
            double y = CalculateY(x);
            Console.WriteLine($"Значение y: {y}");
        }

        static double CalculateY(double x)
        {
            double result = 20 * Math.Log(Math.Cos(Math.Exp(-2 / (Math.Sqrt(Math.Sin(3 * x + 1) - Math.Pow(x, 2))))));
            return result;
        }
    }
}