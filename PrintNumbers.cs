using System;

class PrintNumbers
{
    public static void Three()
    {
        int[] numbers = { 5, 10, 15, 20 };
        Console.WriteLine("Printing Numbers:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
