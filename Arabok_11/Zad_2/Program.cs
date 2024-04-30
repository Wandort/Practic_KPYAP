abstract class FuelConsumption
{
    public string VehicleName { get; set; }
    public double FuelUsed { get; set; }

    public abstract double CalculateFuelConsumption();
}

class Car : FuelConsumption
{
    public Car(string name, double fuelUsed)
    {
        VehicleName = name;
        FuelUsed = fuelUsed;
    }

    public override double CalculateFuelConsumption()
    {
        return FuelUsed;
    }
}

class Truck : FuelConsumption
{
    public Truck(string name, double fuelUsed)
    {
        VehicleName = name;
        FuelUsed = fuelUsed;
    }

    public override double CalculateFuelConsumption()
    {
        return FuelUsed;
    }
}

class Program
{
    static void Main()
    {
        FuelConsumption[] vehicles = new FuelConsumption[]
        {
            new Car("Toyota Camry", 10.5),
            new Truck("Volvo FH16", 25.0),
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Транспортное средство: {vehicle.VehicleName}, Использовано топлива: {vehicle.CalculateFuelConsumption()} литров");
        }
    }
}