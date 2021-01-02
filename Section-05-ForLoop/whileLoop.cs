
/*
using System;
public class WhileLoop
{
    static public void Main()
    {

        string input = "";
        while(input != "q")
    
         {
            Console.WriteLine("Enter alphabetical value!");
            input = Console.ReadLine();
         }
            
            Console.WriteLine("Porgramm Over. Goodbye");
    } 
}

a
Enter alphabetical value!
b
Enter alphabetical value!
m
Enter alphabetical value!
n
Enter alphabetical value!
o
Enter alphabetical value!
p
Enter alphabetical value!
q
Porgramm Over. Goodbye
*/

using System;
 
public class WhileLoop
{
    static public void Main () 
    {
        int i;
        Console.Clear();
        Console.WriteLine("Enter 1 for options\n" +
                    "      2 to quit \n" +
                    "      3 to start game.");

        do
        {
            Console.WriteLine("Option?");
            i = Convert.ToInt32(Console.ReadLine());
        }
        while(i < 1 || i > 3);
        Console.WriteLine("Thank-you");
    }
}
/*
Enter 1 for options
      2 to quit
      3 to start game.
Option?
5
Option?
9
Option?
11
Option?
2
Thank-you
*/