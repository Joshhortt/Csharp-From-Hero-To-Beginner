
/*An exchange rate is used to change currencies between countries.  
They are expressed as a ratio of one currency to another.  
For example AUD/USD = 1.04 means that 1 US dollar will buy 1.04 Australian dollars.  
If you have $100 US dollars and want to change this for Australian dollars it would get you $104. 
To calculate this the exchange rate is multiplied by the amount of money.

Your challenge is to write a program that asks the user for the exchange rate 'from' $USD 
and then calculate how much they will receive from an input amount. E.g.

Enter Unit/USD rate:
0.98
Enter Amount to Convert:
100
You will receive $98.00
Attempt to write your own code before checking the attached solution.*/

using System;

public class MoneyConverter
{
    static public void Main()
      
    { 
        float rate;
        float money;
        float amount;

        Console.Clear();
        Console.WriteLine("Let's Calculate the Exchange Rate!\n");
        
        Console.WriteLine("Please enter Unit/USD rate");
        rate = Console.ReadLine();

        Console.WriteLine("Please enter Amount to Convert");
        money = Console.ReadLine();

        amount = rate * money;
       
        Console.WriteLine ("receive {0}", amount);

    }
}
