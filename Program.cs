using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose a program to run:");
            Console.WriteLine("1. Reverse Array");
            Console.WriteLine("2. Generate Numbers");
            Console.WriteLine("3. Print Numbers");
            Console.WriteLine("4. Fibonacci Sequence");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Test OOP Classes (Student, Instructor, Ball, Color)");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReverseArray.One();
                    break;
                case "2":
                    GenerateNumbers.Two();
                    break;
                case "3":
                    PrintNumbers.Three();
                    break;
                case "4":
                    Fibonacci.Four();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                case "6":
                    TestOOPClasses(); // Call a method to test the OOP part
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    static void TestOOPClasses()
    {
        Console.WriteLine("\n--- Testing Student & Instructor Classes ---");

        Student student1 = new Student { Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) };
        student1.EnrollCourse("Math", 'A');
        student1.EnrollCourse("Science", 'B');

        Instructor instructor1 = new Instructor
        {
            Name = "Dr. Smith",
            DateOfBirth = new DateTime(1980, 3, 10),
            BaseSalary = 50000,
            JoinDate = new DateTime(2010, 8, 1),
            IsHeadOfDepartment = true
        };

        Console.WriteLine(student1.GetInfo());
        Console.WriteLine(instructor1.GetInfo());

        Console.WriteLine("\n--- Testing Color and Ball Classes ---");
        Color redColor = new Color(255, 0, 0);
        Ball ball1 = new Ball(10, redColor);

        ball1.Throw();
        ball1.Throw();
        Console.WriteLine($"Ball has been thrown {ball1.GetThrowCount()} times.");

        ball1.Pop();
        ball1.Throw();
        Console.WriteLine($"After popping, ball has been thrown {ball1.GetThrowCount()} times.");

        Console.WriteLine("\n--- Testing Department and Course ---");
        Department compSciDept = new Department { Name = "Computer Science", Head = instructor1, Budget = 100000 };
        Course algorithms = new Course { CourseName = "Algorithms" };
        algorithms.EnrolledStudents.Add(student1);
        compSciDept.Courses.Add(algorithms);

        Console.WriteLine($"Department: {compSciDept.Name}, Head: {compSciDept.Head.Name}");
        Console.WriteLine($"Course: {algorithms.CourseName}, Enrolled Students: {algorithms.EnrolledStudents.Count}");
    }
}
