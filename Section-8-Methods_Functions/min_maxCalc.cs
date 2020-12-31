using System;
 
public class CheapestPrice
{
    static public void Main () 
    {
    	float[] breadPrices = {3.45f,3.10f,2.56f,2.05f,3.95f};
        float[] milkPrices = {1.50f,2.50f,1.75f,2.05f,1.25f,2.35f,3.05f};
        float[] eggPrices = {4.50f,3.65f,2.90f,4.10f};

        Console.Clear();

        // Step 8 - Now want to calculate the difference between the minimum price and maximum price fom breadPrices, 
        // we add the two lines os code below
        float minBread = MaxCalc(breadPrices) - MinCalc(breadPrices);
        Console.WriteLine("The difference between the minimum and maximum bread prices is: {0}", minBread);

         float minMilk = MaxCalc(milkPrices) - MinCalc(milkPrices);
        Console.WriteLine("The difference between the minimum and maximum milk prices is: {0}", minMilk);

         float minEgg = MaxCalc(eggPrices) - MinCalc(eggPrices);
        Console.WriteLine("The difference between the minimum and maximum egg prices is: {0}", minEgg);
    }

    static public float MinCalc(float[] numbers)
    {
        float minimum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] < minimum)
                minimum = numbers[i];
        }
        return minimum;
    }
   // Step 9 -  So  make the calculations of Step 8 we need to add a MaxCalc function
   // Just copy the whole minCalc function below and change the values to maxCalc , 
   // to maximum and > greater than and it shoud work fine.
    static public float MaxCalc(float[] numbers)
    {
        float maximum = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if(numbers[i] > maximum)
                maximum = numbers[i];
        }
        return maximum;
    }
}

/*
The difference between the minimum and maximum bread prices is: 1,9
The difference between the minimum and maximum milk prices is: 1,8
The difference between the minimum and maximum egg prices is: 1,6
*/