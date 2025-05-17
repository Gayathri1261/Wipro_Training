using System;

abstract class Document
{
    public abstract void PrintContent();

    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document Type: {type}");
    }
}

class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word document");
    }
}

class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF document");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Document wordDoc = new WordDocument();
        Document pdfDoc = new PDFDocument();

        Console.WriteLine("Word Document:");
        wordDoc.ShowDocumentType("Word");
        wordDoc.PrintContent();

        Console.WriteLine("\nPDF Document:");
        pdfDoc.ShowDocumentType("PDF");
        pdfDoc.PrintContent();
    }
}