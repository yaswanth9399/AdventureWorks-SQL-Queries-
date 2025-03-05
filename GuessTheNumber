using System;

class GuessTheNumber
{
    public static void Run()
    {
        Random random = new Random();
        int correctNumber = random.Next(3) + 1;

        Console.Write("Guess a number between 1 and 3: ");
        int guessedNumber = int.Parse(Console.ReadLine());

        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Invalid guess! Please enter a number between 1 and 3.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Too low! The correct number was " + correctNumber);
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Too high! The correct number was " + correctNumber);
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
        }
    }
}
