/*using System;
 
public class CheapestPrice
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.05f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        Console.Clear();
        // calculate the minimum of bread price
        float minimum = breadPrices[0];
        for(int i = 1; i < breadPrices.Length; i++)
        {
            if(breadPrices[i] < minimum)
                minimum = breadPrices[i];
        }
        Console.WriteLine("Lowest Price of Bread ${0}", minimum);
    

         // calculate the minimum of bread price
        minimum = milkPrices[0];
        for(int i = 1; i < milkPrices.Length; i++)
        {
            if(milkPrices[i] < minimum)
                minimum = milkPrices[i];
        }
        Console.WriteLine("Lowest Price of Milk ${0}", minimum);
    
             // calculate the minimum of bread price
        minimum = eggPrices[0];
        for(int i = 1; i < eggPrices.Length; i++)
        {
            if(eggPrices[i] < minimum)
                minimum = eggPrices[i];
        }
        Console.WriteLine("Lowest Price of Eggs ${0}", minimum);
    
    }

}


Lowest Price of Bread $2,05
Lowest Price of Milk $1,25
Lowest Price of Eggs $2,9
*/

// NOW TO INCLUDE A FUNCTION TYHE CODE ABOVE WOULD BE LIKE THIS
/*
using System;
 
public class CheapestPrice
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.05f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        Console.Clear();
        */
        // THIS CODE BELOW NOW WILL BE REMOVED AFTER CREATE FUNCTION MinCalc IN THE BOTTOM
        /*
        float minimum = breadPrices[0];
        for(int i = 1; i < breadPrices.Length; i++)
        {
            if(breadPrices[i] < minimum)
                minimum = breadPrices[i];
        }
        Console.WriteLine("Lowest Price of Bread ${0}", minimum);
    

         // calculate the minimum of bread price
        minimum = milkPrices[0];
        for(int i = 1; i < milkPrices.Length; i++)
        {
            if(milkPrices[i] < minimum)
                minimum = milkPrices[i];
        }
        Console.WriteLine("Lowest Price of Milk ${0}", minimum);
    
             // calculate the minimum of bread price
        minimum = eggPrices[0];
        for(int i = 1; i < eggPrices.Length; i++)
        {
            if(eggPrices[i] < minimum)
                minimum = eggPrices[i];
        }
        Console.WriteLine("Lowest Price of Eggs ${0}", minimum);
    */
    /*
    MinCalc(breadPrices, "bread");
    MinCalc(milkPrices, "mil");
    MinCalc(eggPrices, "egg");

    }
 static public void MinCalc(float[] numbers, string typeOfProd)
 {
  float minimum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] < minimum)
                minimum = numbers[i];
        }
        Console.WriteLine("Lowest Price of {0} is: ${1}", typeOfProd, minimum);   
 }
}
*/
/*
Lowest Price of bread is: $2,05
Lowest Price of mil is: $1,25
Lowest Price of egg is: $2,9
*/

//***************************************************************
// CHANGING THE VOID FUNCTION TO A FLOAT FUNCTION TO BE RETURNED

using System;
 
public class CheapestPrice
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.05f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        Console.Clear();
  // Step 3 - We add a ConsoleWriteline to this line below
  // MinCalc(breadPrices, "bread"); 
 // Console.WriteLine("The minimum value is: {0}", MinCalc(breadPrices)); // Step 4 b- we can get rid of the string typeProd "bread" parameter because it s not being used anymore
    // Step 5 - We can also still include "bread" parameter, but is belonging now to the ConsoleWriteLine parameter like this:
    Console.WriteLine("The minimum value of {1} is: {0}", MinCalc(breadPrices),"bread"); // bread goes into {1} and MinCalc(breadPrices) goes into {0}
    // Step 6 - But for the code above to work we need to take out the other two arguments below away for this to work
   /* MinCalc(milkPrices, "mil");
    MinCalc(eggPrices, "egg");
    */
     /*
     MinCalc(milkPrices);
     MinCalc(eggPrices);
     */
 //Step 7 - Now to reteurn all of them we use the code below:
  Console.WriteLine("The minimum value of {1} is: {0}", MinCalc(milkPrices),"milk");
  Console.WriteLine("The minimum value of {1} is: {0}", MinCalc(eggPrices),"egg");

    }
    // Step. 1 - here we change the void function to a float function to be later returned
 // static public float MinCalc(float[] numbers, string typeOfProd) 
 static public float MinCalc(float[] numbers) // Step 4 a- we can get rid of the string typeProd parameter because it s not being used anymore
 {
  float minimum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] < minimum)
                minimum = numbers[i];
        }
        // Step. 2 - we change te entire Console.Writeline statement for the return statment with the variable minimum'
        // Console.WriteLine("Lowest Price of {0} is: ${1}", typeOfProd, minimum);   
        return minimum;
 }
}
/*
The minimum value of bread is: 2,05
The minimum value of milk is: 1,25
The minimum value of egg is: 2,9
*/