using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "Сделай анализ";

        Dictionary<char, int> charFreq = new Dictionary<char, int>();

        foreach (char c in text)
        {
            if (charFreq.ContainsKey(c))
                charFreq[c]++;
            else
                charFreq[c] = 1;
        }

        foreach (var pair in charFreq)
        {
            Console.WriteLine($"'{pair.Key}': {pair.Value}");
        }
    }
}