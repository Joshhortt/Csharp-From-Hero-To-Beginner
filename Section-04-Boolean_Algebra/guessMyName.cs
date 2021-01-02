
using System;

public class GuessMyName
{
    static public void Main()
      
    { 
        string MyName = "Josh";
        string guess;

        Console.Clear();
        Console.WriteLine("Let's Guess my Name!\n");
        
        Console.WriteLine("Please Guess my Name!\n");
        guess = Console.ReadLine();

        if (guess == MyName)
        {
            Console.WriteLine("\nCongratulations!"); 
        }
        else
        {
             Console.WriteLine("\nYou're Wrong!"); 
        } 

    }
}

/* Let's Guess my Name!

Please Guess my Name!

Josh

Congratulations!
*/