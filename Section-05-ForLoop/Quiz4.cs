//Quiz 4 - SECTION 5 LOOPS

/*
Question 1:
What will the following print?

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}",i);
}
*/
/*
using System;

namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}",i);
            }
		}
	}
}
*/
/*
0
1
2
3
4
5
6
7
8
9

Math her
i=0, 
i=1,
i=2,
etc... till i=9 --> because i=9 less then i<10

// ********************************************************************


/*
Question 2:
What will the following print?

for (int i = 0; i < 5; i+=2)
{
   Console.WriteLine("{0}",i);
}

*/

using System;

namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
            for (int i = 0; i < 5; i+=2)
            {
            Console.WriteLine("{0}",i);
            }                                  
		}
	}
}

/*
0
2
4

Math her
i=0, +2
i=2, +2
i=4,


// ********************************************************************

/*
Question 3:
What will the value of total be after this loop?

int total = 0;
int i = 2;
while(i < 9)
{
    total += 2;
    i += 1;
}
*/
/*
using System;

namespace Loop
{
	class WhileLoop
	{
		public static void Main(string[] args)
		{
			int i=2; 
            int total=0;

			while (i<9)
			{
				total += 2;
				i++;
			}
			Console.WriteLine("Total = {0}", total);
		}
	}
}
*/
/*
Total = 14

The Math here: 
i=2, + 2 total =4
i=4, +2 total =6
i=5, +2 total =8
i=6. +2 total= 10
i=7, +2 total=12
i=8, +2 total =14

// ********************************************************************

/*
Question 4:
What will the value of total be after this loop?

int total = 0;
int i = 2;
do
{
    total += 2;
    i += 1;
} while( i < 5);
*/
/*
using System;

namespace Loop
{
	class DoWhileLoop
	{
		public static void Main(string[] args)
		{
            int total = 0;
            int i = 2;
            do
            {
                total += 2;
                i += 1;
                
            } while( i < 5);
			
			Console.WriteLine("Total = {0}", total);
		}
	}
}
*/
/*
Total = 6

The Math here: 
i=2, + 2 total =4
i=4, +2 total =6

*/
// ********************************************************************

/*
Question 5:
What will the value of total be after this loop?

int total = 10;
int i = 2;
do
{
    total += 3;
    i += 1;
 } while( i < 3);

*/
/*
using System;

namespace Loop
{
	class DoWhileLoop
	{
		public static void Main(string[] args)
		{
            int total = 10;
            int i = 2;
            do
            {
                total += 3;
                i += 1;
            } while( i < 3);
			
			Console.WriteLine("Total = {0}", total);
		}
	}
}
*/
/*
Total = 13

The Math here: 
i=10, + 3 total =13

*/

// *************************************************************

/*
Question 6:
What will print out of this loop?

for(int i = 0; i < 2; i++)
{
    for(int j = 1; j < 3; j++)
    {
        Console.WriteLine(i*j);
    }
}
*/
/*
using System;

namespace Loop
{
	class NestedLoop
	{
		public static void Main(string[] args)
		{
for(int i = 0; i < 2; i++)
{
    for(int j = 1; j < 3; j++)
    {
        Console.WriteLine(i*j);
    }
	}
}
*/
/*

0
0
1
2

Math for this
i = 0, j = 0;
       j = 1;
       j = 2;
*/



// *************************************************************

/*
Question 7:
What will this print out?

for(int i = 0; i < 10; i++)
{
    for(int j = 1; j < 2; j++)
    {
        Console.WriteLine(i+j);
    }
}

*/
/*
using System;

namespace Loop
{
	class NestedLoop
        {
            public static void Main(string[] args)
            {
            for(int i = 0; i < 10; i++)
                {
                    for(int j = 1; j < 2; j++)
                    {
                        Console.WriteLine(i+j);
                    }
                }
             }
    }
}
*/
/*
1
2
3
4
5
6
7
8
9
10

The Math here: 
i=0, +1   j=1
i=1, +1 
i=2, +1 
i=3, +1
i=4, +1 
i=5, +1 
i=6. +1 
i=7, +1 
i=8, +1 
i=9 +1

i=9 + j = 1 --> 

*/


// *************************************************************

/*
Question 8:
What will this print out?

int i = 0;
while (i < 5) 
{
    Console.WriteLine("hi");
    i++;
}

*/
/*
using System;

namespace Loop
{
	class WhileLoop
        {
            public static void Main(string[] args)
            {
                int i = 0;
                while (i < 5) 
                {
                    Console.WriteLine("hi");
                    i++;
                }
             }
    }
}
*/
/*

hi
hi
hi
hi
hi

The Math here:
i=0, hi
i=1, hi 
i=2, hi 
i=3, hi
i=4, hi
*/



// *************************************************************

/*
Question 9:
What will this print?

int i = 0;
do 
{
    Console.WriteLine("hi");
    i+=2;
} while(i < 3);

*/
/*
using System;

namespace Loop
{
	class DoWhileLoop
        {
            public static void Main(string[] args)
            {int i = 0;
                do 
                {
                    Console.WriteLine("hi");
                    i+=2;
                } while(i < 3);
             }
    }
}
*/
/*

hi
hi

The Math here:
i=0, +2 => i=2

Math
i=2 + 2, 0> i=4 <-- not bpossible because must be i < 3

*/



// *************************************************************

/*
Question 10:
What will this print?

int i = 10;
do 
{
    Console.WriteLine(i);
     i-=3;
} while(i > -4);

*/
/*
using System;

namespace Loop
{
	class DoWhileLoop
        {
            public static void Main(string[] args)
            {
                int i = 10;
                do 
                {
                    Console.WriteLine(i);
                    i-=3;
                } while(i > -4);

             }
    }
}
*/
/*

10
7
4
1
-2

The Math here:
i=10     -3
i= 7     -3
i=4      -3
i=1      -3
i= -2
*/




