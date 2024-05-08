/// <summary>
/// Класс, представляющий программу для выполнения операций над числами и файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Записывает числа из массива в файл.
    /// </summary>
    /// <param name="numbers">Массив чисел.</param>
    /// <param name="fileName">Путь к файлу.</param>
    static void WriteNumbersToFile(double[] numbers, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (double num in numbers)
            {
                writer.WriteLine(num);
            }
        }
    }

    /// <summary>
    /// Выводит числа из файла, меньшие заданного порога.
    /// </summary>
    /// <param name="fileName">Путь к файлу.</param>
    /// <param name="threshold">Пороговое значение.</param>
    static void PrintNumbersFromFile(string fileName, double threshold)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                double num = Convert.ToDouble(line);
                if (num < threshold)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

    /// <summary>
    /// Выводит положительные числа из файла.
    /// </summary>
    /// <param name="fileName">Путь к файлу.</param>
    static void PrintPositiveNumbersFromFile(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                double num = Convert.ToDouble(line);
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

    /// <summary>
    /// Вычисляет среднее арифметическое чисел на четных позициях в файле.
    /// </summary>
    /// <param name="fileName">Путь к файлу.</param>
    /// <returns>Среднее арифметическое.</returns>
    static double CalculateEvenPositionAverage(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            double sum = 0;
            int count = 0;
            string line;
            int position = 0;

            while ((line = reader.ReadLine()) != null)
            {
                if (position % 2 == 0)
                {
                    double num = Convert.ToDouble(line);
                    sum += num;
                    count++;
                }
                position++;
            }

            return count > 0 ? sum / count : 0;
        }
    }

    static void Main()
    {
        // Пример использования методов
        // ...
    }
}
