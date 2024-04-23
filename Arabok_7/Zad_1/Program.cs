using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Это вкусное яблоко и красивое озеро. Но не все слова такие.";

        string pattern = @"\b\w*[аеёиоуыэюяАЕЁИОУЫЭЮЯ]{2,}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Слова, оканчивающиеся на несколько подряд идущих гласных:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}