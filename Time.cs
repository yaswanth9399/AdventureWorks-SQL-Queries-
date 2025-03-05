using System;

class Time
{
    public static void ConvertCenturies(int centuries) 
    {
        int years = centuries * 100;
        long days = (long)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        ulong microseconds = (ulong)milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                          $"{seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
