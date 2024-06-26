namespace ConsoleApp1;

public class StringReverse
{
    public void ReverseCharArray()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        Console.WriteLine("Reversed string :"+reversed);
       
    }

    public void ReverseBack()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        
        Console.WriteLine("Reversed string:");
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}