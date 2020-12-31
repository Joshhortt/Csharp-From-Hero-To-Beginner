/*

Challenge 1
Write a program that reads in a file containing 
one float per line and calculates the average 
and prints it out formatted with 2 decimal places.

*/
using System;
using System.IO;

class AverageChallenge1
{
	static void Main()
	{
		string filename = ("prices.txt");
		if(!File.Exists(filename)) return;

		float total = 0;
        int avg = 0;
		foreach(string p in File.ReadLines(filename))
		{
			float price;
			if(float.TryParse(p, out price))
			{
                avg++;
				total += price;
			}
		}
		Console.Clear();

		Console.WriteLine("Average of values in file is {0:0.00} ",(total/avg));
	}
}
/*
Average of values in file is 4,00
*/