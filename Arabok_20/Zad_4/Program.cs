class Program
{
    static void Main()
    {
        double A = -7;
        double B = 3;
        int numSteps = 10;

        double step = (B - A) / numSteps;

        double[] results = new double[numSteps + 1];

        Parallel.For(0, numSteps + 1, i =>
        {
            double x = A + i * step;
            results[i] = Math.Cos(x);
        });

        Console.WriteLine("Значения функции Cos(x) на отрезке [{0}, {1}]:", A, B);
        for (int i = 0; i <= numSteps; i++)
        {
            double x = A + i * step;
            Console.WriteLine("x = {0}, Cos(x) = {1}", x, results[i]);
        }
    }
}