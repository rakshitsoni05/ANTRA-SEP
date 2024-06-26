namespace ConsoleApp1;

public class Pyramid
{
    public void PrintPyramid()
    {
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}