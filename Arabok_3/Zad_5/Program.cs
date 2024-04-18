using System;
using System.Collections.Generic;

class Record
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string BirthDate { get; set; }
    public string PhoneNumber { get; set; }
}

class Notebook
{
    private List<Record> records;

    public Notebook()
    {
        records = new List<Record>();
    }

    public void AddRecord(Record record)
    {
        records.Add(record);
    }

    public void RemoveRecord(int index)
    {
        records.RemoveAt(index);
    }

    public Record FindRecordByLastName(string lastName)
    {
        return records.Find(record => record.LastName == lastName);
    }

    public void SortByLastName()
    {
        records.Sort((x, y) => x.LastName.CompareTo(y.LastName));
    }

    public Record GetRecordByIndex(int index)
    {
        return records[index];
    }

    public IEnumerator<Record> GetEnumerator()
    {
        foreach (Record record in records)
        {
            yield return record;
        }
    }
}

class Program
{
    static void Main()
    {
        Notebook notebook = new Notebook();

        Record record1 = new Record { LastName = "Арабок", FirstName = "Евгений", BirthDate = "19/03/2006", PhoneNumber = "123456789" };
        Record record2 = new Record { LastName = "Андрейчик", FirstName = "Егор", BirthDate = "05/07/2006", PhoneNumber = "987654321" };

        notebook.AddRecord(record1);
        notebook.AddRecord(record2);

        Console.WriteLine("Запись найдена по фамилии: ");
        Record foundRecord = notebook.FindRecordByLastName("Арабок");
        Console.WriteLine($"Фамилия: {foundRecord.LastName}, Имя: {foundRecord.FirstName}, Дата рождения: {foundRecord.BirthDate}, Номер телефона: {foundRecord.PhoneNumber}");

        Console.WriteLine("\nЗаписи перед сортировкой:");
        foreach (Record record in notebook)
        {
            Console.WriteLine($"Фамилия: {record.LastName}, Имя: {record.FirstName}, Дата рождения: {record.BirthDate}, Номер телефона: {record.PhoneNumber}");
        }

        notebook.SortByLastName();

        Console.WriteLine("\nЗаписи после сортировки по фамилии:");
        foreach (Record record in notebook)
        {
            Console.WriteLine($"Фамилия: {record.LastName}, Имя: {record.FirstName}, Дата рождения: {record.BirthDate}, Номер телефона: {record.PhoneNumber}");
        }

        Console.WriteLine("\nЗапись по индексу: ");
        Record selectedRecord = notebook.GetRecordByIndex(0);
        Console.WriteLine($"Фамилия: {selectedRecord.LastName}, Имя: {selectedRecord.FirstName}, Дата рождения: {selectedRecord.BirthDate}, Номер телефона: {selectedRecord.PhoneNumber}");
    }
}