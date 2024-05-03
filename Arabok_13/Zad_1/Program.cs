﻿namespace ColorMethods
{
    public delegate void ColorDelegate(string color);

    class Program
    {
        static void Red(string color)
        {
            Console.WriteLine($"Красный: {color}");
        }

        static void Green(string color)
        {
            Console.WriteLine($"Зеленый: {color}");
        }

        static void Blue(string color)
        {
            Console.WriteLine($"Синий: {color}");
        }

        static void Main()
        {
            ColorDelegate colorDelegate = Red;
            colorDelegate += Green;
            colorDelegate += Blue;

            colorDelegate("Яркий");
        }
    }
}