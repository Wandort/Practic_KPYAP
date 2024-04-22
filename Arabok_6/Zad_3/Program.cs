class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        if (words.Length >= 3)
        {
            words[1] = words[1] + words[2];
            words = words.Where((word, index) => index != 2).ToArray();
        }

        if (words.Length >= 3)
        {
            char[] wordArray = words[2].ToCharArray();
            Array.Reverse(wordArray);
            words[2] = new string(wordArray);
        }

        if (words[0].Length >= 2)
        {
            words[0] = words[0].Substring(2);
        }

        string result = string.Join(" ", words);

        Console.WriteLine("Результат: " + result);
    }
}