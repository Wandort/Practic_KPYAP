class Program
{
    static int GetDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static int CalculatePersonCode(string fullName)
    {
        string cleanedName = fullName.Replace(" ", "").ToUpper();

        int code = 0;
        foreach (char c in cleanedName)
        {
            if (char.IsLetter(c))
            {
                int letterValue = c - 'A' + 1;
                code += letterValue;
            }
        }

        while (code >= 10)
        {
            code = GetDigitSum(code);
        }

        return code;
    }

    static void Main()
    {
        Console.WriteLine("Введите фамилию, имя и отчество пользователя:");
        string fullName = Console.ReadLine();

        int personCode = CalculatePersonCode(fullName);
        Console.WriteLine($"Код личности: {personCode}");
    }
}