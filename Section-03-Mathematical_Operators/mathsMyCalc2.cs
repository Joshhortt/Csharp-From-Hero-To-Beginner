using System;

public class MathsMyCalc2
{
    static public void Main()
      
    { 
       /* string number1;
        string number2;
        int num1;
        int num2;

        Console.Clear();
        Console.WriteLine("Please enter the first number ");
        number1 = Console.ReadLine();

        Console.WriteLine("Please enter the second number");
        number2 = Console.ReadLine();

        num1 = Convert.ToInt32(number1);
        num2 = Convert.ToInt32(number2);
       
        Console.WriteLine ("Adding number {0} to {1} is {2}", num1, num2, num1+num2); */

        // We can also use this way, reducing a lot of code.
        string number1;
        string number2;
        

        Console.Clear();
        Console.WriteLine("Please enter the first number ");
        number1 = Console.ReadLine();

        Console.WriteLine("Please enter the second number");
        number2 = Console.ReadLine();
       
        Console.WriteLine ("Adding number {0} to {1} is {2}", Convert.ToInt32(number1),
                                                              Convert.ToInt32(number2),
                                                              Convert.ToInt32(number1) + 
                                                              Convert.ToInt32(number2));
    }
}
/*
Please enter the first number
69
Please enter the second number
32
Adding number 69 to 32 is 101
*/
