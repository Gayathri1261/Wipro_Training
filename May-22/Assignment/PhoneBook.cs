using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook["Akhil"] = "9876543214";
        phoneBook["Balu"] = "9876543456";
        phoneBook["Srinu"] = "7893456788";

        Console.WriteLine("Phone Book Contacts:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }

        Console.WriteLine("\nEnter a name to search for their phone number:");
        string nameToFind = Console.ReadLine();

        if (phoneBook.ContainsKey(nameToFind))
        {
            Console.WriteLine($"Phone number of {nameToFind}: {phoneBook[nameToFind]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
