using System;

delegate void StringDelegate(string str);

class Program
{
    static void Main()
    {
        StringDelegate stringDelegate = Method1;
        stringDelegate += Method2;
        stringDelegate += Method3;

        string inputString = "Привет, мир!";

        stringDelegate(inputString);
    }

    static void Method1(string str)
    {
        Console.WriteLine($"Метод 1: Длина строки равна {str.Length}");
    }

    static void Method2(string str)
    {
        Console.WriteLine($"Метод 2: Строка в верхнем регистре - {str.ToUpper()}");
    }

    static void Method3(string str)
    {
        Console.WriteLine($"Метод 3: Обратная строка - {ReverseString(str)}");
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}