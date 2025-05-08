using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> PD = new Dictionary<string, string>();//PhoneDirectory-PD
        {
            PD.Add("Alice", "1234567890");
            PD.Add("bob", "0987654321");
            PD.Add("Charlie", "5678912345");
            PD.Add("Deepthi", "2345678901");
            PD.Add("Elice", "4567890124");
        }

        //Updating the phone number for charlie 
        PD["Charlie"] = "9867542310";
        Console.WriteLine($"Updated phone number:");

        if (PD.ContainsKey("Deepthi"))
            Console.WriteLine("Deepthi is in the list:");


        Console.WriteLine("Contact list");
        foreach ( var Contact in PD)
        {
            Console.WriteLine(Contact);
        }
        
    }
}