class Program
{
    static void Main()
    {
        try
        {
            string filePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_1\\Files/f.txt";
            double[] components = new double[] { 1.5, -2.3, 4.7, 3.2, -0.8 };

            WriteComponentsToFile(filePath, components);

            double sum = CalculateSum(components);
            double product = CalculateProduct(components);

            double sumAbsolute = Math.Abs(sum);
            double productSquared = product * product;

            Console.WriteLine($"Модуль суммы: {sumAbsolute}");
            Console.WriteLine($"Квадрат произведения: {productSquared}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void WriteComponentsToFile(string filePath, double[] components)
    {
        File.WriteAllLines(filePath, components.Select(c => c.ToString()));
    }

    static double CalculateSum(double[] components)
    {
        return components.Sum();
    }

    static double CalculateProduct(double[] components)
    {
        return components.Aggregate(1.0, (acc, c) => acc * c);
    }
}