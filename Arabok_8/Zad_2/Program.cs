class Accountant
{
    public bool AskForBonus(string worker, int hours)
    {
        int standardHours = 140;
        if (hours > standardHours)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Accountant accountant = new Accountant();

        Console.Write("Введите имя сотрудника: ");
        string workerName = Console.ReadLine();

        Console.Write("Введите количество отработанных часов: ");
        int workedHours = int.Parse(Console.ReadLine());

        bool bonusEligible = accountant.AskForBonus(workerName, workedHours);

        if (bonusEligible)
        {
            Console.WriteLine($"{workerName} имеет право на премию.");
        }
        else
        {
            Console.WriteLine($"{workerName} не имеет права на премию.");
        }
    }
}