class Program
{
    static void Main()
    {
        byte n = 1;
        byte i;
        try
        {
            checked
            {
                n = 1;
                for (i = 1; i < 10; i++)
                    n *= i;
                Console.WriteLine($"1: {n}");
            }
            // Программа сначала проверяет переполнение в блоке checked, а затем выполняет второй цикл без проверки.
            // Если переполнение произойдет в первом цикле, будет сгенерировано исключение OverflowException
            // Второй цикл не проверяет переполнение и может привести к некорректным результатам, если переполнение произойдет.
            for (i = 1; i < 10; i++)
                n *= i;
            Console.WriteLine($"2: {n}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Переполнение произошло.");
        }
    }
}
