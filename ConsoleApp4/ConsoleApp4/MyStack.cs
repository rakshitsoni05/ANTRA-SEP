using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> MyStck = new List<T>();
    
    public int Count()
    {
        return MyStck.Count;
    }
    
    public T Pop()
    {
        if (MyStck.Count == 0)
        {
            Console.WriteLine("The stack is empty.");
            return default(T);
        }
        
        T value = MyStck[MyStck.Count - 1];
        
        MyStck.RemoveAt(MyStck.Count - 1);

        return value;
    }
    
    public void Push(T item)
    {
        MyStck.Add(item);
    }
}