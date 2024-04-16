class Program
{
    static void Main()
    {
        double A = Math.PI / 3;
        double B = 2 * Math.PI / 3; 
        int M = 20; 

        double H = (B - A) / M; 

        Console.WriteLine("Значения функции F(x) = Cos x на отрезке [A, B]:");
        Console.WriteLine("x\tF(x)");

        for (int i = 0; i <= M; i++)
        {
            double xi = A + i * H;
            double F_xi = Math.Cos(xi);
            Console.WriteLine($"{xi:F4}\t{F_xi:F4}");
        }
    }
}