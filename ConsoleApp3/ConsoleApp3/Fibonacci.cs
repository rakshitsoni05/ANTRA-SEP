namespace ConsoleApp3;

public class Fibonacci
{
    public int FibonacciSeries(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
    }
    
}