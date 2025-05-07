using System;
using System.Collections;
class Program
{
    static void Main()
    {
        //Create an ArrayList of student names
        ArrayList studentNames = new ArrayList();

        //2.Add 5 names to the list
        studentNames.Add("Alice");
        studentNames.Add("Bob");
        studentNames.Add("Charlie");
        studentNames.Add("David");
        studentNames.Add("Gayi");

        //Check if a specific name exists
        string nameToCheck = "Charlie";
        if(studentNames.Contains(nameToCheck)) 
            {
            Console.WriteLine($"{nameToCheck} exists in the list.");

            }
        else
        {
            Console.WriteLine($"{nameToCheck} does not exists in the list.");
        }
        //4.Remove the second name(index 1,zero based)
        studentNames.RemoveAt(1);

        //5.Display final list
        Console.WriteLine("Final list of student names:");

        foreach(string name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}