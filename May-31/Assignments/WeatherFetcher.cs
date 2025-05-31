using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Task<string> city1 = GetWeatherAsync("Hyderabad", 2000);
        Task<string> city2 = GetWeatherAsync("Vizag", 3000);
        Task<string> city3 = GetWeatherAsync("Vijayawada", 2500);

        string[] results = await Task.WhenAll(city1, city2, city3);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        sw.Stop();
        Console.WriteLine($"\nTotal time taken: {sw.ElapsedMilliseconds} ms");
    }

    static async Task<string> GetWeatherAsync(string city, int delay)
    {
        Console.WriteLine($" Fetching weather for {city}...");
        await Task.Delay(delay); // Simulate network/API delay
        Random r = new Random();
        int temperature = r.Next(25, 40);
        return $"️ {city}: {temperature}°C (Fetched in {delay} ms)";
    }
}
