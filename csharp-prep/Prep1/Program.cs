using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        var FirstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        var LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}