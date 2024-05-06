using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_3/Files/my_text_file.txt"; // Укажите путь к вашему файлу
            string[] lines = new string[]
            {
                "Это первая строка.",
                "Вторая строка короче.",
                "Третья строка довольно длинная и содержит больше символов.",
                "Четвертая строка средней длины.",
                "Пятая строка самая короткая."
            };

            WriteLinesToFile(filePath, lines);

            Console.WriteLine("Содержимое файла:");
            PrintFileContents(filePath);

            int lineCount = GetLineCount(filePath);
            Console.WriteLine($"Количество строк: {lineCount}");

            PrintCharacterCountPerLine(lines);

            string[] linesExceptLast = RemoveLastLine(lines);
            WriteLinesToFile("C:\\Практика КПиЯп\\Arabok_16\\Zad_3/Files/new_text_file.txt", linesExceptLast);

            int s1 = 2;
            int s2 = 4;
            PrintLinesInRange(lines, s1, s2);

            int maxLength = GetMaxLength(lines);
            Console.WriteLine($"Длина самой длинной строки: {maxLength} символов");

            char startingLetter = 'Т';
            PrintLinesStartingWithLetter(lines, startingLetter);

            ReverseLinesToFile(lines, "C:\\Практика КПиЯп\\Arabok_16\\Zad_3/Files/reversed_text_file.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void WriteLinesToFile(string filePath, string[] lines)
    {
        File.WriteAllLines(filePath, lines);
    }

    static void PrintFileContents(string filePath)
    {
        foreach (string line in File.ReadAllLines(filePath))
        {
            Console.WriteLine(line);
        }
    }

    static int GetLineCount(string filePath)
    {
        return File.ReadAllLines(filePath).Length;
    }

    static void PrintCharacterCountPerLine(string[] lines)
    {
        foreach (string line in lines)
        {
            Console.WriteLine($"Длина строки \"{line}\": {line.Length} символов");
        }
    }

    static string[] RemoveLastLine(string[] lines)
    {
        return lines.Take(lines.Length - 1).ToArray();
    }

    static void PrintLinesInRange(string[] lines, int start, int end)
    {
        for (int i = start - 1; i < end; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {lines[i]}");
        }
    }

    static int GetMaxLength(string[] lines)
    {
        return lines.Max(line => line.Length);
    }

    static void PrintLinesStartingWithLetter(string[] lines, char letter)
    {
        var filteredLines = lines.Where(line => line.StartsWith(letter));
        Console.WriteLine($"Строки, начинающиеся с буквы '{letter}':");
        foreach (string line in filteredLines)
        {
            Console.WriteLine(line);
        }
    }

    static void ReverseLinesToFile(string[] lines, string filePath)
    {
        Array.Reverse(lines);
        File.WriteAllLines(filePath, lines);
    }
}
