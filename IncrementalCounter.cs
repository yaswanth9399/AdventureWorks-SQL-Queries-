using System;

class IncrementalCounter
{
    public static void Run()
    {
        for (int step = 1; step <= 4; step++)
        {
            Console.Write($"Counting by {step}s: ");
            for (int i = 0; i <= 24; i += step)
            {
                Console.Write(i + (i < 24 ? ", " : "\n"));
            }
        }
    }
}
