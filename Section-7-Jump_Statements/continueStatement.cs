/*
using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
       Console.WriteLine(fileContents);
    
    }
}
*/
/*
CountryName,CapitalName,CapitalLatitude,CapitalLongitude,CountryCode,ContinentName
Somaliland,Hargeisa,9.55,44.050000,NULL,Africa
South Georgia and South Sandwich Islands,King Edward Point,-54.283333,NULL,GS,Antarctica
French Southern and Antarctic Lands,Port-aux-Fran├ºais,-49.35,70.216667,TF,Antarctica
Palestine,Jerusalem,31.766666666666666,35.233333,PS,Asia
Aland Islands,Mariehamn,NULL,19.900000,AX,Europe
Nauru,Yaren,-0.5477,166.920867,NR,Australia
Saint Martin,Marigot,18.0731,-63.082200,MF,North America
Tokelau,Atafu,-9.166667,-171.833333,TK,Australia
Western Sahara,El-Aai├║n,27.153611,-13.203333,EH,Africa

etc.... ALL data down here

*/



//*****************************************************
/*
using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
        string[] lines = fileContents.Split('\n');

        foreach(string l in lines)
        {
            if(l.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if(lat > -30 && lat < 30)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    
    }
}
*/


// **************************************************
/*
using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        string[] lines = fileContents.Split('\n');
       Console.WriteLine("{0}", lines[8]);
    
    }
}

// Tokelau,Atafu,-9.166667,-171.833333,TK,Australia
*/


//***************************************************

using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();

        string[] lines = fileContents.Split('\n');

       foreach(string l in lines)
       {
        if(l.IndexOf("NULL") >= 0)
            {
                Console.WriteLine("Error: {0}", l);
            }
       }
    }
}

/*
Error: Somaliland,Hargeisa,9.55,44.050000,NULL,Africa
Error: South Georgia and South Sandwich Islands,King Edward Point,-54.283333,NULL,GS,Antarctica
Error: Aland Islands,Mariehamn,NULL,19.900000,AX,Europe
Error: Azerbaijan,Baku,NULL,49.866667,AZ,Europe
Error: Barbados,Bridgetown,13.1,NULL,BB,North America
Error: Botswana,Gaborone,NULL,25.900000,BW,Africa
Error: Canada,Ottawa,NULL,-75.700000,CA,Central America
Error: China,Beijing,39.916666666666664,116.383333,NULL,Asia
Error: Cook Islands,Avarua,-21.2,NULL,CK,Australia
Error: Fiji,Suva,NULL,178.416667,FJ,Australia
Error: Ghana,Accra,5.55,NULL,GH,Africa
Error: Ireland,Dublin,NULL,-6.233333,IE,Europe
Error: Moldova,Chisinau,NULL,MD,Europe
Error: Saint Helena,Jamestown,-15.933333333333334,NULL,SH,Africa
Error: San Marino,NULL,43.93333333333333,12.416667,SM,Europe
Error: Thailand,Bangkok,NULL,100.516667,TH,Asia
Error: United States,Washington, D.C.,38.883333,NULL,US,Central America
Error: US Minor Outlying Islands,NULL, D.C.,38.883333,-77.000000,UM,Australia
Error: Northern Cyprus,North Nicosia,35.183333,33.366667,NULL,Europe
*/


// ***********************************************************
/*
using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
        string[] lines = fileContents.Split('\n');

        foreach(string l in lines)
        {
            if(l.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if(lat<0)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    
    }
}
*/
/*
using System;
 
public class ContinueStatement
{
    static public void Main () 
    {
        string fileContents = Console.In.ReadToEnd();
        Console.Clear();
        
        string[] lines = fileContents.Split('\n');

        foreach(string l in lines)
        {
            if(l.IndexOf("NULL") >= 0 || l == lines[0])
            {
                continue;
            }
            string[] fields = l.Split(',');
            float lat = Convert.ToSingle(fields[2]);
            if(lat < 0)
            {
                Console.WriteLine("{0}", fields[1]);
            }
        }
    
    }
}
*/