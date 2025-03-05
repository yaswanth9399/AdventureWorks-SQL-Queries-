using System;

class ByteLoopWarning
{
    public static void Run()
    {
        int max = 500;

        if (max > 255)
        {
            Console.WriteLine("Warning: 'byte' type cannot exceed 255. This will cause an overflow!");
            return;
        }

        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
