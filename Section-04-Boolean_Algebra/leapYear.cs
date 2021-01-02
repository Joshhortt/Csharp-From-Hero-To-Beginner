using System;

public class BooleanAlgebra
{
    static public void Main() 
    {  
// A Leap Year is a year divisible by 4
// BUT a Leap Year divisible by 100 is not a leap year, UNLESS
// it is also divisble by 400

      int year, test1, test2, test3; 

      Console.Clear();
      Console.WriteLine ("Please Enter a Year!"); 
      year = Convert.ToInt32(Console.ReadLine());

      test1 = year % 4;
      test2 = year % 100;
      test3 = year % 400;

      if (test1 == 0 && test2 != 0 || test3 == 0)
      {
          Console.WriteLine("That's a Leap year");
      }
      else
      {
         Console.WriteLine("That's NOT a Leap year"); 
      }
    }
}

/*

Please Enter a Year!
1905
That's NOT a Leap year


Please Enter a Year!
1904
That's a Leap year


*/
