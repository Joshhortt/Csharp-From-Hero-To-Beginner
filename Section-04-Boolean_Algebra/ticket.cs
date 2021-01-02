

using System;

public class Ticket
{
    static public void Main()
    {   
        int year;
        string name; 
        float cost;
        
        Console.Clear();

        Console.WriteLine("\nWhat is your Birth year?\n");
        year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nWhat is your name?\n");
        name = Console.ReadLine();
      
         if (year < 1950 || year > 2000)
        {
           
            cost = 5.30f;
        }
        else
        {
           
            cost = 25.0f; 
        }
        Console.WriteLine ("\nYour generated Movie Ticket is here!\n");
        Console.WriteLine ("|**********************|");
        Console.WriteLine ("|   -- ADMIT ONE --    |");
        Console.WriteLine ("|Name:{0,17}|", name);
        Console.WriteLine ("|Price: ${0,14:0.00}|", cost);
        Console.WriteLine ("|----------------------|");
        }    
    }

