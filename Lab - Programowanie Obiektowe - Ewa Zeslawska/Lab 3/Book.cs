using System;

public class Book
{
    protected string Title;
    protected Person Author;
    protected DateTime ReleaseDate;

    public Book(string title, Person author, DateTime releaseDate)
    {
        Title = title;
        Author = author;
        ReleaseDate = releaseDate;
    }

    public void View()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author.FirstName} {Author.LastName}, Release Date: {ReleaseDate:d}");
    }
}
