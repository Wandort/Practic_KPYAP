class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

class Triangle
{
    private Point A;
    private Point B;
    private Point C;

    public Triangle(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        double sideAB = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        double sideBC = Math.Sqrt(Math.Pow(C.X - B.X, 2) + Math.Pow(C.Y - B.Y, 2));
        double sideCA = Math.Sqrt(Math.Pow(A.X - C.X, 2) + Math.Pow(A.Y - C.Y, 2));

        double s = (sideAB + sideBC + sideCA) / 2;
        return Math.Sqrt(s * (s - sideAB) * (s - sideBC) * (s - sideCA));
    }

    public void Move(double dx, double dy)
    {
        A.X += dx;
        A.Y += dy;
        B.X += dx;
        B.Y += dy;
        C.X += dx;
        C.Y += dy;
    }

    public void Resize(double factor)
    {
        A.X *= factor;
        A.Y *= factor;
        B.X *= factor;
        B.Y *= factor;
        C.X *= factor;
        C.Y *= factor;
    }

    public void Rotate(double angleDegrees)
    {
        double angleRadians = angleDegrees * Math.PI / 180;
        double cosA = Math.Cos(angleRadians);
        double sinA = Math.Sin(angleRadians);

        double newX, newY;

        newX = A.X * cosA - A.Y * sinA;
        newY = A.X * sinA + A.Y * cosA;
        A.X = newX;
        A.Y = newY;

        newX = B.X * cosA - B.Y * sinA;
        newY = B.X * sinA + B.Y * cosA;
        B.X = newX;
        B.Y = newY;

        newX = C.X * cosA - C.Y * sinA;
        newY = C.X * sinA + C.Y * cosA;
        C.X = newX;
        C.Y = newY;
    }

    public Point PointA => A;
    public Point PointB => B;
    public Point PointC => C;
}

class Program
{
    static void Main()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(1.5, 2);

        Triangle myTriangle = new Triangle(a, b, c);

        Console.WriteLine($"Площадь треугольника: {myTriangle.CalculateArea()}");

        myTriangle.Move(2, 1);
        Console.WriteLine($"Новые координаты точки A: ({myTriangle.PointA.X}, {myTriangle.PointA.Y})");

        myTriangle.Resize(1.5);
        Console.WriteLine($"Новые координаты точки B: ({myTriangle.PointB.X}, {myTriangle.PointB.Y})");

        myTriangle.Rotate(45);
        Console.WriteLine($"Новые координаты точки C: ({myTriangle.PointC.X}, {myTriangle.PointC.Y})");
    }
}