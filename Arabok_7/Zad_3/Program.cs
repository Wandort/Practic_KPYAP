using System.Text.RegularExpressions;

namespace SentenceFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = @"
                Повторяющиеся слова: тестовое и предложение.
                Еще один пример: привет привет мир мир.
                Короткое предложение.
                Это предложение содержит ровно шесть слов.
            ";

            int n = 5;

            string[] sentences = inputText.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new System.Collections.Generic.List<string>();

            string wordPattern = @"\b\w+\b";

            foreach (var sentence in sentences)
            {
                int wordCount = Regex.Matches(sentence, wordPattern).Count;
                if (wordCount >= n)
                {
                    result.Add(sentence.Trim());
                }
            }

            foreach (var sentence in result)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}