namespace ConsoleApp1;

public class LongestSubsequence
{
    public void Subsequence()
    {
        Console.WriteLine("Enter array elements (space-separated):");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        int longestStartIndex = 0;
        int longestLength = 1;

        int currentStartIndex = 0;
        int currentLength = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestStartIndex = currentStartIndex;
                }

                currentStartIndex = i;
                currentLength = 1;
            }
        }

        
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStartIndex = currentStartIndex;
        }

        
        Console.WriteLine("Longest sequence of equal elements:");
        for (int i = 0; i < longestLength; i++)
        {
            Console.Write(array[longestStartIndex] + " ");
        }
        Console.WriteLine();
    }
}
    
