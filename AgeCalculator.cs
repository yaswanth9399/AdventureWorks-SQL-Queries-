using System;

class AgeCalculator
{
    public static void Run()
    {
        Console.Write("Enter your birth date (yyyy-MM-dd): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        int ageInDays = (today - birthDate).Days;
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        DateTime nextAnniversaryDate = today.AddDays(daysToNextAnniversary);

        Console.WriteLine($"You are {ageInDays} days old.");
        Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate.ToShortDateString()}.");
    }
}
