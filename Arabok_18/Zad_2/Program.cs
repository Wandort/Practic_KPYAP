class Program
{
    static void Main()
    {
        // файл содержит числа, разделенные пробелами
        string filePath = "C:\\Практика КПиЯп\\Arabok_18\\Zad_2/numbers.txt";
        int a = 5;
        int b = 10;

        Queue<int> intervalQueue = new Queue<int>();
        Queue<int> lessThanAQueue = new Queue<int>();

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] numbers = line.Split(' ');
            foreach (string numStr in numbers)
            {
                if (int.TryParse(numStr, out int num))
                {
                    if (num >= a && num <= b)
                    {
                        intervalQueue.Enqueue(num);
                    }
                    else if (num < a)
                    {
                        lessThanAQueue.Enqueue(num);
                    }
                }
            }
        }

        Console.WriteLine("Числа из интервала [a, b]:");
        while (intervalQueue.Count > 0)
        {
            Console.Write(intervalQueue.Dequeue() + " ");
        }

        Console.WriteLine("\nЧисла меньше a:");
        while (lessThanAQueue.Count > 0)
        {
            Console.Write(lessThanAQueue.Dequeue() + " ");
        }
    }
}