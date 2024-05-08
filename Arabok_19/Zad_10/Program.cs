/// <summary>
/// Класс, представляющий программу для выполнения операций над числами и файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Записывает компоненты в файл.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <param name="components">Массив компонентов.</param>
    static void WriteComponentsToFile(string filePath, double[] components)
    {
        File.WriteAllLines(filePath, components.Select(c => c.ToString()));
    }

    /// <summary>
    /// Вычисляет сумму компонентов.
    /// </summary>
    /// <param name="components">Массив компонентов.</param>
    /// <returns>Сумма компонентов.</returns>
    static double CalculateSum(double[] components)
    {
        return components.Sum();
    }

    /// <summary>
    /// Вычисляет произведение компонентов.
    /// </summary>
    /// <param name="components">Массив компонентов.</param>
    /// <returns>Произведение компонентов.</returns>
    static double CalculateProduct(double[] components)
    {
        return components.Aggregate(1.0, (acc, c) => acc * c);
    }

    static void Main()
    {
        // Пример использования методов
    }
}
