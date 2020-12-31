using System;

public class ForLoop
{
    static public void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine ("{0}", i);
        }
    }
    
}

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
*/


// Addding 2 to i
/*

using System;

public class ForLoop
{
    static public void Main()
    {
        for (int i = 1; i <= 10; i+=2)
        {

            Console.WriteLine ("{0}", i);
        }
    } 
}

1
3
5
7
9

*/


//The i is only used as a counter
/*

using System;

public class ForLoop
{
    static public void Main()
    {
        for (int i = 1; i <= 10; i++)
        {

            Console.WriteLine ("Hello World");
        }
    } 
}

*/