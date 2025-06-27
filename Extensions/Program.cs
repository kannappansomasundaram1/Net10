using System;
using System.Collections.Generic;
using System.Linq;
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

var numbers = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Using extension methods:");

var isEmpty = numbers.IsEmpty; // Extension property
Console.WriteLine($"Is the collection empty? {isEmpty}");
//incrementing a number using extension method
int number = 5;
number.Increment();

Console.WriteLine($"Incremented number: {number}");

var foo = List<int>.Create(); // Using extension method on List<T>
Console.WriteLine($"Created list count: {foo.Count}");

static class ListExtensions
{
    // Extension method to create an empty list

    extension<T>(List<T>)
    {
    public static List<T> Create()
        => new List<T>();
}
}

static class MyEnumerable
{
    extension<TSource>(IEnumerable<TSource> source) // extension members for IEnumerable<TSource>
    {
        // Extension property:
        public bool IsEmpty => !source.Any();
}

}

static class IntExtensions
{
    public static void Increment(this int number)
    {
        number++;
    }
}
