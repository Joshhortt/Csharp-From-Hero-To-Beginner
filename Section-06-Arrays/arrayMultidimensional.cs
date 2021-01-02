using System;

public class MultidimensionalArray 
 {

    static public void Main() 
    {
        int[,] fooddata = new int[5,6] {/*Gms, Cal, Pr, Cb, Fb, Fat*/
                    /*Cows Milk */     {976, 660, 32, 48, 0, 40},
                    /*Buttermilk*/     {246, 127, 9, 13, 0, 5},
                    /*Yogurt*/         {250, 128, 18, 13, 1, 4},
                    /*Cheddar*/        {17, 70, 4, 6, 0, 11},
                    /*Egg*/            {100, 150, 12, 6, 0, 12}
        };
        for (int r = 0; r < 5; r++)
        {
            for(int c = 0; c < 6; c++)
            {
                Console.Write("{0}, ", fooddata[r,c]);
            }
            Console.WriteLine("");
        }

        
       
    }
}
/*
976, 660, 32, 48, 0, 40,
246, 127, 9, 13, 0, 5,
250, 128, 18, 13, 1, 4,
17, 70, 4, 6, 0, 11,
100, 150, 12, 6, 0, 12,
*/


/* MORE MULTIDIMENSIONAL ARRAYS
using System;

namespace ArrayApplication {
   class MoreMultidimensionalArray {
      static void Main(string[] args) {
        // an array with 5 rows and 2 columns
         int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };
         int i, j;
         
         // output each array element's value 
         for (i = 0; i < 5; i++) {
            
            for (j = 0; j < 2; j++) {
               Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
            }
         }
         Console.ReadKey();
      }
   }
}
*/
/*
a[0,0] = 0
a[0,1] = 0
a[1,0] = 1
a[1,1] = 2
a[2,0] = 2
a[2,1] = 4
a[3,0] = 3
a[3,1] = 6
a[4,0] = 4
a[4,1] = 8
*/
