namespace ConsoleApp1;

public class CopyArray
{
    public void Copy()
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int length = nums.Length;

        int[] copy = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            copy[i] = nums[i];
        }
        
        Console.WriteLine(string.Join(" ", nums));
        Console.WriteLine(string.Join(" ", copy));
    }
}