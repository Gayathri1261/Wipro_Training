using System;
using System.Security.Cryptography;
class Student
{
    //Fields/properties
    public int RollNumber;
    public string Name;
    public int Marks;
 
    /// </summary>
      //Method to print student details
    public void PrintDetails()
    {
        Console.WriteLine($"Roll number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }
}
class Program
{
    static void Main()
    {
        //Creating an object of student
        Student student1=new Student(); 
        //Assigning values
        student1.RollNumber = 101;
        student1.Name = "Amit";
        student1.Marks = 85;
        //Printing details
        student1.PrintDetails();
    }
}