/*
using System;
 
public class ThrowCatch
{
    static public void Main () 
    {
    	int i = 0;
        Console.WriteLine("Enter and Integer: ");
        i = Convert.ToInt32(Console.ReadLine());
    }
}


Enter and Integer:
5


HERE IF WE DO NOT TYPE AN INTEGER IT THROWS OUR AN [ERROR] FATAL UNHANDLED EXCEPTION: 

C:\Users\josec\CPrograms\Section-8-Methods_Functions>mono throwCatch.exe
Enter and Integer:
s

Unhandled Exception:
System.FormatException: Input string was not in a correct format.
  at System.Number.ThrowOverflowOrFormatException (System.Boolean overflow, System.String overflowResourceKey) [0x0001a] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Number.ParseInt32 (System.ReadOnlySpan`1[T] value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info) [0x00016] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Int32.Parse (System.String s, System.IFormatProvider provider) [0x00017] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Convert.ToInt32 (System.String value) [0x0000b] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at ThrowCatch.Main () [0x00011] in <eac3c6c041944a61a38b22aa2814ed28>:0
[ERROR] FATAL UNHANDLED EXCEPTION: System.FormatException: Input string was not in a correct format.
  at System.Number.ThrowOverflowOrFormatException (System.Boolean overflow, System.String overflowResourceKey) [0x0001a] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Number.ParseInt32 (System.ReadOnlySpan`1[T] value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info) [0x00016] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Int32.Parse (System.String s, System.IFormatProvider provider) [0x00017] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Convert.ToInt32 (System.String value) [0x0000b] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at ThrowCatch.Main () [0x00011] in <eac3c6c041944a61a38b22aa2814ed28>:0

*/

// *************************************************************************************

// HOW TO HANDLE THOSE EXCEPTIONS ELEGANTLY: 
/*
using System;
 
public class ThrowCatch
{
    static public void Main () 
    {
    	int i = 0;
        Console.WriteLine("Enter and Integer: ");

        try
        {
           i = Convert.ToInt32(Console.ReadLine()); 
        }
        catch (Exception e)
        {
           Console.WriteLine("HERE THE ERROR WAS: " + e); 
        }
    }
}

// HERE the variable e´ catches the error message
Enter and Integer:
s
HERE THE ERROR WAS: System.FormatException: Input string was not in a correct format.
  at System.Number.ThrowOverflowOrFormatException (System.Boolean overflow, System.String overflowResourceKey) [0x0001a] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Number.ParseInt32 (System.ReadOnlySpan`1[T] value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info) [0x00016] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Int32.Parse (System.String s, System.IFormatProvider provider) [0x00017] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at System.Convert.ToInt32 (System.String value) [0x0000b] in <37fb70ba30fd488fb1a64f25ba9e9b0d>:0
  at ThrowCatch.Main () [0x00011] in <574b5375ec304b3893f355f7c9fcf3e0>:0
*/

// *************************************************************************************

// HOW TO HANDLE THOSE EXCEPTIONS ELEGANTLY PART 2: 
/*
using System;
 
public class ThrowCatch
{
    static public void Main () 
    {
    	int i = 0;
        Console.WriteLine("Enter and Integer: ");

        try
        {
           i = Convert.ToInt32(Console.ReadLine()); 
        }
        catch (Exception e)
        {
           Console.WriteLine("INVALID INPUT! Try again: " ); 
        }
    }
}


JUST BY REMOVING THE VARIABLE FROM Console.Writeline 
we can print a message out without displaying the whole error message

Enter and Integer:
h
INVALID INPUT! Try again:

*/
// THE EXCEPTION AVOIDS THAT THE PROGRAM CRASHES.


// *************************************************************************************

// NOW TLET'S SEE HOW TO HANDLE EXCEPTIONS WITH THE THROW' STATEMENT INCLUDED 

using System;
 
public class ThrowCatch
{
    static public void Main () 
    {
    	int i = 0;
        Console.WriteLine("Enter and Integer: ");

        try
        {
            // STEP 2 - WE CHANGE THES LINE OF CODE FOR THE FOLLOWING
           // i = Convert.ToInt32(Console.ReadLine()); 
           i = getInteger();
        }
        catch (Exception e)
        {
           Console.WriteLine("INVALID INPUT! Try again: " ); 
        }
    }

    // STEP 1 - HERE WE GONNA CREATE A FUNCTION
    static int getInteger () 
    {
        string input = Console.ReadLine();
        int val;
        if(!int.TryParse(input,out val));
        {
            throw new Exception();
        }
            return val;
    }
}

/*
Enter and Integer:
h
INVALID INPUT! Try again:
*/