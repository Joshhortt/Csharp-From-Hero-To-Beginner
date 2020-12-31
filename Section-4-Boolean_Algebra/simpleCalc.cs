
using System;

public class SimpleCalculator
{
    static public void Main()
      
    { 
       
        float number1;
        float number2;
        string op; 

        Console.Clear();
        Console.WriteLine("Enter first number!");
        number1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nEnter second number!");
        number2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nEnter operator!");
        op = Console.ReadLine();

        switch(op)
        {

            case "*":
            Console.WriteLine("\n{0}", number1*number2);
            break;

            case "/":
            Console.WriteLine("\n{0}", number1/number2);
            break;

            case "+":
            Console.WriteLine("\n{0}", number1+number2);
            break;

            case "-":
            Console.WriteLine("\n{0}", number1-number2);
            break;

            default:
            Console.WriteLine("\nCannot calculate");
            break;
            
        }    
    }
}

/*

Enter first number!
56

Enter second number!
33

Enter operator!
3

Cannot calculate


OR


Enter first number!
99

Enter second number!
33

Enter operator!
/

3

*/