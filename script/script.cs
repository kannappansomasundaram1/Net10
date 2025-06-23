#:package Humanizer@2.*

using Humanizer;

var date = new DateTime(2023, 10, 1);

Console.WriteLine($"Hello, World! from {date.Humanize()}");