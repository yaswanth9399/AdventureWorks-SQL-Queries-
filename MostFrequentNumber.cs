using System;
using System.Linq;
using System.Collections.Generic;

class MostFrequentNumber
{
    public static void Run()
    {
        Console.WriteLine("Enter space-separated integers:");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int maxFrequency = 0, mostFrequentNum = arr[0];

        foreach (int num in arr)
        {
            if (!frequency.ContainsKey(num))
                frequency[num] = 0;
            
            frequency[num]++;
            
            if (frequency[num] > maxFrequency || 
                (frequency[num] == maxFrequency && Array.IndexOf(arr, num) < Array.IndexOf(arr, mostFrequentNum)))
            {
                maxFrequency = frequency[num];
                mostFrequentNum = num;
            }
        }

        Console.WriteLine($"The number {mostFrequentNum} is the most frequent (occurs {maxFrequency} times).");
    }
}
