using System;
using System.Collections.Generic;

public class CustomList<T>
{
    private List<T> _items = new List<T>();

    public T this[int index] => _items[index];

    public int Count => _items.Count;

    public void Add(T item)
    {
        _items.Add(item);
    }
}

public static class CustomListExtensions
{
    public static T[] ToArray<T>(this CustomList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomList<int> customList = new CustomList<int>();
        customList.Add(1);
        customList.Add(2);
        customList.Add(3);

        int[] array = customList.ToArray();
        Console.Write("Элементы массива: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}