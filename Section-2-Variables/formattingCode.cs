using System;

public class FormattingCode
{
    static public void Main()
    {   
       
        string s = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                      "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                      "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                      "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in" +
                      "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."

                      Console.WriteLine ("{0}\nand the length sentence is: {1}", s, s.Length);
    }
}
