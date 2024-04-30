class A
{
    private int a;
    private int b;

    public A()
    {
        a = 10;
        b = 20;
    }

    public int C
    {
        get { return a + b; }
    }
}

class B : A
{
    private int d;

    public B() : base()
    {
        d = 30;
    }

    public int C2
    {
        get { return C + d; }
    }
}

class Program
{
    static void Main()
    {
        A objA = new A();

        B objB = new B();

        Console.WriteLine($"Свойство C в классе A: {objA.C}");
        Console.WriteLine($"Свойство C2 в классе B: {objB.C2}");
    }
}