﻿using zad1;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle();
        triangle.InputSides(3, 4, 5);
        Console.WriteLine("Периметр треугольника: " + triangle.Perimeter());
        Console.WriteLine("Прощадь треугольника: " + triangle.Area());
        Console.WriteLine("Тип треугольника: " + triangle.TypeOfTriangle());

        Rectangle rectangle = new Rectangle();
        rectangle.InputSides(4, 5);
        Console.WriteLine("Периметр прямоугольниа: " + rectangle.Perimeter());
        Console.WriteLine("Площадь прямоугольника: " + rectangle.Area());
    }
}