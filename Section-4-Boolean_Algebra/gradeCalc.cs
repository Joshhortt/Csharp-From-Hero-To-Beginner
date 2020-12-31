
using System;

public class GradeCalculator
{
    static public void Main()
      
    { 
       
        int result;

        Console.Clear();
        Console.WriteLine("What is the Final Result!\n");
        result = Convert.ToInt32(Console.ReadLine());

        if (result >= 95)
        {
            Console.WriteLine("\nGrade A"); 
        }
        else if (result >= 85)
        {
            Console.WriteLine("\nGrade B"); 
        }
        else  if (result >= 75)
        {
            Console.WriteLine("\nGrade C"); 
        }
        else if (result >= 50)
        {
            Console.WriteLine("\nGrade D"); 
        }
        else  
        {
            Console.WriteLine("\nFailed"); 
        }

        Console.WriteLine("\nCalculation over!"); 
    }
}
/*
What is the Final Result!

76

Your Grade is C
*/


// ######################## WITH 1 IF STATEMENT ###########################

/*using System;

public class GradeCalculator
{
    static public void Main()
      
    { 
       
        int result;

        Console.Clear();
        Console.WriteLine("What is the Final Result!\n");
        result = Convert.ToInt32(Console.ReadLine());

         if (result >= 95)
        {
            Console.WriteLine("\nGrade  A"); 
        }
        
        Console.WriteLine("\nCalculation over!"); 
    }
}

/*
What is the Final Result!

99

Grade A


OR

What is the Final Result!

59

Calculation over!

*/


// ######################## WITH 2 IF's ELSE STATEMENTS ###########################

/*using System;

public class GradeCalculator
{
    static public void Main()
      
    { 
       
        int result;

        Console.Clear();
        Console.WriteLine("What is the Final Result!\n");
        result = Convert.ToInt32(Console.ReadLine());

         if (result >= 95)
        {
            Console.WriteLine("\nGrade  A"); 
        }
        if (result >= 85)
        {
            Console.WriteLine("\nGrade B"); 
        }
        else if (result >= 75)
        {
            Console.WriteLine("\nGrade C"); 
        }
        else if (result >= 50)
        {
            Console.WriteLine("\nGrade D"); 
        }
        else  
        {
            Console.WriteLine("\Failed"); 
        }

        Console.WriteLine("\nCalculation over!"); 
    }
}

/*
What is the Final Result!

99

Grade A
Grade B

*/


// ######################## WITH 4 IF ELSE STATMENTS ###########################

/*using System;

public class GradeCalculator
{
    static public void Main()
      
    { 
       
        int result;

        Console.Clear();
        Console.WriteLine("What is the Final Result!\n");
        result = Convert.ToInt32(Console.ReadLine());

         if (result >= 95)
        {
            Console.WriteLine("\nGrade  A"); 
        }
        if (result >= 85)
        {
            Console.WriteLine("\nGrade B"); 
        }
        if (result >= 75)
        {
            Console.WriteLine("\nGrade C"); 
        }
        if (result >= 50)
        {
            Console.WriteLine("\nGrade D"); 
        }
        else  
        {
            Console.WriteLine("\Failed"); 
        }

        Console.WriteLine("\nCalculation over!"); 
    }
}

/*
What is the Final Result!

99

Grade A
Grade B
Grade C
Grade D

OR

What is the Final Result!

74

Grade D

Calculation over!

*/