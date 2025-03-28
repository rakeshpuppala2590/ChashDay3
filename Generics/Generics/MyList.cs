namespace Generics;
using System;

/*2. Create a Generic List data structure MyList<T> that can store any data type.
   Implement the following methods.
   1. void Add (T element)
   2. T Remove (int index)
   3. bool Contains (T element)
   4. void Clear ()
   5. void InsertAt (T element, int index)
   6. void DeleteAt (int index)
   7. T Find (int index) */
public class MyList<T>
{
    private List<T> _l = new List<T>();
    public void Add(T item)
    {
        _l.Add(item);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= _l.Count)
        {
            Console.WriteLine("Index out of range");
            throw new IndexOutOfRangeException(nameof(index));
        }
        T item = _l[index];
        _l.RemoveAt(index);
        return item;
    }

    public bool Contains(T item)
    {
        return _l.Contains(item);
    }

    public void Clear()
    {
        _l.Clear();
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index >= _l.Count)
        {
            Console.WriteLine("Index out of range");
            throw new IndexOutOfRangeException(nameof(index));
        }
        _l.Insert(index, item);
    }

    void DeleteAt(int index)
    {
        if (index < 0 || index >= _l.Count)
        {
            Console.WriteLine("Index out of range");
            throw new IndexOutOfRangeException(nameof(index));
        }
        _l.RemoveAt(index);
    }

    T Find(int index)
    {
        if (index < 0 || index >= _l.Count)
        {
            Console.WriteLine("No such item at the index");
            throw new IndexOutOfRangeException(nameof(index));
        }
        return _l[index];
    }
    
}