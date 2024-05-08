using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Rectangle
    {
        private double a, b;

        public void InputSides(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Perimeter()
        {
            return 2 * (a + b);
        }

        public double Area()
        {
            return a * b;
        }
    }
}