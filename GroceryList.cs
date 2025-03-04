using System;
using System.Collections.Generic;

class GroceryList
{
    public static void Run()
    {
        List<string> itemList = new List<string>();
        while (true)
        {
            Console.WriteLine("\nEnter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                continue;

            if (input.StartsWith("+"))
            {
                string itemToAdd = input.Substring(1).Trim();
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
            }
            else if (input.StartsWith("-"))
            {
                string itemToRemove = input.Substring(1).Trim();
                if (itemList.Remove(itemToRemove))
                {
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {itemToRemove}");
                }
            }
            else if (input == "--")
            {
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }

            Console.WriteLine("\nCurrent List:");
            if (itemList.Count == 0)
            {
                Console.WriteLine("[Empty]");
            }
            else
            {
                foreach (var item in itemList)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }
    }
}
