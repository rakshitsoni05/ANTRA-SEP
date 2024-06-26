using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class ExtractPalindromes
{
    public void Palindromes()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();
        string[] words = Regex.Split(input, @"\W+");
        
        HashSet<string> palindromes = new HashSet<string>();
        
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        
        List<string> sortedPalindromes = palindromes.ToList();
        sortedPalindromes.Sort();
        
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - 1 - i])
            {
                return false;
            }
        }
        return length > 0;
    }
    }
