
/*Challenge 5
Write a program that has two strings, 
one set to the word "apple" and one set 
to the word "orange". Use the String.
Compare method to write a message to the 
console telling us which word comes before 
the other in the alphabet or if the words 
are the same.
*/

using System; 

class StringPlay
{
    static void Main()
    
    {   
        string word1 = "apple"; 
        string word2 = "orange"; 
      
        Console.Clear();
        if(String.Compare(word1, word2) < 0)
        {
            Console.WriteLine("The word {0} comes first then the word {1}: ", word1, word2);  
        }
         else if(String.Compare(word1, word2) > 0)
        {
            Console.WriteLine("The word {0} comes first then the word {1}: ", word2, word1);  
        }
        else
        {
             Console.WriteLine("The Words are different.");
        }
    }
}

// The word apple comes first then the word orange: