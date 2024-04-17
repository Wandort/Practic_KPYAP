namespace Zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alphaDegrees = 30;
            double alphaRadians = Math.PI * alphaDegrees / 180;

            double z1Numerator = Math.Sin(alphaRadians);
            double z1Denominator1 = 1 + Math.Cos(alphaRadians);
            double z1Denominator2 = 1 + Math.Cos(2 * alphaRadians);
            double z1 = (z1Numerator / z1Denominator1) - (Math.Cos(2 * alphaRadians) / z1Denominator2);

            double z2 = 1 / Math.Tan((3 * Math.PI / 2) - alphaRadians);

            Console.WriteLine($"Задание 1 = {z1:F6}");
            Console.WriteLine($"Задание 2 = {z2:F6}");
        }
    }
}