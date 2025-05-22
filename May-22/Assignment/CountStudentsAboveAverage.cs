using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {

        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 75 },
            new Student { Name = "Bob", Marks = 82 },
            new Student { Name = "Charlie", Marks = 68 },
            new Student { Name = "Diana", Marks = 90 },
            new Student { Name = "Ethan", Marks = 77 }
        };

        double averageMarks = students.Average(s => s.Marks);
        Console.WriteLine($"Average Marks: {averageMarks:F2}");

        int aboveAverageCount = students.Count(s => s.Marks > averageMarks);

        Console.WriteLine($"Number of students scoring above average: {aboveAverageCount}");
    }
}
