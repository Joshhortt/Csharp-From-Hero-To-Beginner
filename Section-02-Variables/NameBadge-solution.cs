using System;
 
public class NameBadge
{
    static public void Main ()
    {
    	string name;
        string job;
    	string company;
    	Console.Clear();
    	Console.WriteLine("Enter Your Name: ");
    	name = Console.ReadLine();
		Console.WriteLine("Enter Your Job Title: ");
    	job = Console.ReadLine();
        Console.WriteLine("Enter Your Company Name: ");
        company = Console.ReadLine();

    	Console.WriteLine ("|**********************|");
        Console.Write("|Name:");
        Console.WriteLine ("{0,17}|", name);
        Console.WriteLine ("|{0,22}|", job);
        Console.WriteLine ("|----------------------|");
        Console.WriteLine ("|{0,22}|", company);
        Console.WriteLine ("|**********************|");
    }
}