using System;
using System.Collections.Generic;

public class CustomDictionary<TKey, TValue>
{
    private List<TKey> keys;
    private List<TValue> values;

    public CustomDictionary()
    {
        keys = new List<TKey>();
        values = new List<TValue>();
    }

    public TValue this[TKey key]
    {
        get
        {
            int index = keys.IndexOf(key);
            if (index == -1)
            {
                throw new KeyNotFoundException();
            }
            return values[index];
        }
    }

    public int Count
    {
        get
        {
            return keys.Count;
        }
    }

    public void Add(TKey key, TValue value)
    {
        if (keys.Contains(key))
        {
            throw new ArgumentException("Элемент с таким же ключом уже существует");
        }
        keys.Add(key);
        values.Add(value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomDictionary<string, int> customDictionary = new CustomDictionary<string, int>();
        customDictionary.Add("one", 1);
        customDictionary.Add("two", 2);
        customDictionary.Add("three", 3);
        Console.WriteLine("Количество пар ключ-значение: " + customDictionary.Count);
        Console.WriteLine("Значение для ключа \"два\": " + customDictionary["two"]);
    }
}
