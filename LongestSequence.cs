using System;
using System.Linq;

class LongestSequence
{
    public static void Run()
    {
        Console.WriteLine("Enter space-separated integers:");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxLength = 1, currentLength = 1, startIndex = 0, maxStartIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
                startIndex = i;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = startIndex;
            }
        }

        Console.WriteLine("Longest sequence:");
        for (int i = maxStartIndex; i < maxStartIndex + maxLength; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
