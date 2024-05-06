class Program
{
    static void Main()
    {
        string filePath = "C:\\Практика КПиЯп\\Arabok_16\\Zad_6/Files/textfile.txt";

        string[] lines = File.ReadAllLines(filePath);

        int countSameStartEndLetter = lines.Count(line => line.Length > 0 && line.First() == line.Last());

        Console.WriteLine($"Количество строк, начинающихся и заканчивающихся одной буквой: {countSameStartEndLetter}");

        string longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault();
        int longestLineLength = longestLine?.Length ?? 0;

        Console.WriteLine($"Самая длинная строка: {longestLine}");
        Console.WriteLine($"Длина самой длинной строки: {longestLineLength}");

        string shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault();
        int shortestLineLength = shortestLine?.Length ?? 0;

        Console.WriteLine($"Самая короткая строка: {shortestLine}");
        Console.WriteLine($"Длина самой короткой строки: {shortestLineLength}");

        int longestLineIndex = Array.IndexOf(lines, longestLine) + 1;
        Console.WriteLine($"Номер самой длинной строки: {longestLineIndex}");

        char targetLetter = 'A'; 
        string lineStartingWithTargetLetter = lines.FirstOrDefault(line => line.Length > 0 && line.First() == targetLetter);

        if (lineStartingWithTargetLetter != null)
        {
            Console.WriteLine($"Строка, начинающаяся с буквы '{targetLetter}': {lineStartingWithTargetLetter}");
        }
        else
        {
            Console.WriteLine($"В файле нет строк, начинающихся с буквы '{targetLetter}'.");
        }
    }
}