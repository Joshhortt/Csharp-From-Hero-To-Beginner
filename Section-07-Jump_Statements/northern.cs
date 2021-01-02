using System;

public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
        string[] lines = fileContents.Split('\n');

        foreach(string love in lines)
        {
            if(love.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = love.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            
            //greater than to include northern
            //hemisphere cities
            if(lat > 0)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    
    }
}