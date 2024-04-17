class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x < 1.3)
        {
            y = (Math.Pow(x, 2) - 7 / Math.Sqrt(Math.Abs(x)));
        }
        else if (x == 1.3)
        {
            y = 3 * x - Math.Pow(Math.Cos(x), 2);
        }
        else
        {
            Console.WriteLine("Значение x не в допустимом диапазоне.");
            return;
        }

        Console.WriteLine($"Значение y : {y}");
    }
}