using System;
using System.Collections;

class Program
{
    static void Main()
    {
        //Create a Arraylist student names
        ArrayList studentNames  = new ArrayList();

        //Add 5 studentNames
        studentNames.Add("Gayi");
        studentNames.Add("Srinu");
        studentNames.Add("Roopa");
        studentNames.Add("Bharath");
        studentNames.Add("Ramesh");

        //Remove an employee by name
        studentNames.Remove("Bharath");

        //Check if a specific name exists
        if (studentNames.Contains("Ramesh"))
            Console.WriteLine("Ramesh is in the list:");
        else
            Console.WriteLine("Ramesh is not in the list:");

        //Print the total number of employees

        Console.WriteLine("Students List");
        foreach (string S in studentNames)
        {
            Console.WriteLine(S);
        }
    }
}