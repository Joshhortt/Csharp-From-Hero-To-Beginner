using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         
         /* for loop execution */
         for (int a = 10; a < 20; a = a + 1) {
            Console.WriteLine("value of a: {0}", a);
         }
         Console.ReadLine();
      }
   }
} 

/*
value of a: 10
value of a: 11
value of a: 12
value of a: 13
value of a: 14
value of a: 15
value of a: 16
value of a: 17
value of a: 18
value of a: 19

*/