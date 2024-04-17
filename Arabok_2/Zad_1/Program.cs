class A
{
    private int a;
    private int b;
    public A(int aValue, int bValue)
    {
        a = aValue;
        b = bValue;
    }

    public int Multiply()
    {
        return a * b;
    }

    public double CalculateExpression()
    {
        if (a == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
            return double.NaN;
        }

        double result = Math.Sqrt(b) / (2.0 * a);
        return result;
    }
}

class Program
{
    static void Main()
    {
        A myObject = new A(3, 5);

        Console.WriteLine($"Произведение a и b: {myObject.Multiply()}");
        Console.WriteLine($"Значение выражения (√b) / (2a): {myObject.CalculateExpression()}");

        Console.ReadLine();
    }
}