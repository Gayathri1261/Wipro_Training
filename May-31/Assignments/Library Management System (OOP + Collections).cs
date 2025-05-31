using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; } = false;
    public Student BorrowedBy { get; set; }
    public DateTime? DueDate { get; set; }
}

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(int id, string title)
    {
        books.Add(new Book { Id = id, Title = title });
        Console.WriteLine($" Book '{title}' added.");
    }

    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id && !b.IsBorrowed);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted.");
        }
        else
        {
            Console.WriteLine("Book not found or is currently borrowed.");
        }
    }

    public void BorrowBook(int bookId, Student student)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId && !b.IsBorrowed);
        if (book != null)
        {
            book.IsBorrowed = true;
            book.BorrowedBy = student;
            book.DueDate = DateTime.Now.AddDays(14);
            Console.WriteLine($"{book.Title}' borrowed by {student.Name} (Due: {book.DueDate.Value.ToShortDateString()})");
        }
        else
        {
            Console.WriteLine(" Book not available.");
        }
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\n All Books:");
        foreach (var book in books)
        {
            string status = book.IsBorrowed
                ? $"Borrowed by {book.BorrowedBy.Name}, Due: {book.DueDate?.ToShortDateString()}"
                : "Available";
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Status: {status}");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        Student s1 = new Student { RollNumber = 101, Name = "Ravi" };
        Student s2 = new Student { RollNumber = 102, Name = "Keerthi" };

        library.AddBook(1, "C# Programming");
        library.AddBook(2, "Data Structures");
        library.AddBook(3, "Operating Systems");

        library.ShowAllBooks();

        library.BorrowBook(2, s1);
        library.BorrowBook(3, s2);

        library.DeleteBook(2);

        library.ShowAllBooks();
    }
}
