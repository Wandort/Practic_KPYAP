using System;
using System.Collections.Generic;

class Settlement
{
    public string Name { get; set; }

    public Settlement(string name)
    {
        Name = name;
    }

    public virtual void DisplayResults()
    {
        Console.WriteLine("Населенный пункт: " + Name);
    }
}

class Village : Settlement
{
    public int NumberOfHouses { get; set; }
    public int ResidentsPerHouse { get; set; }
    public double Area { get; set; }

    public Village(string name, int numberOfHouses, int residentsPerHouse, double area) : base(name)
    {
        NumberOfHouses = numberOfHouses;
        ResidentsPerHouse = residentsPerHouse;
        Area = area;
    }

    public override void DisplayResults()
    {
        base.DisplayResults();
        Console.WriteLine("Количество домов: " + NumberOfHouses);
        Console.WriteLine("Жителей на дом: " + ResidentsPerHouse);
        Console.WriteLine("Площадь: " + Area);
    }

    public double PopulationDensity()
    {
        return (NumberOfHouses * ResidentsPerHouse) / Area;
    }
}

class City : Settlement
{
    public int NumberOfResidents { get; set; }
    public double Area { get; set; }

    public City(string name, int numberOfResidents, double area) : base(name)
    {
        NumberOfResidents = numberOfResidents;
        Area = area;
    }

    public override void DisplayResults()
    {
        base.DisplayResults();
        Console.WriteLine("Количество жителей: " + NumberOfResidents);
        Console.WriteLine("Площадь: " + Area);
    }

    public double PopulationDensity()
    {
        return NumberOfResidents / Area;
    }
}

class Program
{
    static void Main()
    {
        List<Settlement> settlements = new List<Settlement>();

        settlements.Add(new Village("Деревня А", 50, 4, 100));
        settlements.Add(new City("Город X", 1000, 500));

        foreach (Settlement settlement in settlements)
        {
            settlement.DisplayResults();
            if (settlement is Village)
            {
                Village village = (Village)settlement;
                Console.WriteLine("Плотность населения: " + village.PopulationDensity());
            }
            else if (settlement is City)
            {
                City city = (City)settlement;
                Console.WriteLine("Плотность населения: " + city.PopulationDensity());
            }
            Console.WriteLine();
        }
    }
}