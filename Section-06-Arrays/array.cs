/*
using System;
 
public class Array
{
    static public void Main () 
    {
        int[] scores = {5, 6, 8, 6, 9, 7, 3};
        for(int i = 0; i < 7; i++)
       
            Console.WriteLine("% {0}", scores[i]/25.0f * 100);
        }
    }

% 20
% 24
% 32
% 24
% 36
% 28
% 12
*/


using System;
 
public class Array
{
    static public void Main () 
    {
        int[] scores;

        int numScores;
        Console.WriteLine("How many scores?");
        numScores = Convert.ToInt32(Console.ReadLine());

        scores = new int[numScores];

        for(int i = 0; i < scores.Length; i++)
        {
             Console.WriteLine("Enter score number: {0}", i);
             scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Processing Scores Here =========");
        for(int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("% {0}", scores[i]/25.0f * 100);
        }
    }
}
/*
How many scores?
3
Enter score number: 0
8
Enter score number: 1
7
Enter score number: 2
5
Processing Scores Here =========
% 32
% 28
% 20
*/