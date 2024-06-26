namespace ConsoleApp1;

public class MostFrequent
{
    public void CountMostFrequent()
    {
        Console.WriteLine("Enter array elements (space-separated):");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

       
        int currNum = array[0];
        int maxFreq = 1;
        int currFreq = 1;
        
        Array.Sort(array);
        
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currFreq++;
            }
            else
            {
                if (currFreq > maxFreq)
                {
                    maxFreq = currFreq;
                    currNum = array[i - 1];
                   
                }
                currFreq = 1;
            }
        }

        
        if (currFreq > maxFreq)
        {
            maxFreq = currFreq;
            currNum = array[array.Length - 1];
            
        }
        
        Console.WriteLine($"The number {currNum} is the most frequent (occurs {maxFreq} times)");
    }
}
