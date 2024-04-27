interface Iy
{
    int IxF0(int x);
    int IxF1(int x);
}

interface Iz
{
    int F0(char c);
    int F1(char c);
}

class MyClass : Iy, Iz
{
    public int IxF0(int x)
    {
        return x + 5;
    }

    public int IxF1(int x)
    {
        return x + 5;
    }

    public int F0(char c)
    {
        if (char.IsLetter(c))
        {
            return c - 'a' + 5;
        }
        return 0;
    }

    public int F1(char c)
    {
        if (char.IsLetter(c))
        {
            return 5;
        }
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();

        Iy iy = myClass;
        Iz iz = myClass;

        int result1 = iy.IxF0(10);
        int result2 = iz.F0('b');

        Console.WriteLine($"Результат 1: {result1}");
        Console.WriteLine($"Результат 2: {result2}");
    }
}