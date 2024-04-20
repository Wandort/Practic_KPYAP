class Program
{
    static void Main()
    {
        int[,] salaries = new int[18, 12];

        Random random = new Random();
        for (int i = 0; i < 18; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                salaries[i, j] = random.Next(2000, 10000);
            }
        }

        int annualIncome = 0;
        for (int j = 0; j < 12; j++)
        {
            annualIncome += salaries[0, j];
        }

        Console.Write("Введите заданное число: ");
        int threshold = int.Parse(Console.ReadLine());

        if (annualIncome > threshold)
        {
            Console.WriteLine($"Годовой доход первого человека ({annualIncome}) больше заданного числа ({threshold}).");
        }
        else
        {
            Console.WriteLine($"Годовой доход первого человека ({annualIncome}) не больше заданного числа ({threshold}).");
        }
    }
}