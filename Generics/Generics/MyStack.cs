namespace Generics;
using System;

/* 1. Create a custom Stack class MyStack<T> that can be used with any data type which
   has following methods
   1. int Count()
   2. T Pop()
   3. Void Push() */

public class MyStack<T>
{
    private List<T> _l = new List<T>();
    
    public int Count() => _l.Count;

    public void Push(T item)=>_l.Add(item);

    public T Pop()
    {
        if (_l.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T item = _l[_l.Count - 1];
        _l.RemoveAt(_l.Count - 1);
        return item;
    }
}