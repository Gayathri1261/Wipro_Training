using System;

// Define the Interface
interface IDeviceControl
{
    void TurnOn();
    void TurnOff();
}

//Implement SmartTV Class
class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }
}
// Implement Speaker Class
class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }
}
// Main Method to Test the Classes
class Program
{
    static void Main(string[] args)
    {
        // Create IDeviceControl reference for SmartTV
        IDeviceControl tv = new SmartTV();
        tv.TurnOn();
        tv.TurnOff();

        Console.WriteLine();

        // Create IDeviceControl reference for Speaker
        IDeviceControl speaker = new Speaker();
        speaker.TurnOn();
        speaker.TurnOff();
    }
}