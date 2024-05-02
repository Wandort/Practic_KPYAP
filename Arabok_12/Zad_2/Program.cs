class Program
{
    static void Main()
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) =>
        {
            if (b != 0)
                return a / b;
            else
                throw new DivideByZeroException("Деление на ноль недопустимо.");
        };

        double x, y;
        char operation;

        Console.Write("Введите первое число: ");
        double.TryParse(Console.ReadLine(), out x);

        Console.Write("Введите второе число: ");
        double.TryParse(Console.ReadLine(), out y);

        Console.Write("Выберите операцию (+, -, *, /): ");
        char.TryParse(Console.ReadLine(), out operation);

        try
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Сумма: {Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"Разность: {Sub(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"Произведение: {Mul(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"Частное: {Div(x, y)}");
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}