using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Task download1 = DownloadFileAsync("file1.txt", 2000);
        Task download2 = DownloadFileAsync("file2.txt", 3000);
        Task download3 = DownloadFileAsync("file3.txt", 1000);

        await Task.WhenAll(download1, download2, download3);

        stopwatch.Stop();
        Console.WriteLine($"All downloads completed in {stopwatch.ElapsedMilliseconds} ms.");
    }
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay(delay); 
        Console.WriteLine($"Completed download: {fileName}");
    }
}
