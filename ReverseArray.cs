using System;

class ReverseArray
{
    public static void One()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Array.Reverse(numbers);

        Console.WriteLine("Reversed Array:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
