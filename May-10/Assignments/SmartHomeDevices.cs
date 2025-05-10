using System;
using System.Security.Cryptography;

class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;
    public void TogglePower()
    {
        PowerStatus=!PowerStatus;
        Console.WriteLine(DeviceName + "Power is now " + (PowerStatus ? "ON" : "OFF"));
    }
    
}
class SmartLight : SmartDevice
{
    public int Brightness;
    public void SetBrightness(int value)
    {
        Brightness = value;
        Console.WriteLine(DeviceName + "Brightness set to " + (Brightness));
    }
    public void ShowStatus()
    {
        Console.WriteLine("Device: " + DeviceName + ", Power: " + PowerStatus + ", Brightness: " + Brightness);
    }
}
class SmartThermostat : SmartDevice
{
    public double Temperature;
    public void SetTemperature(double value)
    {
        Temperature = value;
        Console.WriteLine(DeviceName + " Temperature set to " + Temperature + "°C");
    }

    public void ShowStatus()
    {
        Console.WriteLine("Device: " + DeviceName + ", Power: " + PowerStatus + ", Temperature: " + Temperature + "°C");
    }
}
class Program
{
    static void Main()
    {
        SmartLight light = new SmartLight();
        light.DeviceName = "Bedroom Light";
        light.TogglePower();
        light.SetBrightness(80);
        light.ShowStatus();

        Console.WriteLine();

        SmartThermostat thermostat = new SmartThermostat();
        thermostat.DeviceName = "Living Room Thermostat";
        thermostat.TogglePower();
        thermostat.SetTemperature(23.5);
        thermostat.ShowStatus();
    }
}