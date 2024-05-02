delegate int RandomDelegate();

class Program
{
    static void Main()
    {
        Random random = new Random();
        RandomDelegate[] delegates = new RandomDelegate[3];

        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = () => random.Next(1, 101);
        }

        Func<RandomDelegate[], double> averageDelegateValues = (delegatesArray) =>
        {
            double sum = 0;
            foreach (var del in delegatesArray)
            {
                sum += del();
            }
            return sum / delegatesArray.Length;
        };

        double average = averageDelegateValues(delegates);
        Console.WriteLine($"Среднее арифметическое возвращаемых значений: {average}");
    }
}