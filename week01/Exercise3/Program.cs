using System;

class Program

{
    static void Main(string[] args)
    {
        // create a random magic number between 1 - 100
        int magicNumber = new Random().Next(1, 101);
        int userNumber = 0;
        // create a variable to keep track of the number of guesses
        int guesses = 0;
        
        // loop until the user guesses the magic number
        while (magicNumber != userNumber)
        {
            guesses++;
            Console.Write("What is the magic number?  ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber == magicNumber)
            {
                Console.WriteLine($"You guessed after {guesses} tries!");
            }
            else if(userNumber > magicNumber )
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            } 
        }
        
        // check if the user wants to play again
        string userDecision;
        do
        {
        Console.Write("Would you like to play again? (yes/no)");
        userDecision = Console.ReadLine();
        
        if (userDecision.ToLower() == "yes")
        {
            Main(args);
        }
        else if (userDecision.ToLower() == "no")
        {
            Console.WriteLine("Thank you for playing, Goodbye!");
        }
        else
        {
            Console.WriteLine("Wrong input! Please enter yes or no");
        }
        } while (userDecision.ToLower() != "no");
            
    }
}    