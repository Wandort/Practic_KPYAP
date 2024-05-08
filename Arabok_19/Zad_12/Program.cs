/// <summary>
/// Класс, представляющий программу для выполнения операций над строками и файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Записывает строки в файл.
    /// </summary>
    /// <param name="filePath">Путь к файлу.</param>
    /// <param name="lines">Массив строк.</param>
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

    /// <summary>
    /// Выводит длину каждой строки.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    static void PrintCharacterCountPerLine(string[] lines)
    {
        foreach (string line in lines)
        {
            Console.WriteLine($"Длина строки \"{line}\": {line.Length} символов");
        }
    }

    /// <summary>
    /// Удаляет последнюю строку из массива строк.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <returns>Массив строк без последней строки.</returns>
    static string[] RemoveLastLine(string[] lines)
    {
        return lines.Take(lines.Length - 1).ToArray();
    }

    /// <summary>
    /// Выводит строки в заданном диапазоне.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <param name="start">Начальный индекс строки.</param>
    /// <param name="end">Конечный индекс строки.</param>
    static void PrintLinesInRange(string[] lines, int start, int end)
    {
        for (int i = start - 1; i < end; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {lines[i]}");
        }
    }

    /// <summary>
    /// Возвращает длину самой длинной строки.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <returns>Длина самой длинной строки.</returns>
    static int GetMaxLength(string[] lines)
    {
        return lines.Max(line => line.Length);
    }

    /// <summary>
    /// Выводит строки, начинающиеся с заданной буквы.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <param name="letter">Буква для фильтрации строк.</param>
    static void PrintLinesStartingWithLetter(string[] lines, char letter)
    {
        var filteredLines = lines.Where(line => line.StartsWith(letter));
        Console.WriteLine($"Строки, начинающиеся с буквы '{letter}':");
        foreach (string line in filteredLines)
        {
            Console.WriteLine(line);
        }
    }

    /// <summary>
    /// Переворачивает строки и записывает их в файл.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <param name="filePath">Путь к файлу.</param>
    static void ReverseLinesToFile(string[] lines, string filePath)
    {
        Array.Reverse(lines);
        File.WriteAllLines(filePath, lines);
    }

    static void Main()
    {
        // Пример использования методов
        // ...
    }
}
