using System;

public class MoreBooleans
{
    static public void Main()
        
    {  
        
       bool A = true; 
       bool B = true;
       bool C = true;

        if (A && B && C)
        {
             Console.WriteLine("All values are true"); 
        }
    }
}

// ONE VALUE IS TRUE, WITHOUT BEING CERTAIN WHICH ONE"

/*
using System;

public class MoreBooleans
{
    static public void Main()
        
    {  
        
       bool A = true; 
       bool B = true;
       bool C = true;

        if (A || B || C)
        {
             Console.WriteLine("One value is true"); 
        }
    }
}

One value is true   
*/

// && HAS PRECEDENCE IN RELATION TO ||

/*
using System;

public class MoreBooleans
{
    static public void Main()
        
    {  
        
       bool A = true; 
       bool B = true;
       bool C = true;

        if (A || B & C)
        {
             Console.WriteLine("This statement is true"); 
        }
    }
}

This statement is true   
*/