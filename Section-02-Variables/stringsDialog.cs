using System;

public class StringExplorer
{
    static public void Main()
    {   
        string name;
        string age;
        Console.Clear();
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();

        Console.WriteLine("{0} Nice to meet you are {1}.", name, age);
    }
}
