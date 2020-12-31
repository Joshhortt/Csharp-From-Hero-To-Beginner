// 61 Writing Files
/*
using System;
using System.IO;

class FileWriting
{
	static void Main()
	{
		string userInput;
        Console.Clear();
        Console.WriteLine("Enter your name: ");
        userInput = Console.ReadLine();

		File.WriteAllText("details.txt", userInput);

	}
}

the details.txt had 'Josh Hortt' inside the document. Aafter the user prompt to input
it changed to 'Ana Rita'.

*/

// ***********************************************
// Now with the the append method atached to AllText like File.AppendAllText
// we add somethin we input to the existing text inside the file,
// For Example we had Ana Rita. Now we write 'Rebelo' and it will
// attach to it like: Ana Rita Rebelo' will appear inside the Text file.
/*
using System;
using System.IO;

class FileWriting
{
	static void Main()
	{
		string userInput;
        Console.Clear();
        Console.WriteLine("Enter your name: ");
        userInput = Console.ReadLine();

		File.AppendAllText("details.txt", userInput  + "\n"); // it makes a new line right after userInput

	}
}
*/

// ****************************************************
// Now her we gonna grab carDetails61 AND PRINT OUT IN THE 'cars.text' the car details.
// mcs writingFiles.cs carDetails.cs     -    mono writingFiles.exe
using System;
using System.IO;

class WritingFiles
{
	static void Main()
	{
		string filename = "cars.txt";
		File.Delete(filename);
		CarDetails61 c1 = new CarDetails61("Honda","Civic",2006,"red","345RGT");
		Console.Clear();
		c1.PrintDetails(filename);
	}
}

/* OUTPUT IN 'cars.txt is:

Make: Honda
Model: Civic
Year: 2006
Colour: red
Registration: 345RGT
=========================

*/


