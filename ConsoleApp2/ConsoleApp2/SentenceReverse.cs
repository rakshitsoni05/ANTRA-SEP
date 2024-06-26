using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class SentenceReverse
{
    public void Reverse()
    {

        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        
        string separatorsPattern = @"([.,:;=\(\)&\[\]""'\\\/!? ]+)";
        
        string[] parts = Regex.Split(input, separatorsPattern);
        string reversedSentence = "";

        
        for (int i = parts.Length - 1; i >= 0; i--)
        {
            
            reversedSentence += parts[i];
        }
        
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversedSentence);
    }
}