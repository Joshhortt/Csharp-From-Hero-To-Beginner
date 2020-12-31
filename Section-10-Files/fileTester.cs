using System;
using System.IO;

class FileTester
{
	static void Main()
	{
		string text = File.ReadAllText("limerick.txt");

		string[] words = text.Split(' ');

		Console.Clear();

		foreach(string w in words)
		{
			Console.WriteLine(w);	
		}

	}
}
/*
an
old
man
named
Bill
Who
swallod
a
nuclear
pill
The
doctor
sais
cough
And
that
darn
thing
went
of
And
they
found
his
head
in
Brazil
*/