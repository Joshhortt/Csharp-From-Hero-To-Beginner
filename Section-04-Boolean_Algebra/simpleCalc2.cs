using System;

public class SimpleCalculator2
{
    static public void Main()
      
    { 
       // Here I changed the string variable for an int variable.
        float number1;
        float number2;
        int op; 

        Console.Clear();
        Console.WriteLine("Calculator: 1 for Multiplication; 2 for Division, 3 for Addition and 4 for Subtraction!\n");
        Console.WriteLine("Enter first number!");
        number1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nEnter second number!");
        number2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nEnter operator!");
        // Here we need to convert int to string using 'ToInt32'
        op = Convert.ToInt32(Console.ReadLine());

        switch(op)
        {

            case 1:
            Console.WriteLine("\n{0}", number1*number2);
            break;

            case 2:
            Console.WriteLine("\n{0}", number1/number2);
            break;

            case 3:
            Console.WriteLine("\n{0}", number1+number2);
            break;

            case 4:
            Console.WriteLine("\n{0}", number1-number2);
            break;

            default:
            Console.WriteLine("\nCannot calculate");
            break;
            
        }    
    }
}

/*
Calculator: 1 for Multiplication; 2 for Division, 3 for Addition and 4 for Subtraction!

Enter first number!
50

Enter second number!
10

Enter operator!
1

500*/