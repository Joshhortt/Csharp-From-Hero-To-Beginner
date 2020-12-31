
// Part 3

using System;
using System.IO;
 
public class UnCaesarCipher62 // 1. change to UnCeasarCipher62
{
    static public void Main () 
    {
        string filename;
        string plaintext;
        Console.Clear();
        Console.WriteLine("Enter the filename:");
        filename = Console.ReadLine();
        plaintext = File.ReadAllText(filename);
        
        string filetext = "";

        foreach(char c in plaintext)
        {

            if(!char.IsLetter(c))
            {
                filetext += c;
            }
            else
            {

                // we have to count the upper case letter to - 26
                char letter = c;
                 
                // if(letter >= 'X' && letter <= 'Z')  - 4. we need to change characters to uppercase A and C
                   if(letter >= 'A' && letter <= 'C') 
                {
                    // 6. To un cipher we need to send it back using '+26'
                    letter = (char)(letter+26);
                }
                // else if(letter >= 'x' && letter <= 'z') - 5. we need to change characters to lowercase a and c
                else if(letter >= 'a' && letter <= 'c')
                {
                    // 6. To un cipher we need to send it back using '+26'
                    letter = (char)(letter+26);
                }
                  // 2. To un cipher we need to send it back using '-3'              
                filetext += (char)(letter-3);
            }
        }
        Console.Write("\n");
        File.WriteAllText(filename + "un", filetext); // 8. changed "enc" to "un".
       
    }
}

/*
After saving we need to type in the console the following:
mcs unceasarCipher62.cs
mono unceasarCipher62.cs

and than
Enter the filename:
story.txtenc

It creates another file called 'story.txtencun' were all the ciphered text is unciphered again
*/