class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Print a Pyramid");
            Console.WriteLine("2 - Guess the Number");
            Console.WriteLine("3 - Age Calculator");
            Console.WriteLine("4 - Time-Based Greeting");
            Console.WriteLine("5 - Counting Up to 24");
            Console.WriteLine("6 - Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PyramidPattern.Run();
                    break;
                case "2":
                    GuessTheNumber.Run();
                    break;
                case "3":
                    AgeCalculator.Run();
                    break;
                case "4":
                    TimeBasedGreeting.Run();
                    break;
                case "5":
                    IncrementalCounter.Run();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }
}
