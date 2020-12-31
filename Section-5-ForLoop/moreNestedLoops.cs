
/*
C# allows to use one loop inside another loop. Following section shows few examples to illustrate the concept.

Syntax
The syntax for a nested for loop statement in C# is as follows −

for ( init; condition; increment ) {
   for ( init; condition; increment ) {
      statement(s);
   }
   statement(s);
}
The syntax for a nested while loop statement in C# is as follows −

while(condition) {
   while(condition) {
      statement(s);
   }
   statement(s);
}
The syntax for a nested do...while loop statement in C# is as follows −

do {
   statement(s);
   do {
      statement(s);
   }
   while( condition );
}
while( condition );
A final note on loop nesting is that you can put any type of loop inside of any other type of loop. For example a for loop can be inside a while loop or vice versa.

Example
The following program uses a nested for loop to find the prime numbers from 2 to 100 −

*/
using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         /* local variable definition */
         int i, j;
         
         for (i = 2; i < 100; i++) {
            for (j = 2; j <= (i / j); j++)
            if ((i % j) == 0) break; // if factor found, not prime
            if (j > (i / j)) Console.WriteLine("{0} is prime", i);
         }
         Console.ReadLine();
      }
   }
} 

/*
2 is prime
3 is prime
5 is prime
7 is prime
11 is prime
13 is prime
17 is prime
19 is prime
23 is prime
29 is prime
31 is prime
37 is prime
41 is prime
43 is prime
47 is prime
53 is prime
59 is prime
61 is prime
67 is prime
71 is prime
73 is prime
79 is prime
83 is prime
89 is prime
97 is prime
*/