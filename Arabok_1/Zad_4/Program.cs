class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица соответствия веса (фунты -> килограммы):");
        Console.WriteLine("Фунты\tКилограммы");

        //Цикл for
        for (int pounds = 1; pounds <= 100; pounds++)
        {
            double kilograms = pounds * 0.453;
            Console.WriteLine($"{pounds}\t{kilograms:F3}");
        }

        //Цикл while
        int poundsWhile = 1;
        while (poundsWhile <= 100)
        {
            double kilogramsWhile = poundsWhile * 0.453;
            Console.WriteLine($"{poundsWhile}\t{kilogramsWhile:F3}");
            poundsWhile++;
        }

        //Цикл do while
        int poundsDoWhile = 1;
        do
        {
            double kilogramsDoWhile = poundsDoWhile * 0.453;
            Console.WriteLine($"{poundsDoWhile}\t{kilogramsDoWhile:F3}");
            poundsDoWhile++;
        } while (poundsDoWhile <= 100);
    }
}