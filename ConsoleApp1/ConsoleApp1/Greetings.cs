namespace ConsoleApp1;

public class Greetings
{
    public void Greet()
    {
        DateTime currentTime = DateTime.Now;
        
        int hour = currentTime.Hour;
        
        if (hour >= 5 && hour < 11)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 11 && hour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (hour >= 17 && hour < 20)
        {
            Console.WriteLine("Good Evening");
        }
        if (hour >= 20 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }
    }
}