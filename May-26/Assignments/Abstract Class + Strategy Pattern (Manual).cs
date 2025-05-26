using System;
public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"[ZIP] Compressing '{inputPath}' to '{outputPath}.zip'");

    }
}
public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"[RAR] Compressing '{inputPath}' to '{outputPath}.rar'");

    }
}
public class Compressor
{
    private CompressionStrategy _strategy;

    public Compressor(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }
    public void CompressFile(string inputPath, string outputPath)
    {
        _strategy.Compress(inputPath, outputPath);
    }
}
public class Program
{
    public static void Main()
    {
        Compressor compressor = new Compressor(new ZipCompression());
        compressor.CompressFile("C:/Docs/report.docx", "C:/Archives/report_backup");

        compressor.SetStrategy(new RarCompression());
        compressor.CompressFile("C:/Images/photo.png", "C:/Archives/photo_backup");
    }
}
