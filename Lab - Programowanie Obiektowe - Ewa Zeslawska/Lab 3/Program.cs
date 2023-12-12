using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        Person person = new Person("John", "Doe", 25);
        people.Add(person);

        Reader reader = new Reader("Alice", "Smith", 30);
        reader.AddBook(new Book("C# Programming", person, new DateTime(2022, 1, 1)));
        reader.AddBook(new Book("Design Patterns", person, new DateTime(2022, 2, 1)));
        people.Add(reader);

        Reviewer reviewer1 = new Reviewer("Bob", "Johnson", 35);
        reviewer1.AddBook(new Book("Data Science", person, new DateTime(2022, 3, 1)));
        reviewer1.AddBook(new Book("Machine Learning", person, new DateTime(2022, 4, 1)));
        people.Add(reviewer1);

        Reviewer reviewer2 = new Reviewer("Eve", "Williams", 28);
        reviewer2.AddBook(new Book("Web Development", person, new DateTime(2022, 5, 1)));
        people.Add(reviewer2);

        foreach (var p in people)
        {
            p.View();
            Console.WriteLine();
        }
    }
}
