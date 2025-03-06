using System;

class GenerateNumbers
{
    public static void Two()
    {
        int[] numbers = GenerateArray(10);
        Console.WriteLine("Generated Array:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] GenerateArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = i + 1;
        }
        return arr;
    }
}
