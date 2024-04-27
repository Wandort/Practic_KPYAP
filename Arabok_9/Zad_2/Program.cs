using System;
using System.Collections.Generic;

class Car : IComparable<Car>
{
    public string LicensePlate { get; set; }
    public string Color { get; set; }
    public string OwnerLastName { get; set; }
    public bool IsPresent { get; set; }

    public int CompareTo(Car other)
    {
        return LicensePlate.CompareTo(other.LicensePlate);
    }
}

class ParkingLot
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public Car FindCarByLicensePlate(string licensePlate)
    {
        return cars.Find(car => car.LicensePlate == licensePlate);
    }

    public List<Car> GetPresentCars()
    {
        return cars.FindAll(car => car.IsPresent);
    }

    public List<Car> GetAbsentCars()
    {
        return cars.FindAll(car => !car.IsPresent);
    }
}

class Program
{
    static void Main()
    {
        ParkingLot parkingLot = new ParkingLot();

        parkingLot.AddCar(new Car { LicensePlate = "ABC123", Color = "Red", OwnerLastName = "Smith", IsPresent = true });
        parkingLot.AddCar(new Car { LicensePlate = "XYZ789", Color = "Blue", OwnerLastName = "Johnson", IsPresent = false });

        Car foundCar = parkingLot.FindCarByLicensePlate("ABC123");
        if (foundCar != null)
        {
            Console.WriteLine($"Найден автомобиль: {foundCar.Color} {foundCar.LicensePlate}");
        }
        else
        {
            Console.WriteLine("Автомобиль не найден.");
        }

        List<Car> presentCars = parkingLot.GetPresentCars();
        List<Car> absentCars = parkingLot.GetAbsentCars();

        Console.WriteLine("Присутствующие автомобили:");
        foreach (var car in presentCars)
        {
            Console.WriteLine($"{car.Color} {car.LicensePlate}");
        }

        Console.WriteLine("Отсутствующие автомобили:");
        foreach (var car in absentCars)
        {
            Console.WriteLine($"{car.Color} {car.LicensePlate}");
        }
    }
}