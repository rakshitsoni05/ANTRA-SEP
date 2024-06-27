namespace ConsoleApp3;

public class ReverseAndPrint
{
    
    public int[] GenerateNumbers(int length)
    {
        int[] nums = new int[length];
        for (int i = 0; i < length; i++)
        {
            nums[i] = i + 1;
        }
        return nums;
    }

    
    public void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }
    
    public void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}