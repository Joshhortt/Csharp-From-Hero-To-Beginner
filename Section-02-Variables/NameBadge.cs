using System;

public class NameBadge
{
    static public void Main()
    {   
        string name;
        string job;
        string company; 
        
        Console.Clear();

        Console.WriteLine("What is your Name?");
        name = Console.ReadLine();

        Console.WriteLine("What is your Job?");
        job = Console.ReadLine();
      
        Console.WriteLine("What is your Company?");
        company = Console.ReadLine();

            Console.WriteLine("\nThis is your Badge:\n");
        
            Console.WriteLine("| ****************************** |");
            Console.Write("| Name:");
            Console.WriteLine("{0,25} |", name);
            Console.WriteLine("| {0,30} |", job);
            Console.WriteLine("| ------------------------------ |");
            Console.WriteLine("| {0,30} |", company);
            Console.WriteLine("| ****************************** |");
            
        }    
    }
