using System;

//Define the Abstract Class
abstract class Notification
{
    // Abstract method (must be implemented in derived classes)
    public abstract void Send();

    // Concrete method
    public void ShowType()
    {
        Console.WriteLine("Sending Notification");
    }
}
//Implement EmailNotification Class
class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}
//Implement SMSNotification Class
class SMSNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}
// Main Method to Test the Classes
class Program
{
    static void Main(string[] args)
    {
        // Notification reference for EmailNotification object
        Notification email = new EmailNotification();
        email.ShowType();
        email.Send();

        Console.WriteLine();

        // Notification reference for SMSNotification object
        Notification sms = new SMSNotification();
        sms.ShowType();
        sms.Send();
    }
}