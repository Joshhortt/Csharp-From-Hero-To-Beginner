using System;

public class MathsMultipleOps
{
    static public void Main()
    
    {   int number1 = 5;
        int number2 = 3;
        int total;

         // Modulus operation - shows up the reminder 
        total = number1 +  number2 * 2;
       //total = (number1 +  number2) * 2;
       
        Console.WriteLine ("Total is {0}", total);
    }
}

// Total is 11 - Remember multiplication is first than addition in this case without any brackets.

// Total 16 - We would use this total = (number1 +  number2) * 2;