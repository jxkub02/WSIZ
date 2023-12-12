using System;
using System.Collections.Generic;

public class Reader : Person
{
    private List<Book> ReadBooks = new List<Book>();

    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public void AddBook(Book book)
    {
        ReadBooks.Add(book);
    }

    public void ViewBook()
    {
        Console.WriteLine($"Books read by {FirstName} {LastName}:");
        foreach (var book in ReadBooks)
        {
            book.View();
        }
    }

    public override void View()
    {
        base.View();
        ViewBook();
    }
}
