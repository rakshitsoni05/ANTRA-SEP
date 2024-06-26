namespace ConsoleApp1;

public class RotatedArray
{
    public void Rotate()
    {
        {
            Console.WriteLine("Enter array elements (space-separated):");
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Enter number of rotations:");
            int k = int.Parse(Console.ReadLine());

            
            int[] sum = new int[array.Length];

            
            for (int r = 1; r <= k; r++)
            {
                int[] rotated = RotateArray(array, r);
                for (int i = 0; i < array.Length; i++)
                {
                    sum[i] += rotated[i];
                }
            }

            
            Console.WriteLine("Sum array:");
            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] RotateArray(int[] array, int r)
        {
            int n = array.Length;
            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + r) % n] = array[i];
            }

            return rotated;
        }
    }
}
