using System;
using System.Collections.Generic;

class Course
{
    public int Id;
    public string Title;
    public decimal Fee;

    public Course(int id, string title, decimal fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}

interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}

class User : IEnrollable
{
    public string Name;
    private List<(Course, decimal)> enrolledCourses = new List<(Course, decimal)>();

    public User(string name)
    {
        Name = name;
    }

    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"Enrolled in {course.Title} at ₹{course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        decimal finalFee = course.Fee;
        if (couponCode == "SAVE10")
        {
            finalFee = course.Fee * 0.90m;
            Console.WriteLine($"Coupon applied! 10% discount on {course.Title}");
        }
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"Enrolled in {course.Title} at ₹{finalFee}");
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine($"\n{Name}'s Enrolled Courses:");
        foreach (var (course, fee) in enrolledCourses)
        {
            Console.WriteLine($"- {course.Title} | Fee Paid: ₹{fee}");
        }
    }
}

class Program
{
    static void Main()
    {
        Course c1 = new Course(1, "C# Basics", 3000);
        Course c2 = new Course(2, "Advanced Python", 5000);
        Course c3 = new Course(3, "Web Development", 4000);

        User user = new User("Meera");

        user.Enroll(c1);
        user.Enroll(c2, "SAVE10");
        user.Enroll(c3, "INVALID");  

        user.PrintEnrolledCourses();
    }
}

