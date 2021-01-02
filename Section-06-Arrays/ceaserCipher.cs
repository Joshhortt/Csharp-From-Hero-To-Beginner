/*using System;

public class CeaserCipher 
{
    static public void Main ()
    {
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter your text you want to cipher:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            Console.Write("{0}", (char)(c+3));
        }
        Console.Write("\n");
    }
}
*/
/*
Enter your text you want to cipher:
icon
lfrq
*/

//*******************************************
// If we write a sentence and we don´t wat the cardinal symbol in between the spaces
// we can do this like here: 
/*
using System;

public class CeaserCipher 
{
    static public void Main ()
    {
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter your text you want to cipher:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(' ');
            }
            else{  
            Console.Write("{0}", (char)(c+3));
            }
        }
        Console.Write("\n");
    }
}
*/
/*
Enter your text you want to cipher:
icon is gear
lfrq lv jhdu
*/

//*******************************************
// If we write a sentence with all letters of the Alphabeth it prints ou something strange:
// Have a loo.
/*
using System;

public class CeaserCipher 
{
    static public void Main ()
    {
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter your text you want to cipher:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(' ');
            }
            else{  
            Console.Write("{0}", (char)(c+3));
            }
        }
        Console.Write("\n");
    }
}
*/
/*
Enter your text you want to cipher:
The quick brown fox jumps over the lazy dog
Wkh txlfn eurzq ir{ mxpsv ryhu wkh od}| grj

I f you see there are curly braces and a pipe. It's because if you count + 3 after the letter x 
in the ASCII table you can check that lower case x + 3 is the open curly brace. The same happens wit 'y' an 'z'
PLEASE CHECK ASCII TABLE to verify this.
*/

// To correct that use this code:

using System;
 
public class CaesarCipher
{
    static public void Main () 
    {
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter your text:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(" ");
            }
            else
            {

                // we have to count the upper case letter to - 26
                char letter = c;
                if(letter >= 'X' && letter <= 'Z') 
                {
                    letter = (char)(letter-26);
                }
                // we have to count the lower case letter to - 26
                else if(letter >= 'x' && letter <= 'z') 
                {
                    letter = (char)(letter-26);
                }

                Console.Write("{0}",(char)(letter+3));
            }
        }
        Console.Write("\n");
    }
}

/*
Enter your text:
The quick brown fox jumps over the lazy dog
Wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj
*/