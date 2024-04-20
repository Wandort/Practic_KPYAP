class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        double fn = 1.0 / Factorial(n + 1);

        Console.WriteLine($"f({n}) = {fn}");
    }
}