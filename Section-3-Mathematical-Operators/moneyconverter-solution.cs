using System;
 
public class MoneyConvert
{
    static public void Main ()
    {
    	//Amount = rate * dollars
        float rate;
        float dollars;

        Console.WriteLine("Enter Unit/USD rate:");
        rate = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Enter amount in USD to convert:");
        dollars = Convert.ToSingle(Console.ReadLine()); 

        float amount = rate*dollars;       
        
        Console.WriteLine ("You will receive: {0:0.00}", amount);
    }
}

