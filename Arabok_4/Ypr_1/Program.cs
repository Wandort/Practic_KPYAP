class Program
{
    static void Main()
    {
        byte n = 1;
        byte i;
        try
        {
            
            for (i = 1; i < 10; i++)
                n *= i;
            Console.WriteLine($"1: {n}");

            // Теперь программа будет проверять переполнение при выполнении арифметических операций.
            // Если переполнение произойдет, будет сгенерировано исключение OverflowException.
            // В данном случае, при выполнении операции(200 + 200) в блоке checked, переполнение произойдет
            // и будет выведено сообщение “Переполнение произошло”.
            checked
            {
                n = 1;
                for (i = 1; i < 10; i++)
                    n *= i;
                Console.WriteLine($"2: {n}");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Переполнение произошло");
        }
    }
}