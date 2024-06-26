namespace ConsoleApp1;

public class BirthDateCalculator
{
    public void BirthDate()
    {
        DateTime birthDate = new DateTime(1990, 3, 15);
        
        TimeSpan ageInDays = DateTime.Today - birthDate;
        int daysOld = ageInDays.Days;

        Console.WriteLine($"You are {daysOld} days old.");
        
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);

        Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary:d}.");
    }
}