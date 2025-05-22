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
            new Student { Name = "Roppa", Marks = 85 },
            new Student { Name = "Sai", Marks = 92 },
            new Student { Name = "Ramesh", Marks = 78 },
            new Student { Name = "Priya", Marks = 88 },
            new Student { Name = "Vijay", Marks = 95 },
            new Student { Name = "Sivansh", Marks = 90 }
        };

        var topStudents = students
            .OrderByDescending(s => s.Marks)
            .Take(3);

        Console.WriteLine("Top 3 Students by Marks:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
        }
    }
}
