
using System;
 
public class ScoreProcessing
{
    static public void Main () 
    {
        int[] scores;

        int numScores;
        Console.WriteLine("How many scores?");
        numScores = Convert.ToInt32(Console.ReadLine());

        scores = new int[numScores];

        for(int i = 0; i < scores.Length; i++)
        {
             Console.WriteLine("Enter score number: {0}", i);
             scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Processing Here =========");
        foreach(int box in scores)
        {
            Console.WriteLine("{0}", box/25.0f * 100);
        }
    }
}

/*
How many scores?
5
Enter score number: 0
6
Enter score number: 1
3
Enter score number: 2
9
Enter score number: 3
7
Enter score number: 4
4
Processing Here =========
24
12
36
28
16
*/

// *************************************************************

/*You can also use a foreach statement to iterate through an array.


using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int []  n = new int[10]; /* n is an array of 10 integers 
         
         // initialize elements of array n 
         for ( int i = 0; i < 10; i++ ) {
            n[i] = i + 100;
         }
         
         // output each array element's value 
         foreach (int j in n ) {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Console.ReadKey();
      }
   }
}
 When the above code is compiled and executed, it produces the following result:

Element[0] = 100
Element[1] = 101
Element[2] = 102
Element[3] = 103
Element[4] = 104
Element[5] = 105
Element[6] = 106
Element[7] = 107
Element[8] = 108
Element[9] = 109
*/