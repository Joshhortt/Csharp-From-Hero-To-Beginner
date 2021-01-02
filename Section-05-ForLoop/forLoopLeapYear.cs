/*
Let's write an application that tells users the leap years
 that occurred during their lives. We'll begin with a 
 forLoopLeapYear.cs file containing the following:
*/

using System;

class LeapYear
{
  static void Main()
  {
    Console.WriteLine("What year were you born in?");
    string stringBirthYear = Console.ReadLine();
    int birthYear = int.Parse(stringBirthYear);

    Console.WriteLine("You were alive during these leap years:");
    for (int year = birthYear; year <= 2020; year ++)
    {
      if (year % 4 == 0)
      {
        Console.WriteLine(year);
      }
    }
      }
}

/* 
Here we ask for the user's birth year and save the input into the variable birthYear. In our for loop, we:

Initialize the year variable, setting it to the user's birthYear.
Tell the loop to stop running when year <= 2020 is no longer true.
Tell the loop to add 1 to our year for every iteration of the loop.
For each iteration of the loop, we run this code:

if (year % 4 == 0)
{
  Console.WriteLine(year);
}
For every year divisible by 4, the modulo comes out to 0, which makes year % 4 == 0 evaluate to true. 
Every year divisible by 4 is a leap year, so we print it for the user in Console.WriteLine(year);. 
(There are some exceptions to this rule - we'll do an exercise later to deal with all the complexities 
of leap years!)
*/