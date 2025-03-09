using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for user first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        // Ask for user last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print out the user's full name in James Bond' Style
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}