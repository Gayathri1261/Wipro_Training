using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        //Fields/properties
        public int RollNumber;
        public string Name;
        public int Marks;

        //Method to print student details
        public void PrintDetails()
        {
            Console.WriteLine($"Roll number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks}");
        }
    }
}
using System;
using System.Security.Cryptography;
//using ConsoleApp1;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student { RollNumber = 101, Name = "Neha", Marks=90};
            Student student2 = new Student { RollNumber = 102, Name = "Ravi", Marks = 75 };

            student1.PrintDetails();
            student2.PrintDetails();
        }
    }
}

