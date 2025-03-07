class Program
{
    static void Main()
    {
        Console.WriteLine("--- Testing MyStack ---");
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine($"Stack Count: {stack.Count()}");
        Console.WriteLine($"Popped: {stack.Pop()}");
        Console.WriteLine($"Updated Count: {stack.Count()}");

        Console.WriteLine("\n--- Testing MyList ---");
        MyList<string> myList = new MyList<string>();
        myList.Add("Apple");
        myList.Add("Banana");
        myList.Add("Cherry");
        Console.WriteLine($"Contains 'Banana': {myList.Contains("Banana")}");
        Console.WriteLine($"Element at index 1: {myList.Find(1)}");
        myList.Remove(1);
        Console.WriteLine($"After removing index 1, Contains 'Banana': {myList.Contains("Banana")}");

        Console.WriteLine("\n--- Testing GenericRepository ---");
        GenericRepository<Entity> repo = new GenericRepository<Entity>();

        Entity e1 = new Entity { Id = 1 };
        Entity e2 = new Entity { Id = 2 };

        repo.Add(e1);
        repo.Add(e2);
        Console.WriteLine($"Total Entities: {repo.GetAll().Count()}");
        repo.Remove(e1);
        Console.WriteLine($"Total Entities after removal: {repo.GetAll().Count()}");

        Entity foundEntity = repo.GetById(2);
        Console.WriteLine($"Found Entity with ID 2: {(foundEntity != null ? "Yes" : "No")}");
    }
}
