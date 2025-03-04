using System;
using System.Collections.Generic;

class Prime
{
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>(); 
        for (int i = startNum; i <= endNum; i++) 
        {
            int count = 0;
            for (int j = 1; j <= i; j++) 
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2) 
            {
                primes.Add(i);
            }
        }
        return primes.ToArray();
    }

    public static void Run()
    {
        Console.Write("Enter start number: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("Enter End number: ");
        int endNum = int.Parse(Console.ReadLine());
        int[] prime = FindPrimesInRange(startNum, endNum);
        Console.WriteLine("Prime numbers in range:");
        Console.WriteLine(string.Join(", ", prime));
    }
}
