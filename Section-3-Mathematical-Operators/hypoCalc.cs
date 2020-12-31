using System;

public class HypoCalc
{
    static public void Main()
      
    { 
        string sideA;
        string sideB;

        Console.Clear();
        Console.WriteLine("Let's Calculate the Hypoteneuse!");
        
        Console.WriteLine("Please enter side A");
        sideA = Console.ReadLine();

        Console.WriteLine("Please enter side B");
        sideB = Console.ReadLine();
       
        float a = Convert.ToSingle(sideA);
        float b = Convert.ToSingle(sideB);
        double h2 = Math.Pow(a,2) + Math.Pow(b,2);
        double h = Math.Sqrt(h2);

        Console.WriteLine ("The Length is {0}", h);
    }
}

/*
Let's Calculate the Hypoteneuse!
Please enter side A
3
Please enter side B
4
The Length is 5
*/
