namespace ConsoleApp1;

public class PrimeNumbers
{
    public int[] FindPrimesInRange(int startNum, int endNum)
    {
        int[] primeList = new int[endNum-startNum];
        int count = 0;
        for (int i = startNum; i <= endNum; i++)
        {
            if (CheckPrime(i)== true)
            {
                primeList[count] = i;
                count++;
            }
            
        }

        return primeList;
    }

    bool CheckPrime(int num)
    {
        bool isPrime = true;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                return isPrime;
            }
        }

        return isPrime;
    }
}