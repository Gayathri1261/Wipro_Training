using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ramu", Marks = 88, Grade = "A" },
            new Student { Name = "Sita", Marks = 92, Grade = "A" },
            new Student { Name = "Lakshman", Marks = 75, Grade = "B" },
            new Student { Name = "Suresh", Marks = 60, Grade = "C" },
            new Student { Name = "Geeta", Marks = 95, Grade = "A" },
            new Student { Name = "Hanuman", Marks = 55, Grade = "D" },
            new Student { Name = "Vijay", Marks = 82, Grade = "B" },
            new Student { Name = "Lalitha", Marks = 90, Grade = "A" },
            new Student { Name = "Raju", Marks = 78, Grade = "B" },
            new Student { Name = "Saroja", Marks = 68, Grade = "C" }
        };
        var sortedStudents = students.OrderByDescending(s => s.Marks);

        Console.WriteLine(" Students Sorted by Marks (Descending):");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine($"{s.Name} - {s.Marks} - Grade {s.Grade}");
        }

        Console.WriteLine("\n Students Grouped by Grade:");
        var groupedByGrade = students.GroupBy(s => s.Grade);
        foreach (var group in groupedByGrade)
        {
            Console.WriteLine($"\nGrade {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Name} - {student.Marks}");
            }
        }

        Console.WriteLine("\n Top 3 Students:");
        var top3 = sortedStudents.Take(3);
        foreach (var top in top3)
        {
            Console.WriteLine($"{top.Name} - {top.Marks} - Grade {top.Grade}");
        }
    }
}
