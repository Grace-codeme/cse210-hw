using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"First name is {firstName}");

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Last name is {lastName}");

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }

}