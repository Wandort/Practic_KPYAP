class Prototype<T>
{
    private List<T> items;

    public Prototype()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public Prototype<T> Clone()
    {
        Prototype<T> clone = new Prototype<T>();
        foreach (T item in items)
        {
            clone.Add(item);
        }
        return clone;
    }

    public void DisplayItems()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        Prototype<int> intPrototype = new Prototype<int>();
        intPrototype.Add(10);
        intPrototype.Add(20);
        intPrototype.Add(30);

        Console.WriteLine("Исходный список:");
        intPrototype.DisplayItems();

        intPrototype.Remove(20);
        Console.WriteLine("\nПосле удаления элемента 20:");
        intPrototype.DisplayItems();

        Prototype<int> clonedIntPrototype = intPrototype.Clone();
        Console.WriteLine("\nКлонированный список:");
        clonedIntPrototype.DisplayItems();

        int? nullableInt = null;
        Console.WriteLine($"\nОбнуляемый тип int?: {nullableInt}");

        List<string> stringList = new List<string> { "apple", "banana", "cherry" };
        Dictionary<string, int> fruitCount = new Dictionary<string, int>
        {
            { "apple", 5 },
            { "banana", 3 },
            { "cherry", 8 }
        };

        Console.WriteLine("\nСписок фруктов:");
        foreach (string fruit in stringList)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\nКоличество фруктов:");
        foreach (var kvp in fruitCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}