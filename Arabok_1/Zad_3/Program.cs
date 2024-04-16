namespace Zad_3;
class Program
{
    static void Main()
    {
        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());

        string category;

        if (age < 1)
        {
            category = "младенец";
        }
        else if (age <= 11)
        {
            category = "ребенок";
        }
        else if (age <= 15)
        {
            category = "подросток";
        }
        else if (age <= 25)
        {
            category = "юноша";
        }
        else if (age <= 70)
        {
            category = "мужчина";
        }
        else
        {
            category = "старик";
        }

        Console.WriteLine($"Возрастная категория: {category}");
    }
}