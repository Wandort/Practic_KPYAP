/// <summary>
/// Класс, представляющий программу для переписывания строк между двумя файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Записывает строки из массива в файл.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <param name="lines">Массив строк для записи.</param>
    static void WriteLinesToFile(string filePath, string[] lines)
    {
        File.WriteAllLines(filePath, lines);
    }

    /// <summary>
    /// Выводит содержимое файла на консоль.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    static void PrintFileContents(string filePath)
    {
        foreach (string line in File.ReadAllLines(filePath))
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Возвращает количество строк в файле.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <returns>Количество строк.</returns>
    static int GetLineCount(string filePath)
    {
        return File.ReadAllLines(filePath).Length;
    }

    // Другие методы...

    static void Main()
    {
        // Пример использования методов
    }
}
