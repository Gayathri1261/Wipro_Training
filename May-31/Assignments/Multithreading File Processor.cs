using System;
using System.IO;
using System.Threading;

class Program
{
    static int totalLines = 0;
    static object lockObject = new object();

    static void CountLines(string filePath)
    {
        try
        {
            int lineCount = File.ReadAllLines(filePath).Length;
            
            lock (lockObject) // Lock to safely update totalLines
            {
                totalLines += lineCount;
            }

            Console.WriteLine($"File: {Path.GetFileName(filePath)} - Lines: {lineCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading {filePath}: {ex.Message}");
        }
    }

    static void Main()
    {
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";

        Thread t1 = new Thread(() => CountLines(file1));
        Thread t2 = new Thread(() => CountLines(file2));
        Thread t3 = new Thread(() => CountLines(file3));

        Console.WriteLine("Starting to read files...\n");

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"\nAll files processed.");
        Console.WriteLine($" Total lines across all files: {totalLines}");
    }
}