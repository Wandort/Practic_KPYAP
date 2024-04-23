using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Текст здесь слова слова. Это предложение содержит повторяющиеся слова слова.";

        string[] sentences = Regex.Split(text, @"(?<=[.!?])\s+");

        foreach (string sentence in sentences)
        {
            string[] words = Regex.Split(sentence, @"\W+");
            var wordSet = new HashSet<string>();
            bool hasDuplicate = false;

            foreach (string word in words)
            {
                if (!wordSet.Add(word))
                {
                    hasDuplicate = true;
                    break;
                }
            }

            if (hasDuplicate)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}