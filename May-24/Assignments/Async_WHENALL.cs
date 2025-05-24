using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Async
    {
        //Async method to simulate a file download
        static async Task DownloadFileAsync(string fileName, int delayMs)
        {
            Console.WriteLine($"Starting download: {fileName}");
            await Task.Delay(delayMs); //simulate time taken to download
            Console.WriteLine($"Completed download: {fileName} ({delayMs}Ms)");
        }
       /* static async Task Main(string[] args)
        {
            Console.WriteLine("Starting all downloads...\n");

            //Start all downloads concurrently

            Task file1 = DownloadFileAsync("file1.pdf", 3000);
            Task file2 = DownloadFileAsync("file2.pdf", 2000);
            Task file3 = DownloadFileAsync("file3.pdf", 4000);

            //wait for all dowloads to complete
            await Task.WhenAll(file1, file2, file3);

            Console.WriteLine("\nAll downloads completed.");

        }
       */
    }
}
