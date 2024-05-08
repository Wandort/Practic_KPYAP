/// <summary>
/// Класс, представляющий делегат для вычисления характеристик фигуры.
/// </summary>
public delegate double CalcFigure(double radius);

class Program
{
    /// <summary>
    /// Вычисляет длину окружности по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    public static double Get_Length(double radius)
    {
        return 2 * Math.PI * radius;
    }

    /// <summary>
    /// Вычисляет площадь круга по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    public static double Get_Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    /// <summary>
    /// Вычисляет объем шара по заданному радиусу.
    /// </summary>
    /// <param name="radius">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
    public static double Get_Volume(double radius)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    static void Main()
    {
        CalcFigure CF;

        CF = Get_Length;
        Console.WriteLine($"Длина окружности при радиусе 5: {CF(5)}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга при радиусе 5: {CF(5)}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара при радиусе 5: {CF(5)}");
    }
}
