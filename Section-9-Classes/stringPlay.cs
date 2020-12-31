/*
56. PLAYING WITH STATIC METHODS ANF PROPERTIES
   "DIFFERENCE BETWEEN HAVING A STATIC METHOD AND NOT HAVING A STATIC METHOD"
using System; 

class StringPlay
{
    static void Main()
    
    {   
        string word1 = "Giraffe"; //OUTPUT IS: Words are different.
        string word2 = "Elephant";

        string word1 = "Giraffe"; //PUTPUT IS: Words are the same.
        string word2 = "Giraffe";

        Console.Clear();
        if(String.Compare(word1, word2) == 0)
        {
            Console.WriteLine("Words are the same.");
        }
        else{
             Console.WriteLine("Words are different.");
        }
    }
}

SEE OUTPUT IN CODE ABOVE...
*/

// Now let's see if we want to change tyhe words to uppercase what happens

using System; 

class StringPlay
{
    static void Main()
    
    {   
        /*
        string word1 = "giraffe"; //PUTPUT IS: Words are different.
        string word2 = "giraffe"; // because word2 changed to uppercase and word1 still remains lowercase
        word2 = word2.ToUpper();
       */
    
        string word1 = "giraffe"; //PUTPUT IS: Words are the same.
        string word2 = "giraffe"; // because word1 and word2 changed both to uppercase.
        word1 = word1.ToUpper();
        word2 = word2.ToUpper();

        Console.Clear();
        if(String.Compare(word1, word2) == 0)
        {
            Console.WriteLine("Words are the same.");
        }
        else{
             Console.WriteLine("Words are different.");
        }
    }
}
/*
SEE OUTPUT IN CODE ABOVE...
*/