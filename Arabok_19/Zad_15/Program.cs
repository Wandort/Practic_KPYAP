/// <summary>
/// Класс, представляющий программу для анализа строк из файла.
/// </summary>
class Program
{
    /// <summary>
    /// Загружает строки из файла.
    /// </summary>
    /// <param name="fileName">Путь к файлу.</param>
    /// <returns>Массив строк.</returns>
    static string[] LoadLinesFromFile(string fileName)
    {
        return File.ReadAllLines(fileName);
    }

    /// <summary>
    /// Возвращает количество строк, начинающихся и заканчивающихся одной буквой.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <returns>Количество строк с одинаковой первой и последней буквой.</returns>
    static int CountSameStartEndLetter(string[] lines)
    {
        return lines.Count(line => line.Length > 0 && line.First() == line.Last());
    }

    /// <summary>
    /// Возвращает самую длинную строку и её длину.
    /// </summary>
    /// <param name="lines">Массив строк.</param>
    /// <returns>Самая длинная строка и её длина.</returns>
    static (string longestLine, int longestLineLength) GetLongestLine(string[] lines)
    {
        string longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault();
        int longestLineLength = longestLine?.Length ?? 0;
        return (longestLine, longestLineLength);
    }

    // Другие методы...

    static void Main()
    {
        // Пример использования методов
    }
}
