using System;

class Program
{
    static void Main()
    {
        int number = 123;

        Task task1 = new Task(number);
        Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {task1.ReverseDigits()}");

        Task task2 = new Task { Number = number };
        Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {task2.ReverseDigits()}");

        Task task3 = Task.CreateTask(number);
        Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {task3.ReverseDigits()}");
    }
}

class Task
{
    public int Number { get; set; }

    public Task() { }

    public Task(int number)
    {
        Number = number;
    }

    public int ReverseDigits()
    {
        int reversedNumber = 0;
        int tempNumber = Number;

        while (tempNumber > 0)
        {
            int digit = tempNumber % 10;
            reversedNumber = reversedNumber * 10 + digit;
            tempNumber /= 10;
        }

        return reversedNumber;
    }

    public static Task CreateTask(int number)
    {
        return new Task(number);
    }
}
