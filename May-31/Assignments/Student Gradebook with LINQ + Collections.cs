using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>
        {
            { "Ravi", new List<int> { 85, 90, 78 } },
            { "Keerthi", new List<int> { 92, 88, 95 } },
            { "Mahesh", new List<int> { 70, 65, 72 } },
            { "Sowmya", new List<int> { 88, 80, 84 } },
            { "Kiran", new List<int> { 60, 58, 63 } }
        };

        Console.WriteLine("Student Gradebook\n");

        foreach (var student in studentMarks)
        {
            var name = student.Key;
            var marks = student.Value;
            double average = marks.Average();
            int highest = marks.Max();
            int lowest = marks.Min();

            Console.WriteLine($" {name}");
            Console.WriteLine($"   Marks: {string.Join(", ", marks)}");
            Console.WriteLine($"   Average: {average:0.00}, Highest: {highest}, Lowest: {lowest}\n");
        }

        Console.WriteLine(" Top 3 Scorers:");
        var top3 = studentMarks
            .Select(s => new { Name = s.Key, Average = s.Value.Average() })
            .OrderByDescending(s => s.Average)
            .Take(3);

        int rank = 1;
        foreach (var student in top3)
        {
            Console.WriteLine($"{rank}. {student.Name} - Average: {student.Average:0.00}");
            rank++;
        }
    }
}
