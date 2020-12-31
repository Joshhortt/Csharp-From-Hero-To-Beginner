// 62. Ceasar Encrypting a File of Text

// Part 1

/*
using System;
using System.IO;
 
public class CaesarCipher62
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
             if(c == '%')
            {
                Console.WriteLine("\nInvalid character detected.\n");
                continue;
            }
            if(c == ' ')
            {
                filetext += " ";
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

                filetext += (char)(letter+3);
            }
        }
        Console.Write("\n");
        File.WriteAllText(filename + "enc", filetext);
        //File.WriteAllText(filename + "enc", filetext);
    }
}

Enter the filename:
story.txt

It creates another file called story.txtenc where the story.txt file is ciphered and printed.
*/

// Part 2

using System;
using System.IO;
 
public class CaesarCipher62
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
            // we re gonna rid of the lines of code below, we're not using it here anymore.
             /*
             if(c == '%')
            {
                Console.WriteLine("\nInvalid character detected.\n");
                continue;
            }
            */
            if(!char.IsLetter(c))
            {
                filetext += c;
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

                filetext += (char)(letter+3);
            }
        }
        Console.Write("\n");
        File.WriteAllText(filename + "enc", filetext);
        //File.WriteAllText(filename + "enc", filetext);
    }
}

/*
Enter the filename:
story.txt

Now it removes all shifted punctuation that was ciphered before, leaving the real punctuation there.
*/

// Checkout Part 3 in 'unceasarCipher62.cs
