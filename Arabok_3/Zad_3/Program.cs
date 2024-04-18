using System;

class TwoDimArray
{
    private int[,] array;
    private int rows;
    private int cols;

    public TwoDimArray(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        array = new int[rows, cols];
    }

    public void FillArray()
    {
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(1, 100);
            }
        }
    }

    public void PrintArray()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void Modulo(int divisor)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = array[i, j] % divisor;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        TwoDimArray arr = new TwoDimArray(3, 3);
        arr.FillArray();
        Console.WriteLine("Начальный массив:");
        arr.PrintArray();

        int divisor = 5;
        arr.Modulo(divisor);
        Console.WriteLine($"\nМассив с остатками после деления на {divisor}:");
        arr.PrintArray();
    }
}