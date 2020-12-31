/*

using System;
 
public class BasicArray
{
    static public void Main () 
    {
        int[] scores = {5, 6, 8, 6, 9, 7, 3};
        for(int i = 0; scores.Length; i++)
       
            Console.WriteLine("% {0}", scores[i]/25.0f * 100);
        }
    }

    */

    // The following example, demonstrates the above-mentioned concepts declaration, assignment, and accessing arrays −


using System;

namespace ArrayApplication {
   class BasicArray {
      static void Main(string[] args) {
         int []  n = new int[10]; /* n is an array of 10 integers */
         int i,j;

         /* initialize elements of array n */
         for ( i = 0; i < 10; i++ ) {
            n[ i ] = i + 100;
         }
         
         /* output each array element's value */
         for (j = 0; j < 10; j++ ) {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadLine();
      }
   }
}
/*
When the above code is compiled and executed, it produces the following result −

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