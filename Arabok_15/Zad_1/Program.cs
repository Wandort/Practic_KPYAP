using System;

public class MyCustomList<T>
{
    private T[] _items;

    public MyCustomList()
    {
        _items = new T[0];
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }
    }

    public int Count
    {
        get
        {
            return _items.Length;
        }
    }

    public void Add(T item)
    {
        T[] newItems = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newItems[i] = _items[i];
        }
        newItems[Count] = item;
        _items = newItems;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCustomList<int> customList = new MyCustomList<int>();
        customList.Add(1);
        customList.Add(2);
        customList.Add(3);
        Console.WriteLine("Количество элементов: " + customList.Count);
        Console.WriteLine("Элемент с индексом 1: " + customList[1]);
    }
}
