/*
using System;
 
public class Ceiling
{
    static public void Main () 
    {
    	double value = 7.03; // positive double
    	Console.WriteLine("The ceiling of {0} is {1}",value,Math.Ceiling(value));
    }
 }

 // The ceiling of 7,03 is 8
*/
 /*
 NOTE:
 The behavior of this method follows IEEE Standard 754, section 4. 
 This kind of rounding is sometimes called rounding toward positive infinity. 
 In other words, if d is positive, the presence of any fractional component 
 causes d to be rounded to the next highest integer. If d is negative, 
 the rounding operation causes any fractional component of d to be discarded. 
 The operation of this method differs from the Floor(Decimal) method, 
 which supports rounding toward negative infinity.
 */

 using System;
 
public class CeilingValues
{
    static public void Main () 
    {
    	double value = -7.03; // negative double
    	Console.WriteLine("The ceiling of {0} is {1}",value,Math.Ceiling(value));
    }
 }

 // The ceiling of -7,03 is -7