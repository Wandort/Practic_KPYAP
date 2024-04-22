class Program
{
    static void Main()
    {
        string text = "Привет.как дела,у тебя";

        HashSet<char> punctuationMarks = new HashSet<char> { '.', '!', '?', ',', ';', ':', '(', ')' };

        int errorCount = 0;

        for (int i = 0; i < text.Length - 1; i++)
        {
            char currentChar = text[i];
            char nextChar = text[i + 1];

            if (punctuationMarks.Contains(currentChar))
            {
                if (nextChar != ' ')
                {
                    errorCount++;
                }
            }
        }

        Console.WriteLine($"Общее количество ошибок: {errorCount}");
    }
}