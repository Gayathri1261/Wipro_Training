using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id;
    public string Title;
    public string Author;
    public bool IsAvailable;

    public Book(int id, string title, string author, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}
class Library
{
    public List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public List<Book> SearchByAuthor(string author)
    {
        return Books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
    }
    public List<Book> SearchByTitle(string title)
    {
        return Books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
    }
}
class Program
{
    static void Main()
    {
        Library library = new Library();

       
        library.AddBook(new Book(1, "C# Programming", "John Doe", true));
        library.AddBook(new Book(2, "Learn Java", "Jane Smith", false));
        library.AddBook(new Book(3, "Python Basics", "John Doe", true));
        library.AddBook(new Book(4, "Data Structures", "Alan Turing", true));
        Console.WriteLine("Books by John Doe:");
        
        var authorResults = library.SearchByAuthor("John Doe");
        foreach (var book in authorResults)
        {
            Console.WriteLine($"- {book.Title} (Available: {book.IsAvailable})");
        }

        Console.WriteLine("\nBooks with 'Learn' in the title:");
        var titleResults = library.SearchByTitle("Learn");
        foreach (var book in titleResults)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} (Available: {book.IsAvailable})");
        }
    }
}
