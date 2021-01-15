// 64. Hangman part 1

using System;
using System.IO;
 
public class HangmanStarter
{
    static public void Main () 
    {
        string[] words = File.ReadAllLines("words.txt");
        string guess = "";

        Random rnd = new Random();
        int wordnum = rnd.Next(0, words.Length);

        Console.Clear();
        Console.WriteLine(words[wordnum]);

        Console.Write("Guess a letter: ");
        guess = Console.ReadLine().ToLower();

        foreach(char c in words[wordnum].ToLower())
        {
           if(guess[0] == c) 
           {
               Console.Write(guess);
           }
            else
            Console.Write("_");
        }
        Console.WriteLine();

        PrintHangman(10);
    }

    static void PrintHangman(int wrongTimes)
    {
        if(wrongTimes > 3)
            Console.WriteLine("__________ ");
        if(wrongTimes > 4)
            Console.WriteLine(" |/      | ");
        else if(wrongTimes > 2)
            Console.WriteLine(" |/      ");
        
        if(wrongTimes > 8)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" |      / \\ ");
        }
        else if(wrongTimes > 7)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" |       |  ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 6)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" |      \\|/ ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 5)
        {
            Console.WriteLine(" |      (_) ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        else if(wrongTimes > 1)
        {
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
            Console.WriteLine(" | ");
        }
        if(wrongTimes > 0)
            Console.WriteLine("_|___");
    }
}
/*
OUTPUT:

Apples
Guess a letter: a
a_____
__________
 |/      |
 |      (_)
 |      \|/
 |       |
 |      / \
_|___

*/