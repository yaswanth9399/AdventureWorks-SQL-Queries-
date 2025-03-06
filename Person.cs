using System;
using System.Collections.Generic;

// Abstraction - Base Person class
public abstract class Person
{
    private List<string> addresses = new List<string>();
    
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return new List<string>(addresses);
    }

    public abstract decimal CalculateSalary();
}

// Interface for common person services
public interface IPersonService
{
    string GetInfo();
}

public interface IStudentService : IPersonService
{
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    decimal GetBonusSalary();
}

// Inheritance - Student class
public class Student : Person, IStudentService
{
    private Dictionary<string, char> courses = new Dictionary<string, char>();

    public void EnrollCourse(string course, char grade)
    {
        courses[course] = grade;
    }

    public double CalculateGPA()
    {
        Dictionary<char, double> gradePoints = new Dictionary<char, double>
        {
            { 'A', 4.0 }, { 'B', 3.0 }, { 'C', 2.0 }, { 'D', 1.0 }, { 'F', 0.0 }
        };

        double totalPoints = 0;
        foreach (var grade in courses.Values)
        {
            totalPoints += gradePoints[grade];
        }
        return courses.Count > 0 ? totalPoints / courses.Count : 0;
    }

    public override decimal CalculateSalary() => 0;

    public string GetInfo()
    {
        return $"Student: {Name}, Age: {CalculateAge()}, GPA: {CalculateGPA():0.00}";
    }
}

public class Instructor : Person, IInstructorService
{
    public decimal BaseSalary { get; set; }
    public DateTime JoinDate { get; set; }
    public bool IsHeadOfDepartment { get; set; }

    public int YearsOfExperience()
    {
        return DateTime.Now.Year - JoinDate.Year;
    }

    public decimal GetBonusSalary()
    {
        return BaseSalary * 0.1m * YearsOfExperience();
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + GetBonusSalary();
    }

    public string GetInfo()
    {
        return $"Instructor: {Name}, Age: {CalculateAge()}, Salary: ${CalculateSalary():0.00}";
    }
}

public class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();
}

public class Department
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
}
