/*
 6. ARRAYS - CHALLENGE

Modify the Caesar Cipher to ask the user how many characters to shift by 
and then apply this to the encryption. 

*/

using System;
 
public class CaesarCipher
{
    static public void Main () 
    {
        string plaintext;
        // 1. I added an int variable called shift
        int shift;

        Console.Clear();
        // 2. I added a Writeline asking the suer how many characters you want to shift by
        Console.WriteLine("How many letters would you like to shift by:");
       // 3. Then I had to convert in to string
        shift = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your text:");
        plaintext = Console.ReadLine();

        foreach(char c in plaintext)
        {
            if(c == ' ')
            {
                Console.Write(" ");
            }
            else
            {
                char letter = c;
                if(letter >= 'X' && letter <= 'Z') 
                {
                    letter = (char)(letter-26);
                }
                else if(letter >= 'x' && letter <= 'z') 
                {
                    letter = (char)(letter-26);
                }
                // 4. Finally I removed the number and changed it by the variable shift'
                Console.Write("{0}",(char)(letter+shift));
            }
        }
        Console.Write("\n");
    }
}

/*
How many characters you want to shift:
2
Enter your text:
Ana is Awesome
Cpc ku Cyguqog

*/