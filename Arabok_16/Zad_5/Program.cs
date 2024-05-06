class Program
{
    static void Main()
    {
        double[] numbers = { 1.5, 2.0, -3.7, 4.2, -0.5, 6.8, 7.1 };

        WriteNumbersToFile(numbers, "C:\\Практика КПиЯп\\Arabok_16\\Zad_5/Files/numbers.txt");

        double threshold = 3.0;
        Console.WriteLine($"Числа меньше {threshold} из файла:");
        PrintNumbersFromFile("C:\\Практика КПиЯп\\Arabok_16\\Zad_5/Files/numbers.txt", threshold);

        Console.WriteLine("Положительные числа из файла:");
        PrintPositiveNumbersFromFile("C:\\Практика КПиЯп\\Arabok_16\\Zad_5/Files/numbers.txt");

        double average = CalculateEvenPositionAverage("C:\\Практика КПиЯп\\Arabok_16\\Zad_5/Files/numbers.txt");
        Console.WriteLine($"Среднее арифметическое на четных позициях: {average}");
    }

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
}