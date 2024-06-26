namespace ConsoleApp1;

public class Exercise03
{
    public void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public void Check()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
            // When i reaches 255 (the maximum value for a byte), it wraps around to 0 due to overflow.
            //This causes an infinite loop because i will never be greater than or equal to max (500).
        {
            if (i == byte.MaxValue)  // we can add a check and break
            {
                Console.WriteLine("Warning: Loop may not terminate as expected due to byte overflow."); 
                break; 
            }
            Console.WriteLine(i);
        }
       
    }
    
    
   
}

