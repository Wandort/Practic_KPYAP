using System;
using System.Text.RegularExpressions;

namespace WordMatching
{
    class Program
    {
        static void Main()
        {
            string inputText = "Ого такое бывает чточ тут тут";

            string pattern = @"\b(\w)\w*\1\b";

            MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);

            Console.WriteLine("Слова, начинающиеся и заканчивающиеся одной и той же буквой:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}