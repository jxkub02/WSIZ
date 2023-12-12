using System;
using System.Collections.Generic;

public class Reviewer : Reader
{
    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    public void ReviewBooks()
    {
        Console.WriteLine($"Reviews by {FirstName} {LastName}:");
        foreach (var book in ReadBooks)
        {
            int rating = new Random().Next(1, 6); // Random rating from 1 to 5
            Console.WriteLine($"{book.Title}: Rating - {rating}");
        }
    }
}
