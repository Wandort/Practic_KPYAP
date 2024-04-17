using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Worker : Person
{
    public string Occupation { get; set; }
    public double Salary { get; set; }
}

class HR : Person
{
    public string Department { get; set; }
    public int YearsOfService { get; set; }
}

class Engineer : Person
{
    public string Specialization { get; set; }
    public string Project { get; set; }
}

class Administration : Person
{
    public string Position { get; set; }
    public string Responsibilities { get; set; }
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker
        {
            Name = "Иван",
            Age = 30,
            Occupation = "Механик",
            Salary = 50000
        };

        HR hrPerson = new HR
        {
            Name = "Анна",
            Age = 28,
            Department = "Отдел кадров",
            YearsOfService = 5
        };

        Engineer engineer = new Engineer
        {
            Name = "Петр",
            Age = 35,
            Specialization = "Разработка программного обеспечения",
            Project = "Проект XYZ"
        };

        Administration admin = new Administration
        {
            Name = "Елена",
            Age = 40,
            Position = "Менеджер офиса",
            Responsibilities = "Контроль за ежедневной деятельностью"
        };

        Console.WriteLine("Информация о персонах:");
        Console.WriteLine($"Рабочий: {worker.Name}, Зарплата: {worker.Salary:C}");
        Console.WriteLine($"HR: {hrPerson.Name}, Стаж: {hrPerson.YearsOfService} года");
        Console.WriteLine($"Инженер: {engineer.Name}, Специализация: {engineer.Specialization}");
        Console.WriteLine($"Администрация: {admin.Name}, Должность: {admin.Position}");

        Console.ReadLine();
    }
}