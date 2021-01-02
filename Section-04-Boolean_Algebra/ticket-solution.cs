using System;
 
public class TicketPrinter
{
    static public void Main () 
    {

    	string name;
        int year;
        float cost;

    	Console.Clear();
        Console.WriteLine("Enter Your Name: ");
        name = Console.ReadLine();
    	Console.WriteLine("Please Enter your year of birth:");
    	year = Convert.ToInt32(Console.ReadLine());

    	if( year > 2000 || year < 1950)
    	{
    		cost = 5.30f;
    	}
    	else
    	{
    		cost = 25.0f;
    	}
        
        Console.WriteLine ("|**********************|");
        Console.WriteLine ("|   -- ADMIT ONE --    |");
        Console.WriteLine ("|Name:{0,17}|", name);
        Console.WriteLine ("|Price: ${0,14:0.00}|", cost);
        Console.WriteLine ("|----------------------|");

    }
}

/*

What is your Birth year?
1949
What is your name?
Josh
|**********************|
|   -- ADMIT ONE --    |
|Name:             Josh|
|Price: $          5,30|
|----------------------|


*/

