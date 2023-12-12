using System;

public class Person
{
    private string FirstName;
    private string LastName;
    private int Age;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public virtual void View()
    {
        Console.WriteLine($"Person: {FirstName} {LastName}, Age: {Age}");
    }
}
