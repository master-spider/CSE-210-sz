using System;

class Program
{
    static void Main(string[] args)
    {   
        // Ask for user's grade
        Console.Write("Please enter your percentage grade: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations, you have passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you have failed, try again.");
        }
    }
}