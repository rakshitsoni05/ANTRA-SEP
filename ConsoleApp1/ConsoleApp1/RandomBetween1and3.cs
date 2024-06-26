namespace ConsoleApp1;

public class RandomBetween1and3
{
    public void RandomGenerator()
    {
        {
            int correctNumber = new Random().Next(3) + 1;

            Console.WriteLine("Guess the number between 1 and 3:");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range.");
            }
            else
            {
                if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }
            }
        }
    }
}