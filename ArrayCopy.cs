using System;

public class ArrayCopy
{
    public static void Run() 
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        int[] newarr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newarr[i] = arr[i];
        }
        Console.WriteLine("Original Array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("New Array:");
        for (int i = 0; i < newarr.Length; i++)
        {
            Console.WriteLine(newarr[i]);
        }
    }
}
