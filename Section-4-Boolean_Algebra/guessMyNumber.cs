
using System;

public class GuessMyNumber
{
    static public void Main()
      
    { 
        int number = 90;
        int guess;

        Console.Clear();
        Console.WriteLine("Let's Guess a number!\n");
        
        Console.WriteLine("Please Guess a number!\n");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess < number)
        {
            Console.WriteLine("\nYour Guess is too low!"); 
        }
        else if (guess > number) 
        {
            Console.WriteLine("\nYour Guess is too high!"); 
        }
        else
        {
             Console.WriteLine("\nCongratulations!"); 
        } 

    }
}

/* Let's Guess a number!

Please Guess a mumber!

90

Congratulations!
*/