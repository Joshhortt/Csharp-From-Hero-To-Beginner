/*
using System;
using System.IO;

class FileTotal
{
	static void Main()
	{
		if(!File.Exists("prices.txt")) return;

		float total = 0;
		foreach(string p in File.ReadLines("prices.txt"))
		{
			float price;
			if(float.TryParse(p, out price))
			{
				total += price;
			}
		}
		Console.Clear();
		Console.WriteLine("Total of values in file is: " + total);
	}
}
// Total of values in file is: 18
*/


// This code does the same but I removed ("prices.txt")
// all over the place and changed to filename.
using System;
using System.IO;

class FileTotal
{
	static void Main()
	{
		string filename = ("prices.txt");
		if(!File.Exists(filename)) return;

		float total = 0;
		foreach(string p in File.ReadLines(filename))
		{
			float price;
			if(float.TryParse(p, out price))
			{
				total += price;
			}
		}
		Console.Clear();
		Console.WriteLine("Total of values in file is: " + total);
	}
}

// Total of values in file is: 18