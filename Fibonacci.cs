using System;

class Fibonacci
{
    public static int GetFibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        return GetFibonacci(n - 1) + GetFibonacci(n - 2); 
    }

    public static void Four()
    {
        Console.WriteLine("First 10 Fibonacci Numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(GetFibonacci(i) + " ");
        }
        Console.WriteLine();
    }
}
