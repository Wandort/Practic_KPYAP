﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Triangle
    {
        private double a, b, c;

        public void InputSides(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool CheckExistence()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string TypeOfTriangle()
        {
            if (a == b && b == c)
                return "Равносторонний";
            else if (a == b || b == c || a == c)
                return "Равнобедренный";
            else
                return "Разностронний";
        }
    }
}