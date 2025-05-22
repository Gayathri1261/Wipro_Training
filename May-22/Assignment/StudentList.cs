using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>();
        
        students.Add("Anil");
        students.Add("Bharath");
        students.Add("Deepthi");
        students.Add("Charan");
        students.Add("Gayathri");

        Console.WriteLine("Original list of student names:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        students.Sort();
        Console.WriteLine("\nSorted list of student names:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
