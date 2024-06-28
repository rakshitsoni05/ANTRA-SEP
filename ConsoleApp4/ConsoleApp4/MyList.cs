namespace ConsoleApp4;

public class MyList<T>
{
    private List<T> elements = new List<T>();

    public void Add(T element)
    {
        elements.Add(element);
    }

    public T Remove(int index)
    {
        if (index > 0 && index < elements.Count)
        {
            T element = elements[index];
            elements.RemoveAt(index);
            return element;
        }
        else
        {
            Console.WriteLine("Cannot remove.");
            return default(T); 
        }

       
    }

   public bool Contains(T element)
    {
        return elements.Contains(element);
    }

   public void Clear()
    {
        elements.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index > 0 && index < elements.Count)
        {
            elements.Insert(index,element);
        }
        else
        {
            Console.WriteLine("Cannot insert.");
        }
    }

   public void DeleteAt(int index)
    {
        if (index > 0 && index < elements.Count)
        {
            elements.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Cannot remove.");
        }
    }

    public T Find(int index)
    {
        if (index > 0 && index < elements.Count)
        {
            return elements[index];
        }
        else
        {
            return default(T);
        }
    }
}