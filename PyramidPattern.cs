using System;

class PyramidPattern
{
    public static void Run()
    {
        Console.Write("Enter number of rows for the pyramid: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++) 
        {
            for (int j = 0; j < rows - i; j++) 
            {
                Console.Write(" ");
            }
            for (int k = 0; k < (2 * i - 1); k++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
