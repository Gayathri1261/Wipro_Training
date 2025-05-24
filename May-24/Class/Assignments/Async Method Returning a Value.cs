using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<int> temp1 = GetTemperatureAsync("New York");
        Task<int> temp2 = GetTemperatureAsync("London");
        Task<int> temp3 = GetTemperatureAsync("Tokyo");

        int[] results = await Task.WhenAll(temp1, temp2, temp3);

        Console.WriteLine($"New York: {results[0]}°C");
        Console.WriteLine($"London: {results[1]}°C");
        Console.WriteLine($"Tokyo: {results[2]}°C");
    }
    static async Task<int> GetTemperatureAsync(string city)
    {
        Console.WriteLine($"Getting temperature for {city}...");
        await Task.Delay(1000); 

        Random rand = new Random(Guid.NewGuid().GetHashCode()); 
        int temperature = rand.Next(-10, 35); 

        Console.WriteLine($"Retrieved temperature for {city}");
        return temperature;
    }
}
