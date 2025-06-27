using System;

var person = new Person() { Name = "John" };
person.Name = "Bob";


class Person
{
    public required string Name
    {
        get;
        set
        {
            field = value;
            OnNameChanged(value);
        }
    }

    private void OnNameChanged(string newName)
    {
        Console.WriteLine($"Name changed to: {newName}");
    }
}