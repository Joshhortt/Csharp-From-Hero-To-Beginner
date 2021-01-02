using System;

public class WeightCalculator
{
    static public void Main()
        
    {  
        
        float kgs;
        float bmi;
    
        Console.Clear();

        Console.WriteLine("Calculate if you are classified Overweight or Underweight:\n");
        Console.WriteLine("What is your Weight!");
        kgs = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nWhat is your Body Mass Index!");
        bmi = Convert.ToSingle(Console.ReadLine());

        if (kgs > 92 && bmi > 30)
        {
             Console.WriteLine("Obese"); 
        }
         else if (kgs < 52 && bmi < 18.5f)
        {
             Console.WriteLine("Underweight"); 
        }
        else
        {
            Console.WriteLine("Please enter correct data."); 
        }
    }
}
/*

Calculate if you are classified Overweight or Underweight:

What is your Weight!
51

What is your Body Mass Index!
18
Underweight

*/

// With OR

/*using System;

public class WeightCalculator
{
    static public void Main()
        
    {  
        
        float kgs;
        float bmi;
    
        Console.Clear();

        Console.WriteLine("Calculate if you are classified Overweight or Underweight:\n");
        Console.WriteLine("What is your Weight!");
        kgs = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\nWhat is your Body Mass Index!");
        bmi = Convert.ToSingle(Console.ReadLine());

        if (kgs > 92 || bmi > 30)
        {
             Console.WriteLine("Obese"); 
        }
         else if (kgs < 52 || bmi < 18.5f)
        {
             Console.WriteLine("Underweight"); 
        }
        else
        {
            Console.WriteLine("Please enter correct data."); 
        }
    }
}
*/

/*
Calculate if you are classified Overweight or Underweight:

What is your Weight!
93

What is your Body Mass Index!
31
Obese
*/