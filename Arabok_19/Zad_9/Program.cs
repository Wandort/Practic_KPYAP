/// <summary>
/// Класс, представляющий программу для выполнения операций с делегатами.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для генерации случайных чисел.
    /// </summary>
    /// <returns>Случайное целое число в диапазоне от 1 до 100.</returns>
    delegate int RandomDelegate();

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
