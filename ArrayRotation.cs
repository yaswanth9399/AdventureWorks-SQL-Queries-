using System;
using System.Linq;

class ArrayRotation
{
    public static void Run()
    {
        Console.WriteLine("Enter space-separated integers:");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine("Enter number of rotations:");
        int k = int.Parse(Console.ReadLine());
        
        int n = arr.Length;
        int[] sum = new int[n];

        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotated[(i + 1) % n] = arr[i];
            }
            Array.Copy(rotated, arr, n);
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotated[i];
            }
            Console.WriteLine($"Rotated{r}[]: " + string.Join(" ", rotated));
        }
        
        Console.WriteLine("Sum[]: " + string.Join(" ", sum));
    }
}
