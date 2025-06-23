using System;

Customer customer = null;

customer?.Name = "John Doe";
Console.WriteLine(customer?.Name?? "No customer found");

var customer1 = new Customer();
customer1?.Name = "John Doe";
Console.WriteLine(customer1?.Name?? "No customer found");

Console.WriteLine(customer?.Name); 



public class Customer
{
    public string Name { get; set; }
}