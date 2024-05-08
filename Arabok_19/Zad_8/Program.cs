/// <summary>
/// Класс, представляющий программу для выполнения операций над строками.
/// </summary>
class Program
{
    /// <summary>
    /// Метод 1: Выводит длину строки.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    static void Method1(string str)
    {
        Console.WriteLine($"Метод 1: Длина строки равна {str.Length}");
    }

    /// <summary>
    /// Метод 2: Выводит строку в верхнем регистре.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    static void Method2(string str)
    {
        Console.WriteLine($"Метод 2: Строка в верхнем регистре - {str.ToUpper()}");
    }

    /// <summary>
    /// Метод 3: Выводит обратную строку.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    static void Method3(string str)
    {
        Console.WriteLine($"Метод 3: Обратная строка - {ReverseString(str)}");
    }

    /// <summary>
    /// Возвращает обратную строку.
    /// </summary>
    /// <param name="str">Входная строка.</param>
    /// <returns>Обратная строка.</returns>
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        // Пример использования методов
        // ...
    }
}
