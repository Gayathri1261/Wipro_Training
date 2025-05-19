using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
public class Program
{
    public static void Main()
    {
    
        Queue<Book> borrowedBooks = new Queue<Book>();
        borrowedBooks.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        borrowedBooks.Enqueue(new Book("1984", "George Orwell"));
        borrowedBooks.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
        borrowedBooks.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
        borrowedBooks.Enqueue(new Book("Moby Dick", "Herman Melville"));

        Console.WriteLine(" Next book to be returned:");
        borrowedBooks.Peek().Display();

        Console.WriteLine("\n Returning the next book...");
        borrowedBooks.Dequeue();

        Stack<Book> newBooks = new Stack<Book>();
        newBooks.Push(new Book("The Silent Patient", "Alex Michaelides"));
        newBooks.Push(new Book("Where the Crawdads Sing", "Delia Owens"));
        newBooks.Push(new Book("Atomic Habits", "James Clear"));

        Console.WriteLine("\n Last book purchased:");
        newBooks.Peek().Display();

        Console.WriteLine("\n Processing the last purchased book...");
        newBooks.Pop();

        Console.WriteLine("\n Remaining Borrowed Books (Queue):");
        foreach (var book in borrowedBooks)
        {
            book.Display();
        }

        Console.WriteLine("\n Remaining New Books (Stack):");
        foreach (var book in newBooks)
        {
            book.Display();
        }
    }
}